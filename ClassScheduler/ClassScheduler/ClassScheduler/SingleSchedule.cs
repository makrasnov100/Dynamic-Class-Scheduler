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
        private double fitness = 0;

        private double effeciencyWeight = .20;
        private double overlapWeight = .80;

        bool acceptableLayout = false;

        private Random random;
        private Func<string, SingleSection> GetRandomSectionByID;
        private Func<int, SingleSection> GetRandomSectionByIndex;

        public SingleSchedule(int courseAmount, Random random, Func<string, SingleSection> GetRandomSectionByID, Func<int, SingleSection> GetRandomSectionByIndex,  bool firstGen = true)
        {
            allSections = new SingleSection[courseAmount];
            this.random = random;
            this.GetRandomSectionByID = GetRandomSectionByID;
            this.GetRandomSectionByIndex = GetRandomSectionByIndex;

            //generates random sections only upon first set of schedule populations
            if (firstGen)
                for (int i = 0; i < allSections.Length; i++)
                    allSections[i] = GetRandomSectionByIndex(i);
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

            // need to complete function

            return effecFitness;
        }

        //[FUNCTION - CalcOverlap]
        //Returns the overlap fitness of course (factors: amount of intersection)
        public double CalcOverlap()
        {
            double overlapFitness = 0;

            // need to complete function
            //if(...)
            //    acceptableLayout = true

            return overlapFitness;
        }

        //[FUNCTION - CrossoverSchedule]
        //Returns a crossed over schedule
        public SingleSchedule CrossoverSchedule(SingleSchedule anotherSchedule)
        {
            SingleSchedule crossoverSchedule = new SingleSchedule(allSections.Length, random, GetRandomSectionByID, GetRandomSectionByIndex, false);

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
