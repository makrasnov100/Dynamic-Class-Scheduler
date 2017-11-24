using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassScheduler
{
    class BasicCalculation
    {
        private LoadingResultsForm CalculationForm;
        private List<SingleCourse> selectedCourses;
        // parallel list that allows for creation of all unique schedules
        private List<int> sectionAmount;

        private List<SingleSchedule> schedulePopulation;
        private double bestFitness;
        private SingleSchedule bestSchedule;

        public BasicCalculation(List<SingleCourse> selectedCourses)
        {
            this.selectedCourses = selectedCourses;
            //populate sectionAmount list;


            //BeginCalculation();
        }
    }
}
