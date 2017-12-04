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

        private List<SingleCourse> selectedCourses;
        private int courseAmount;
        private int scheduleAmount;
        private int creditAmount;
        private float percentComplete;
        private bool isOptimization;
        private List<int> sectionAmountAll; // parallel list that allows for creation of all unique schedules

        private List<SingleSchedule> schedulePopulation;
        private List<SingleSchedule> acceptableSchedules = new List<SingleSchedule>();
        private List<SingleSchedule> overlapSchedules = new List<SingleSchedule>();
        private List<SingleSchedule> resultSchedules = new List<SingleSchedule>();

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

            schedulePopulation = new List<SingleSchedule>(numPossib);
            this.sectionAmountAll = new List<int>(selectedCourses.Count());
            foreach (var course in selectedCourses)
                sectionAmountAll.Add(course.getSections().Count());

            //Setup Form Content
            InitializeComponent();
        }

        public void BeginWorking(bool isOptimized)
        {
            numComplete = 0;
            ModifyProgressBarColor.SetState(ProgressBarSchedules, 2);
            BackgroundWorkerSchedules.RunWorkerAsync();
            BackgroundWorkerSchedules.ReportProgress(0);
        }

        public void RestartCalculation(List<SingleCourse> selectedCourses, int numPossib, int creditAmount, bool isOptimization)
        {
            //Resetred variables
            acceptableSchedules = new List<SingleSchedule>();
            overlapSchedules = new List<SingleSchedule>();
            resultSchedules = new List<SingleSchedule>();

            //Calculation variables
            this.creditAmount = creditAmount;
            this.selectedCourses = selectedCourses;
            this.courseAmount = selectedCourses.Count();
            this.scheduleAmount = numPossib;
            this.isOptimization = isOptimization;

            schedulePopulation = new List<SingleSchedule>(scheduleAmount);
            this.sectionAmountAll = new List<int>(courseAmount);
            foreach (var course in selectedCourses)
                sectionAmountAll.Add(course.getSections().Count());
        }


        //[FUNCTION - BeginCalculation]
        //Handles the result schedule population creation proccess
        public void BeginCalculation()
        {
            CreateAllPossibilities();
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
            NestedForLoop(0, sectionAmountAll[0], currentSecConfig);
        }

        //[FUNCTION - NestedForLoop]
        //Allows for dynamic creation off all schedule possibilities
        private void NestedForLoop(int secID, int secAmount, int[] secConfig)
        {
            int secIdNext = secID + 1;
            int[] currentSecConfig = new int[courseAmount];
            secConfig.CopyTo(currentSecConfig, 0);

            for (int i = 0; i < secAmount; i++)
            {
                currentSecConfig[secID] = i;
                if ((secID + 1) == courseAmount)
                {
                    schedulePopulation.Add(new SingleSchedule(courseAmount, creditAmount, random, templateWeek, GetUniqueSec(currentSecConfig)));
                    numComplete += 1;
                    if(numComplete % 1000 == 0)
                    {
                        Debug.WriteLine("(" + (float)numComplete + " / " + (float)scheduleAmount + ") * " + 100f + " = " + ((float)numComplete / (float)scheduleAmount) * 100f);
                        percentComplete = ((float)numComplete / (float)scheduleAmount) * 100f;
                        BackgroundWorkerSchedules.ReportProgress((int)percentComplete <= 100 ? (int)percentComplete : 100);
                    }
                }
                else
                {
                    NestedForLoop((secIdNext), sectionAmountAll[secIdNext], currentSecConfig);
                }
            }
        }

        //[FUNCTION - GetUniqueSec]
        //Allows to send section data to schedule class
        public List<SingleSection> GetUniqueSec(int[] secConfig)
        {
            List<SingleSection> resultSchedule = new List<SingleSection>(secConfig.Length);

            int courseCounter = 0;
            foreach (var secID in secConfig)
            {
                resultSchedule.Add(selectedCourses[courseCounter].getSections()[secID]);
                courseCounter++;
            }

            return resultSchedule;
        }

        //[FUNCTION - DetemineShownSchedules]
        //Sorts all schedules by fitness and adds possible ones to resultSchedules
        public void DetemineShownSchedules()
        {
            //Add possible combinations to correct list
            foreach (var schedule in schedulePopulation)
            {
                if (schedule.getAcceptableLayoutState())
                    acceptableSchedules.Add(schedule);
                else
                    overlapSchedules.Add(schedule);
            }

            //Sort both lists
            if (acceptableSchedules.Count() != 0)
                acceptableSchedules = acceptableSchedules.OrderByDescending(s => s.getFitness()).ToList();
            if (overlapSchedules.Count() != 0)
                overlapSchedules = overlapSchedules.OrderBy(s => s.getOverlapCount()).ToList();

            //Add all schedules to resulting schedules list
            resultSchedules = new List<SingleSchedule>(acceptableSchedules);
            Debug.WriteLine("Overlap Schedules: " + overlapSchedules.Count() + " Acceptable Schedules: " + acceptableSchedules.Count());
            int additionsNeeded = overlapSchedules.Count() <= 1000 - acceptableSchedules.Count() ?
                                  overlapSchedules.Count() : 1000 - acceptableSchedules.Count();
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

        //[FUNCTION - DisplayResultLoadForm]
        //Creates the load result form popup + passes needed info
        //public void DisplayResultLoadForm()
        //{
        //    if (resultSchedules.Count() != 0)
        //    {
        //        if (RefTOResultLoadForm == null)
        //        {
        //            Debug.WriteLine("NEW RESULT FORM SHOWN");
        //            RefTOResultLoadForm = new LoadingResultsForm(selectedCourses, resultSchedules, RefToCourseSelectForm);
        //        }
        //        else
        //        {
        //            Debug.WriteLine("OLD RESULT FORM SHOWN!");
        //            RefTOResultLoadForm.ShowNewScheduleSet(selectedCourses, resultSchedules, isOptimization);
        //        }

        //        this.Hide();
        //        if (!RefTOResultLoadForm.Visible)
        //        {
        //            Debug.WriteLine("Result Form is Shown!");
        //            RefTOResultLoadForm.ShowDialog();
        //        }
        //    }
        //}


        //BACKGROUND WORKER FUNCTIONS
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
                    Debug.WriteLine("OLD RESULT FORM SHOWN!");
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

        private void BasicCalculationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            BackgroundWorkerSchedules.CancelAsync();
            this.Hide();
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
        }
    }
}
