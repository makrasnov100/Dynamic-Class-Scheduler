using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassScheduler
{
    class Calculation
    {
        private List<SingleCourse>selectedCourses;

        private List<SingleSchedule> schedulePopulation;
        private List<SingleSchedule> newSchedulePopulation;
        private int genNumber;
        private double fitnessSum;

        private double bestFitness;
        private SingleSection[] bestSchedule;

        private double mutationRate;
        private int populationSize;

        private Random random;

        Calculation(int populationSize, int courseAmount, Random random, List<SingleCourse> selectedCourses, double mutationRate = .01)
        {
            genNumber = 1;
            this.mutationRate = mutationRate;
            this.selectedCourses = new List<SingleCourse>(selectedCourses);
            this.populationSize = populationSize;
            schedulePopulation = new List<SingleSchedule>(populationSize);
            newSchedulePopulation = new List<SingleSchedule>(populationSize);

            for (int i = 0; i < populationSize; i++)
                schedulePopulation.Add(new SingleSchedule(courseAmount, random, GetRandomSection, GetRandomSection, firstGen: true));
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
                //implement elitism as needed (need to sort and tell how much first schedules to keep)
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
            curBestSchedule.getAllSections().CopyTo(bestSchedule, 0);
        }

        //[Function - ChooseFitSchedule]
        //Picks a good parent schedule based on its fitness
        private SingleSchedule ChooseFitSchedule()
        {
            //***************may need to revise**********************
            double randomNumber = random.NextDouble() * fitnessSum;

            for (int i = 0; i < schedulePopulation.Count(); i++)
            {
                if (randomNumber < schedulePopulation[i].getFitness())
                    return schedulePopulation[i];

                randomNumber -= schedulePopulation[i].getFitness();
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
            int rand = random.Next(0, selectedCourses[courseIndex].sections.Count() - 1);
            return selectedCourses[courseIndex].sections[rand];
        }
    }
}
