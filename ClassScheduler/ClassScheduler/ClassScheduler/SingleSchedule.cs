using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassScheduler
{
    class SingleSchedule
    {
        private SingleSection[] allSections;
        private List<ScheduleDay> allDays;
        private int courseAmount;
        private int hoursAtSchool;
        private double fitness = 0;

        private double effeciencyWeight = .20;
        private double overlapWeight = .80;

        bool acceptableLayout = false;

        private Random random;
        private Func<string, SingleSection> GetRandomSectionByID;
        private Func<int, SingleSection> GetRandomSectionByIndex;

        public SingleSchedule(int courseAmount, int creditAmount, Random random, Func<string, SingleSection> GetRandomSectionByID, Func<int, SingleSection> GetRandomSectionByIndex,  bool firstGen = true)
        {
            allSections = new SingleSection[courseAmount];
            this.random = random;
            this.courseAmount = courseAmount;
            hoursAtSchool = creditAmount*60;
            this.GetRandomSectionByID = GetRandomSectionByID;
            this.GetRandomSectionByIndex = GetRandomSectionByIndex;

            //generates random sections only upon first set of schedule populations
            if (firstGen)
                for (int i = 0; i < allSections.Length; i++)
                    allSections[i] = GetRandomSectionByIndex(i);

            // NEED TO POPULATE allDays List!***********************************************************************
        }

        //[FUNCTION - EvaluateFitness]
        //Calculates the fitness of a particular setup
        public void EvaluateFitness()
        {
            double finalCalcFitness = 0;
            finalCalcFitness += CalcEffeciency() * effeciencyWeight;
            finalCalcFitness += CalcOverlap() * overlapWeight;
            fitness = finalCalcFitness;
        }

        //[FUNCTION - EvaluateFitness]
        //Returns the efficiency of course (factors: range of smallest time to largest)
        public double CalcEffeciency()
        {
            double effecFitness = 0;

            int lowestTime = 2400;
            int highestTime = 2400;
            int totalTime = 0;
            int dayCount = 0;

            //*****************************************************************************************
            // Make sure DAYS ARE in M-T-W-TH-F list sequence & non meet days marked with "NA" ********
            //*****************************************************************************************

            //find time range of sections
            for (int i = 0; i < 5; i++)
            {
                lowestTime = 2400;
                highestTime = 0;
                //foreach (SingleSection section in allSections)
                //{
                //    if (section.getTimeInfo()[i].getMeetDay != "NA")
                //    {
                //        if (section.getTimeInfo()[i].getStart() < lowestTime)
                //            lowestTime = section.getTimeInfo()[i].getStart();
                //        if (section.getTimeInfo()[i].getEnd() > highestTime)
                //            highestTime = section.getTimeInfo()[i].getEnd();
                //    }
                //}
                totalTime += highestTime - lowestTime;
            }

            //get effieciency fitness
            effecFitness = 1 - ((totalTime - hoursAtSchool)/hoursAtSchool); // **********adjust as needed************

            return effecFitness;
        }

        //[FUNCTION - CalcOverlap]
        //Returns the overlap fitness of course (factors: amount of intersection)
        public double CalcOverlap()
        {
            double overlapFitness = 0;
            double score = 100;

            bool firstTimeSlot = true;
            int timeSlotsInDay;

            if (courseAmount == 1)
                return 1;

            foreach (ScheduleDay day in allDays)
            {
                timeSlotsInDay = day.getDayTimes().Count();
                if (timeSlotsInDay <= 1)
                    continue;

                firstTimeSlot = true;
                for (int i = 1; i < timeSlotsInDay; i++)
                {
                    if (!firstTimeSlot)
                        if (day.getDayTimes()[i].getStart() - day.getDayTimes()[i - 1].getStart() <= day.getDayTimes()[i - 1].getRange())
                            score -= 5;
                        else
                            firstTimeSlot = false;
                }
            }

            return score > 0 ? score/100 : 0; // *****************adjust to take into account course amount & overlap possibilities*************
        }


        //[FUNCTION - CrossoverSchedule]
        //Returns a crossed over schedule
        public SingleSchedule CrossoverSchedule(SingleSchedule anotherSchedule)
        {
            SingleSchedule crossoverSchedule = new SingleSchedule(allSections.Length, (hoursAtSchool/60) , random, GetRandomSectionByID, GetRandomSectionByIndex, false);

            for (int i = 0; i < allSections.Length; i++)
                crossoverSchedule.allSections[i] = random.NextDouble() > 0.5 ? allSections[i] : anotherSchedule.allSections[i];

            return crossoverSchedule;
        }

        //[FUNCTION - MutateNewSchedule]
        //Changes a random section to another section (amount based of mutation rate)
        public void MutateNewSchedule(double mutateRate)
        {
            for(int i = 0; i < allSections.Length; i++)
                if (random.NextDouble() < mutateRate)
                    allSections[i] = GetRandomSectionByIndex(i);
        }

        //Accessor/Mutator Functions
        public double getFitness()
        {
            return fitness;
        }
        public SingleSection[] getAllSections()
        {
            return allSections;
        }
    }
}
