using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassScheduler
{
    public partial class BasicCalculationForm : Form
    {
        /// <summary>
        /// This form performs the creation of all schedule combination and the calculation of the fittest one.
        /// The progress of the calculations are shown with the help of a background worker that frees the UI thread.
        /// </summary>
        /// Author: Kostiantyn Makrasnov


        private List<SingleCourse> selectedCourses;
        private int courseAmount;
        private int scheduleAmount;
        private int creditAmount;
        private float percentComplete;
        private bool isOptimization;
        private bool isCancelled = false;
        private List<int> sectionAmountAll; // parallel list that allows for creation of all unique schedules

        private List<SingleSchedule> schedulePopulation;
        private List<SingleSchedule> acceptableSchedulesTemp = new List<SingleSchedule>(20000);
        private List<SingleSchedule> overlapSchedulesTemp = new List<SingleSchedule>(20000);
        private List<SingleSchedule> acceptableSchedules = new List<SingleSchedule>(200);
        private List<SingleSchedule> overlapSchedules = new List<SingleSchedule>(200);
        private List<SingleSchedule> resultSchedules = new List<SingleSchedule>(200);

        private LoadingResultsForm RefToResultLoadForm;
        private CourseSelectionForm RefToCourseSelectForm;


        private Random random;
        private List<string> templateWeek = new List<string> { "M", "T", "W", "TH", "F" };

        int numComplete = 0;

        public BasicCalculationForm(List<SingleCourse> selectedCourses, int numPossib, Random random, int creditAmount,
                                    CourseSelectionForm courseForm, LoadingResultsForm ScheduleSelectForm,
                                    bool isOptimization)
        { 
            //References to previous form/worker
            RefToCourseSelectForm = courseForm;
            RefToResultLoadForm = ScheduleSelectForm;

            //Calculation variables
            this.random = random;
            this.creditAmount = creditAmount;
            this.selectedCourses = selectedCourses;
            this.courseAmount = selectedCourses.Count();
            this.scheduleAmount = numPossib;
            this.isOptimization = isOptimization;

            schedulePopulation = new List<SingleSchedule>(20000);
            this.sectionAmountAll = new List<int>(selectedCourses.Count());
            foreach (var course in selectedCourses)
                sectionAmountAll.Add(course.getSections().Count());

            //Setup Form Content
            InitializeComponent();
        }

        public void BeginWorking(bool isOptimized)
        {
            Debug.WriteLine("Began Working!");
            this.isOptimization = isOptimized;
            numComplete = 0;
            ModifyProgressBarColor.SetState(ProgressBarSchedules, 2);
            BackgroundWorkerSchedules.RunWorkerAsync();
        }

        public void RestartCalculation(List<SingleCourse> selectedCourses, int numPossib, int creditAmount, bool isOptimization)
        {
            Debug.WriteLine("Reseted Calculation variables!");

            //Reseted variables
            acceptableSchedulesTemp = new List<SingleSchedule>(20000);
            overlapSchedulesTemp = new List<SingleSchedule>(20000);
            acceptableSchedules = new List<SingleSchedule>(200);
            overlapSchedules = new List<SingleSchedule>(200);
            resultSchedules = new List<SingleSchedule>(200);

            //Calculation variables
            this.creditAmount = creditAmount;
            this.selectedCourses = selectedCourses;
            this.courseAmount = selectedCourses.Count();
            this.scheduleAmount = numPossib;
            this.isOptimization = isOptimization;

            schedulePopulation = new List<SingleSchedule>(20000);
            this.sectionAmountAll = new List<int>(courseAmount);
            foreach (var course in selectedCourses)
                sectionAmountAll.Add(course.getSections().Count());
        }


        //[FUNCTION - BeginCalculation]
        //Handles the result schedule population creation proccess
        public void BeginCalculation()
        {
            CreateAllPossibilities();

            if (BackgroundWorkerSchedules.CancellationPending == true)
                return;

            DetemineShownSchedules();
            DisplayDebugResult();
        }

        //[FUNCTION - CreateAllPossibilities]
        //Makes all possible schedule combinations from avaliable sections
        private void CreateAllPossibilities()
        {
            if (courseAmount == 0)
                return;

            int[] currentSecConfig = new int[courseAmount];
            NestedScheduleConfig(0, sectionAmountAll[0], currentSecConfig);
            HandleScheduleOverload();
        }

        //[FUNCTION - NestedForLoop]
        //Allows for dynamic creation off all schedule possibilities
        private void NestedScheduleConfig(int secID, int secAmount, int[] secConfig)
        {

            int secIdNext = secID + 1;
            int[] currentSecConfig = new int[courseAmount];
            secConfig.CopyTo(currentSecConfig, 0);

            if (BackgroundWorkerSchedules.CancellationPending == true)
            {
                Debug.WriteLine("Work was HALTED!");
                return;
            }


            for (int i = 0; i < secAmount; i++)
            {
                currentSecConfig[secID] = i;
                if ((secID + 1) == courseAmount)
                {
                    schedulePopulation.Add(new SingleSchedule(courseAmount, creditAmount, random, templateWeek, GetUniqueSec(currentSecConfig)));
                    if(numComplete % 1000 == 0)
                    {
                        Debug.WriteLine("(" + (float)numComplete + " / " + (float)scheduleAmount + ") * " + 100f + " = " + ((float)numComplete / (float)scheduleAmount) * 100f);
                        percentComplete = ((float)numComplete / (float)scheduleAmount) * 100f;
                        BackgroundWorkerSchedules.ReportProgress((int)percentComplete <= 100 ? (int)percentComplete : 100);
                    }
                    if(numComplete % 20000 == 0)
                    {
                        Debug.WriteLine("Memory Save!");
                        HandleScheduleOverload();
                    }
                    numComplete += 1;
                }
                else
                {
                    NestedScheduleConfig((secIdNext), sectionAmountAll[secIdNext], currentSecConfig);
                }
            }
        }

        //[FUNCTION - GetUniqueSec]
        //Allows to send section data to schedule class
        public List<SingleSection> GetUniqueSec(int[] secConfig)
        {
            List<SingleSection> resultSchedule = new List<SingleSection>(secConfig.Length);

            int courseCounter = 0;
            foreach (var secIndex in secConfig)
            {
                resultSchedule.Add(selectedCourses[courseCounter].getSections()[secIndex]);
                courseCounter++;
            }
            return resultSchedule;
        }

        //[FUNCTION - HandleScheduleOverload]
        //Frees some memory by doing a preliminary sorting each 50k calculations | Also performed at end
        private void HandleScheduleOverload()
        {
            //Add fittest from last set
            if (overlapSchedules.Count() != 0)
                overlapSchedulesTemp.AddRange(overlapSchedules);

            if (acceptableSchedules.Count() != 0)
                acceptableSchedulesTemp.AddRange(acceptableSchedules);

            //Add possible combinations to correct list
            foreach (var schedule in schedulePopulation)
            {
                if (schedule.getAcceptableLayoutState())
                    acceptableSchedulesTemp.Add(schedule);
                else
                    overlapSchedulesTemp.Add(schedule);
            }

            //Sort both temp lists
            if (acceptableSchedulesTemp.Count() != 0)
                acceptableSchedulesTemp = acceptableSchedulesTemp.OrderByDescending(s => s.getFitness()).ToList();
            if (overlapSchedulesTemp.Count() != 0)
                overlapSchedulesTemp = overlapSchedulesTemp.OrderBy(s => s.getOverlapCount()).ToList();

            //Refresh fittest sets
            acceptableSchedules.Clear();
            overlapSchedules.Clear();
            int scheduleNum = 1;
            foreach(var schedule in acceptableSchedulesTemp)
            {
                acceptableSchedules.Add(schedule);
                if (scheduleNum == 200)
                    break;
                scheduleNum++;
            }
            scheduleNum = 0;
            foreach (var schedule in overlapSchedulesTemp)
            {
                overlapSchedules.Add(schedule);
                if (scheduleNum == 200)
                    break;
                scheduleNum++;
            }
            scheduleNum = 0;

            //Clear repeating lists
            schedulePopulation.Clear();
            acceptableSchedulesTemp.Clear();
            overlapSchedulesTemp.Clear();
        }

        //[FUNCTION - DetemineShownSchedules]
        //Add all schedules to resulting schedules list
        public void DetemineShownSchedules()
        {

            resultSchedules.Clear();
            Debug.WriteLine("Overlap Schedules: " + overlapSchedules.Count() + " Acceptable Schedules: " + acceptableSchedules.Count());
            resultSchedules.AddRange(acceptableSchedules);
            int additionsNeeded = overlapSchedules.Count() <= 200 - acceptableSchedules.Count() ?
                                  overlapSchedules.Count() : 200 - acceptableSchedules.Count();
            for (int i = 0; i < additionsNeeded; i++)
                resultSchedules.Add(overlapSchedules[i]);
        }

        //[FUNCTION - DisplayDebugResult]
        //Displays found combinations in console
        public void DisplayDebugResult()
        {
            if (resultSchedules.Count() == 0)
            {
                Debug.WriteLine("*****************************************************************");
                Debug.WriteLine("No possible schedules w/o overlap!");
                return;
            }

            Debug.WriteLine("*****************************************************************");
            Debug.WriteLine("Amount of Viewable Schedule Combinations: " + resultSchedules.Count());

            Debug.WriteLine("*****************************************************************");
            Debug.WriteLine("Best Schedule Fitness: " + resultSchedules[0].getFitness() + " | Overlaps: " + resultSchedules[0].getOverlapCount());
            foreach (var section in resultSchedules[0].getAllSections())
                Debug.WriteLine(section.getID() + ":" + section.getStartTimes()[0] + " -" + section.getStopTimes()[0] + " on " + SecMeetDays(section));

            Debug.WriteLine("*****************************************************************");
            int lastIndex = resultSchedules.Count() - 1;
            Debug.WriteLine("Worst Schedule Fitness: " + resultSchedules[lastIndex].getFitness() + " | Overlaps: " + resultSchedules[lastIndex].getOverlapCount());
            foreach (var section in resultSchedules[lastIndex].getAllSections())
                Debug.WriteLine(section.getID() + ":" + section.getStartTimes()[0] + " -" + section.getStopTimes()[0] + " on " + SecMeetDays(section));
        }

        //[FUNCTION - SecMeetDays]
        //Seperates a list into one string used for meet days debug
        private string SecMeetDays(SingleSection sec)
        {
            string meetDays = "-";
            for (int i = 0; i < sec.getMeetDays().Count(); i++)
                meetDays += sec.getMeetDays()[i] + "-";
            return meetDays;
        }

        //BACKGROUND WORKER FUNCTIONS (self-explanatory names)
        //PARTIAL INSTRUCTION FROM LINK (background worker)
        //https://www.youtube.com/watch?v=G3zRhhGCJJA
        private void BackgroundWorkerSchedules_DoWork(object sender, DoWorkEventArgs e)
        {
            BeginCalculation();
        }

        private void BackgroundWorkerSchedules_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.Refresh();
            Debug.WriteLine("Refresh Occurred with " + e.ProgressPercentage + "%");
            ProgressBarSchedules.Value = e.ProgressPercentage;
            PercentCompleteLabel.Text = string.Format("Progress: {0}%", e.ProgressPercentage);
            int iCurAmount = (int)(scheduleAmount * (e.ProgressPercentage / 100f));
            CurrentAmountLabel.Text = "Current: " + iCurAmount;
            TotalAmountLabel.Text = "Total: " + scheduleAmount;
        }

        private void BackgroundWorkerSchedules_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (BackgroundWorkerSchedules.IsBusy)
                return;

            if (!isCancelled)
            {
                this.Hide();
                Debug.WriteLine("THERE ARE " + resultSchedules.Count() + " COURSES TO SHOW!");
                if (resultSchedules.Count() != 0)
                {
                    if (RefToResultLoadForm == null)
                    {
                        Debug.WriteLine("NEW RESULT FORM SHOWN");
                        RefToResultLoadForm = new LoadingResultsForm(selectedCourses, resultSchedules, RefToCourseSelectForm);
                    }
                    else
                    {
                        Debug.WriteLine("OLD RESULT FORM SHOWN! IT IS " + (isOptimization == true ? "OPTIMIZED" : "NOT OPTIMIZED"));
                        RefToResultLoadForm.ShowNewScheduleSet(selectedCourses, resultSchedules, isOptimization);
                    }

                    this.Hide();
                    if (!RefToResultLoadForm.Visible)
                    {
                        Debug.WriteLine("Result Form is NOW VISIBLE!");
                        RefToResultLoadForm.ShowDialog();
                    }
                }
                RefToCourseSelectForm.setIsFirstCalculationState(false);
            }

            acceptableSchedulesTemp.Clear();
            overlapSchedulesTemp.Clear();
            acceptableSchedules.Clear();
            overlapSchedules.Clear();
            resultSchedules.Clear();
            isCancelled = false;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            isCancelled = true;
            Debug.WriteLine("CANCEL BUTTON WAS CLICKED!!!");
            BackgroundWorkerSchedules.CancelAsync();
            this.Hide();
            Debug.WriteLine("isFirstCalculation: " + RefToCourseSelectForm.getIsFirstCalculationState());
            if (RefToCourseSelectForm.getIsFirstCalculationState() == false)
            {
                RefToResultLoadForm.Show();
                RefToResultLoadForm.setIsOptimizedState(false);
                RefToResultLoadForm.ChangeOptimizationText();
            }
            else
            {
                RefToCourseSelectForm.Show();
            }

            acceptableSchedulesTemp.Clear();
            overlapSchedulesTemp.Clear();
            acceptableSchedules.Clear();
            overlapSchedules.Clear();
            resultSchedules.Clear();
        }

        //[FUNCTION - BasicCalculationForm_FormClosed]
        //Exits Application if closed form during loading
        private void BasicCalculationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
