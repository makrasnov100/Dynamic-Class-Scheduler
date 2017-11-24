using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassScheduler
{
    class SingleSchedule
    {
        private SingleSection[] allSections;
        private List<ScheduleDay> allDays = new List<ScheduleDay>();
        private int courseAmount;
        private int minutesAtSchool;
        private double fitness = 0;

        private double effeciencyWeight = .20;
        private double overlapWeight = .80;

        bool acceptableLayout = false;

        private List<string> templateWeek;
        private Random random;
        private Func<string, SingleSection> GetRandomSectionByID;
        private Func<int, SingleSection> GetRandomSectionByIndex;

        public SingleSchedule(int courseAmount, int creditAmount, Random random, List<string> templateWeek, Func<string, SingleSection> GetRandomSectionByID, Func<int, SingleSection> GetRandomSectionByIndex,  bool firstGen = true)
        {
            allSections = new SingleSection[courseAmount];
            this.random = random;
            this.courseAmount = courseAmount;
            minutesAtSchool = creditAmount*60;
            this.GetRandomSectionByID = GetRandomSectionByID;
            this.GetRandomSectionByIndex = GetRandomSectionByIndex;
            this.templateWeek = templateWeek;

            //generates random sections only for the first set of schedule populations
            if (firstGen)
                for (int i = 0; i < allSections.Length; i++)
                    allSections[i] = GetRandomSectionByIndex(i);

            string allSec = "* ";
            foreach (var section in allSections)
                allSec += section.getID() + " * ";
            Debug.WriteLine(allSec);


            //populate allDays list with time information
            for (int g = 0; g < templateWeek.Count(); g++)
                allDays.Add(new ScheduleDay(templateWeek[g]));

            int sectionIndexCounter = 0;
            foreach(var section in allSections)
            {
                for (int i = 0; i < templateWeek.Count(); i++)
                    if (section.getFormatedTime()[i].getDayOfWeek() != "NA")
                        allDays[i].addTimetoDay(new SingleAssignedTimeSlot(section.getFormatedTime()[i], sectionIndexCounter));

                sectionIndexCounter++;
            }

            if(firstGen)
                EvaluateFitness();
        }

        public SingleSchedule (SingleSchedule oldCopy)
        {
            this.allSections = oldCopy.getAllSections();
            this.allDays = oldCopy.getAllDays();
            this.fitness = getFitness();
        }

        //[FUNCTION - EvaluateFitness]
        //Calculates the fitness of a particular setup
        public void EvaluateFitness()
        {
            double finalCalcFitness = 0;
            double effecFitness = CalcEffeciency();
            double overlapFitness = CalcOverlap();
            finalCalcFitness += effecFitness * effeciencyWeight;
            finalCalcFitness += overlapFitness * overlapWeight;
            //Debug.WriteLine("Effeciency Fitness: " + effecFitness + " | Overlap Fitness: " + overlapFitness + " | TOTAL: " + finalCalcFitness);

            fitness = finalCalcFitness;
        }

        //[FUNCTION - EvaluateFitness]
        //Returns the efficiency of course (factors: range of smallest time to largest)
        public double CalcEffeciency()
        {
            double effecFitness = 0;

            int lowestTime = 2400;
            int highestTime = 0;
            int totalTime = 0;
            int dayCount = 0;

            //find time range of sections
            for (int i = 0; i < 5; i++)
            {
                lowestTime = 2400;
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
                if(lowestTime != 2400 && highestTime != 0)
                    totalTime += highestTime - lowestTime;
            }

            //get effieciency fitness (200 min added for lunchtime on all days)
            effecFitness = 1.00000 - (((double) totalTime - ((double)minutesAtSchool + 200.0)) / ((double)minutesAtSchool + 200.0)); // **********adjust as needed************
            //Debug.WriteLine("This > [1 - ((" + totalTime + " - " + (minutesAtSchool + 200) + ") / " + (minutesAtSchool + 200) + ") = " + effecFitness);

            return effecFitness <= 0 ? 0 : effecFitness;
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
            SingleSchedule crossoverSchedule = new SingleSchedule(allSections.Length, (minutesAtSchool / 60), random, templateWeek, GetRandomSectionByID, GetRandomSectionByIndex, false);

            for (int i = 0; i < allSections.Length; i++)
                crossoverSchedule.allSections[i] = random.NextDouble() > 0.5 ? allSections[i] : anotherSchedule.allSections[i];

            crossoverSchedule.EvaluateFitness();

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
        public List<ScheduleDay> getAllDays()
        {
            return allDays;
        }
    }
}
