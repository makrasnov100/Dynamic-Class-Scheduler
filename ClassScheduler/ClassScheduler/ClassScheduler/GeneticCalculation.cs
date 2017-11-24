using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassScheduler
{
    class GeneticCalculation
    {
        private LoadingResultsForm CalculationForm;
        private List<SingleCourse>selectedCourses;

        private List<SingleSchedule> schedulePopulation;
        private List<SingleSchedule> newSchedulePopulation;
        private int genNumber;
        private double fitnessSum;

        private double bestFitness;
        private SingleSchedule bestSchedule;

        private double mutationRate;
        private int populationSize;
        private List<string> templateWeek = new List<string> { "M", "T", "W", "TH", "F" };
        private Random random;

        public GeneticCalculation(int populationSize, int courseAmount, int creditAmount, Random random, List<SingleCourse> selectedCourses, LoadingResultsForm CalculationsForm, double mutationRate = .01)
        {
            genNumber = 1;
            this.mutationRate = mutationRate;
            this.selectedCourses = new List<SingleCourse>(selectedCourses);
            this.populationSize = populationSize;
            this.random = random;
            schedulePopulation = new List<SingleSchedule>(populationSize);
            newSchedulePopulation = new List<SingleSchedule>(populationSize);
            this.CalculationForm = CalculationsForm;

            for (int i = 0; i < populationSize; i++)
                schedulePopulation.Add(new SingleSchedule(courseAmount, creditAmount, random, templateWeek, GetRandomSection, GetRandomSection, firstGen: true));

            BeginCalculation();
        }

        //[FUNCTION - BeginCalculation]
        //Handles the amount of generations the algorithm needs to reach result
        public void BeginCalculation()
        {
            Debug.WriteLine("*******************************************");
            Debug.WriteLine("Generation " + genNumber + ": " + bestFitness);
            Debug.WriteLine("*******************************************");
            while (genNumber <= 5)
                CreateNewGeneration();
        }


        //[FUNCTION - CreateNewGenneration]
        //Creates a new set of schedules to test
        public void CreateNewGeneration()
        {
            if (schedulePopulation.Count() == 0)
                return;

            newSchedulePopulation.Clear();

            for (int i = 0; i < schedulePopulation.Count(); i++)
            {
                //implement elitism as needed (need to sort and tell how much first schedules to keep intact)
                SingleSchedule parentSchedule1 = ChooseFitSchedule();
                SingleSchedule parentSchedule2 = ChooseFitSchedule();

                SingleSchedule childSchedule = parentSchedule1.CrossoverSchedule(parentSchedule2);

                newSchedulePopulation.Add(childSchedule);
            }

            List<SingleSchedule> tmpList = schedulePopulation;
            schedulePopulation = newSchedulePopulation;
            newSchedulePopulation = tmpList;

            genNumber++;
            FindFitnessTotal();
        }

        //[Function - FindFitnessTotal]
        private void FindFitnessTotal()
        {
            SingleSchedule curBestSchedule = schedulePopulation[0];

            foreach (SingleSchedule schedule in schedulePopulation)
            {
                fitnessSum += schedule.getFitness();
                if(curBestSchedule.getFitness() <= schedule.getFitness())
                    curBestSchedule = schedule;
            }

            bestFitness = curBestSchedule.getFitness();
            bestSchedule = new SingleSchedule(curBestSchedule);
        }

        //[Function - ChooseFitSchedule]
        //Picks a good parent schedule based on its fitness
        private SingleSchedule ChooseFitSchedule()
        {
            //***************may need to revise**********************
            double randomFitness = (.35 * random.NextDouble()) * fitnessSum;

            for (int i = 0; i < populationSize; i++)
            {
                if (randomFitness < schedulePopulation[i].getFitness() * populationSize)
                    return schedulePopulation[i];

                randomFitness -= schedulePopulation[i].getFitness();
            }

            return null;
        }

        //[FUNCTION - getRandomSection] **********maybe unneeded**************
        //allows schedules to grab a random section based on the random course selected
        public SingleSection GetRandomSection(string courseID)
        {
            foreach (SingleCourse course in selectedCourses)
            {
                if (course.getAbrvCourseName() == courseID)
                {
                    int rand = random.Next(0, course.sections.Count() - 1);
                    return course.sections[rand];
                }
            }
            return new SingleSection("NA", "NA", 0);
        }
        //[OVERLOAD - takes in course index instead]
        public SingleSection GetRandomSection(int courseIndex)
        {
            int rand = random.Next(0, selectedCourses[courseIndex].sections.Count());
            return selectedCourses[courseIndex].sections[rand];
        }
    }
}
