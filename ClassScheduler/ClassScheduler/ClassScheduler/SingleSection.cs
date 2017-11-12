using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassScheduler
{

    /// <summary>
    /// This class defines a section object that has the properties 
    /// of a single class section including its start/end time, meet days and instructor name
    /// </summary>
    /// Author: Kostiantyn Makrasnov (variables)
    /// Author: Yuri Fedas (accessor/mutator functions & constructors)

    public class SingleSection
    {
        private string term = "";
        private string ID = "";
        private List<string> startTimes;
        private List<string> stopTimes;
        private List<string> meetDays;
        private List<string> instructFirstN;
        private List<string> instructLastN;
        private int seatingCap = 0;

        public SingleSection()
        {
            term = "";
            ID = "";
            seatingCap = 0;
        }

        public SingleSection(string term, string ID, int seatingCap)
        {
            this.term = term;
            this.ID = ID;
            this.seatingCap = seatingCap;
        }

        public string getTerm()
        {
            return term;
        }

        public void setTerm(string term)
        {
            this.term = term;
        }

        public string getID()
        {
            return ID;
        }

        public void setID(string ID)
        {
            this.ID = ID;
        }

        public List<string> getStartTimes()
        {
            return startTimes;
        }

        public void setStartTimes(List<string> startTimes)
        {
            this.startTimes = startTimes;
        }

        public List<string> getStopTimes()
        {
            return stopTimes;
        }

        public void setStopTimes(List<string> stopTimes)
        {
            this.stopTimes = stopTimes;
        }

        public List<string> getMeetDays()
        {
            return meetDays;
        }

        public void setMeetDays(List<string> meetDays)
        {
            this.meetDays = meetDays;
        }

        public List<string> getInstructFirstN()
        {
            return instructFirstN;
        }

        public void setInstructFirstN(List<string> instructFirstN)
        {
            this.instructFirstN = instructFirstN;
        }

        public List<string> getInstructLastN()
        {
            return instructLastN;
        }

        public void setInstructLastN(List<string> instructLastN)
        {
            this.instructLastN = instructLastN;
        }

        public int getSeatingCapacity()
        {
            return seatingCap;
        }

        public void setSeatingCapacity(int seatingCap)
        {
            this.seatingCap = seatingCap;
        }
    }
}
