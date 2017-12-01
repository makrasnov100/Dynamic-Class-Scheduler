using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassScheduler
{
    class BasicCalculation
    {
        private List<SingleCourse> selectedCourses;
        private int courseAmount;
        private int creditAmount;
        private bool isOptimization;
        private List<int> sectionAmountAll; // parallel list that allows for creation of all unique schedules

        private List<SingleSchedule> schedulePopulation;
        private List<SingleSchedule> acceptableSchedules = new List<SingleSchedule>();
        private List<SingleSchedule> overlapSchedules = new List<SingleSchedule>();
        private List<SingleSchedule> resultSchedules = new List<SingleSchedule>();

        private CourseSelectionForm RefToCourseSelectForm;
        private LoadingResultsForm RefTOResultLoadForm;
        private Random random;
        private List<string> templateWeek = new List<string> { "M", "T", "W", "TH", "F" };

        public BasicCalculation(List<SingleCourse> selectedCourses, int numPossib, Random random, int creditAmount, 
                                CourseSelectionForm courseForm, LoadingResultsForm ScheduleSelectForm, bool isOptimization)
        {
            //References to previous form
            RefToCourseSelectForm = courseForm;
            RefTOResultLoadForm = ScheduleSelectForm;

            //Calculation variables
            this.random = random;
            this.creditAmount = creditAmount;
            this.selectedCourses = selectedCourses;
            this.courseAmount = selectedCourses.Count();
            this.isOptimization = isOptimization;

            schedulePopulation = new List<SingleSchedule>(numPossib);
            this.sectionAmountAll = new List<int>(selectedCourses.Count());
            foreach (var course in selectedCourses)
                sectionAmountAll.Add(course.getSections().Count());

            BeginCalculation();
        }

        //[FUNCTION - BeginCalculation]
        //Handles the result schedule population creation proccess
        private void BeginCalculation()
        {
            CreateAllPossibilities();
            DetemineShownSchedules();
            DisplayDebugResult();
            DisplayResultLoadForm();
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
                    schedulePopulation.Add(new SingleSchedule(courseAmount, creditAmount, random, templateWeek, GetUniqueSec(currentSecConfig)));
                else
                    NestedForLoop((secIdNext), sectionAmountAll[secIdNext], currentSecConfig);
            }
        }

        //[FUNCTION - GetUniqueSec]
        //Allows to send section data to schedule class
        public List<SingleSection> GetUniqueSec(int[] secConfig)
        {
            List<SingleSection> resultSchedule = new List<SingleSection>(secConfig.Length);

            int courseCounter = 0;
            foreach(var secID in secConfig)
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
            foreach(var schedule in schedulePopulation)
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
        //- Creates the load result form popup + passes needed info
        private void DisplayResultLoadForm()
        {
            if(resultSchedules.Count() != 0)
            {
                if (RefTOResultLoadForm == null)
                    RefTOResultLoadForm = new LoadingResultsForm(selectedCourses, resultSchedules, RefToCourseSelectForm);
                else
                    RefTOResultLoadForm.ShowNewScheduleSet(selectedCourses, resultSchedules, isOptimization);


                if(!RefTOResultLoadForm.Visible)
                    RefTOResultLoadForm.ShowDialog();
            }
        }
    }
}
