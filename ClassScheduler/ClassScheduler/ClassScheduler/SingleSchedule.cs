using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassScheduler
{
    [Serializable]
    public class SingleSchedule
    {
        private List<SingleSection> allSections;
        private List<ScheduleDay> allDays = new List<ScheduleDay>();
        private int courseAmount;
        private int minutesAtSchool;
        private double fitness = 0;
        private int overlapCount = 0;

        private bool acceptableLayout = true;

        private List<string> templateWeek;
        private Random random;

        public SingleSchedule(int courseAmount, int creditAmount, Random random, List<string> templateWeek, List<SingleSection> scheduleSections)
        {
            allSections = scheduleSections;

            this.random = random;
            this.courseAmount = courseAmount;
            minutesAtSchool = creditAmount*60;
            this.templateWeek = templateWeek;

            //string allSec = "* ";
            //foreach (var section in allSections)
            //    allSec += section.getID() + " * ";
            //Debug.Write(allSec);


            //populate allDays list with time information
            for (int g = 0; g < templateWeek.Count(); g++)
                allDays.Add(new ScheduleDay(templateWeek[g]));

            int sectionIndexCounter = 0;
            foreach(var section in allSections)
            {
                for (int i = 0; i < templateWeek.Count(); i++)
                    if (section.getFormatedTime()[i].getDayOfWeek() != "NA")
                        allDays[i].addTimetoDay(new SingleAssignedTimeSlot(section.getFormatedTime()[i], section.getIsOptimizedState() ,sectionIndexCounter));

                sectionIndexCounter++;
            }
            EvaluateFitness();
        }

        //[FUNCTION - EvaluateFitness]
        //Calculates the fitness of a particular setup
        public void EvaluateFitness()
        {
            fitness = CalcEffeciency();
            CalcOverlap();
        }

        //[FUNCTION - EvaluateFitness]
        //Returns the efficiency of course (factors: range of smallest time to largest)
        public double CalcEffeciency()
        {
            double effecFitness = 0;

            //Calculate of total minutes spent at school per week
            int lowestTime = 1440;
            int highestTime = 0;
            int totalTime = 0;
            for (int i = 0; i < 5; i++)
            {
                lowestTime = 1440;
                highestTime = 0;
                foreach (SingleSection section in allSections)
                {
                    if (section.getFormatedTime()[i].getDayOfWeek() != "NA")
                    {
                        if (section.getFormatedTime()[i].getStart() < lowestTime)
                            lowestTime = section.getFormatedTime()[i].getStart();
                        if (section.getFormatedTime()[i].getEnd() > highestTime)
                            highestTime = section.getFormatedTime()[i].getEnd();
                    }
                }
                if(lowestTime != 1440 && highestTime != 0)
                    totalTime += highestTime - lowestTime;
            }

            //Calculate max time possible to be in school per week (may need to revise)
            int maxTime = 1440 * templateWeek.Count();

            //Calculate min time possible to be in school given the set of sections
            int minTime = 0;
            foreach (var section in allSections)
                foreach(var timeSlot in section.getFormatedTime())
                    minTime += timeSlot.getRange();

            //Calculate max overtime possible per week
            int maxOverTime = maxTime - minTime;

            //Calcuate current overtime
            //Debug.Write("| Total: " + totalTime + " | Min: " + minTime + " | ");
            int currentOverTime = totalTime - minTime;

            //Calculate Efficiency Fitness (1 to 0)
            effecFitness = (((double)maxOverTime - (double)currentOverTime) / (double)maxOverTime);

            //Debug.WriteLine("Fitness: " + effecFitness);

            return effecFitness >= 1.00 ? 1.00 : effecFitness;
        }

        //[FUNCTION - CalcOverlap]
        //Returns the overlap fitness of course (factors: amount of intersection)
        public void CalcOverlap()
        {
            if (courseAmount == 1)
                return;

            int timeSlotsInDay;
            foreach (ScheduleDay day in allDays)
            {
                timeSlotsInDay = day.getDayTimes().Count();

                if (timeSlotsInDay <= 1)
                    continue;

                day.SortTimes();

                for (int i = 1; i < timeSlotsInDay; i++)
                {
                    if (day.getDayTimes()[i-1].getEnd() >= day.getDayTimes()[i].getStart())
                    {                 
                        day.getDayTimes()[i].setOverlapState(true);
                        day.getDayTimes()[i - 1].setOverlapState(true);

                        if (i >= 2 && day.getDayTimes()[i - 2].getOverlapState() == true && day.getDayTimes()[i - 2].getEnd() <= day.getDayTimes()[i].getStart())
                            day.getDayTimes()[i].setOverlapRank(day.getDayTimes()[i - 2].getOverlapRank());
                        else
                            day.getDayTimes()[i].setOverlapRank(day.getDayTimes()[i - 1].getOverlapRank() + 1);

                        overlapCount++;
                        acceptableLayout = false;
                    }
                    else if (i >= 2 && day.getDayTimes()[i-1].getOverlapState() == true && day.getDayTimes()[i - 2].getEnd() >= day.getDayTimes()[i].getStart())
                    {
                        day.getDayTimes()[i].setOverlapState(true);
                        day.getDayTimes()[i].setOverlapOverrideState(true);
                        day.getDayTimes()[i].setOverlapRank(day.getDayTimes()[i - 1].getOverlapRank()-1);
                        overlapCount++;
                    }
                }
            }
        }

        //Accessor/Mutator Functions
        public double getFitness()
        {
            return fitness;
        }
        public List<SingleSection> getAllSections()
        {
            return allSections;
        }
        public List<ScheduleDay> getAllDays()
        {
            return allDays;
        }
        public bool getAcceptableLayoutState()
        {
            return acceptableLayout;
        }
        public int getOverlapCount()
        {
            return overlapCount;
        }

        //GENETIC ALGORITHM FUNCTIONS
        //[FUNCTION - CrossoverSchedule]
        //Returns a crossed over schedule
        //public SingleSchedule CrossoverSchedule(SingleSchedule anotherSchedule)
        //{
        //    SingleSchedule crossoverSchedule = new SingleSchedule(allSections.Length, (minutesAtSchool / 60), random, templateWeek, GetRandomSectionByID, GetRandomSectionByIndex, false);

        //    for (int i = 0; i < allSections.Length; i++)
        //        crossoverSchedule.allSections[i] = random.NextDouble() > 0.5 ? allSections[i] : anotherSchedule.allSections[i];

        //    crossoverSchedule.EvaluateFitness();

        //    return crossoverSchedule;
        //}

        //[FUNCTION - MutateNewSchedule]
        //Changes a random section to another section (amount based of mutation rate)
        //public void MutateNewSchedule(double mutateRate)
        //{
        //    for(int i = 0; i < allSections.Length; i++)
        //        if (random.NextDouble() < mutateRate)
        //            allSections[i] = GetRandomSectionByIndex(i);
        //}
    }
}
