using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private List<string> meetDays;
        private List<string> instructFirstN;
        private List<string> instructLastN;
        private int seatingCap = 0;

        private List<string> startTimes;
        private List<string> stopTimes;
        private List<SingleTimeSlot> formattedTimes = new List<SingleTimeSlot>();

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

        public void addTimeInfo()
        {
            formattedTimes.Add(new SingleTimeSlot());
        }

        public void addTimeInfo(string day, int start, int end)
        {
            formattedTimes.Add(new SingleTimeSlot(day, start, end));
        }

        public List<SingleTimeSlot> getFormatedTime()
        {
            return formattedTimes;
        }

        //public int getFormatedTimeStart(int index)
        //{
        //    return formattedTimes[index].getStart();
        //}

        //public int getFormatedTimeStop(int index)
        //{
        //    return formattedTimes[index].getEnd();
        //}

        //public int getFormatedTimeRange(int index)
        //{
        //    return formattedTimes[index].getRange();
        //}

        //public string getFormatedTimeDayOfWeek(int index)
        //{
        //    return formattedTimes[index].getDayOfWeek();
        //}

        //[FUNCTION - FormatTimeToMinutes]
        //Converts start/stop times to integers - the number of minutes since midnight
        public void FormatTimeToMinutes()
        {
            //[Don't create time info if no section times provided]
            if (startTimes[0] == "NA " || stopTimes[0] == " NA" || startTimes[0] == "" || stopTimes[0] == "")
                return;

            string unformTime; //unformated time (e.g. 9:00 PM)
            int start = 0;
            int stop = 0;
            for (int b = 0; b < 2; b++)
            {
                //[Define needed variables at start of loop]
                string stringMin = "";
                string stringHour = "";
                int pmOffset = 0;

                //[Grab first meet time start/stop of day]
                if (b == 0)
                    unformTime = startTimes[0];
                else
                    unformTime = stopTimes[0];

                //[Remove leading and trailing whitespace]
                unformTime.Trim();

                //[Extract hours] (weird bug with not recognizing colons)
                stringHour = unformTime.Substring(0, unformTime.IndexOf(':'));

                //[Extract minutes]
                string tempI = unformTime.Trim();
                string tempF = Regex.Replace(tempI, "[^0-9]", "");

                int tempLen = tempF.Count();
                if (tempLen == 3)
                    stringMin = tempF.Substring(1, 2);
                else if (tempLen == 4)
                    stringMin = tempF.Substring(2, 2);

                //[Parse collected times]
                int hours = 0;
                Int32.TryParse(stringHour, out hours);
                int minutes = 0;
                Int32.TryParse(stringMin, out minutes);

                //[Add offset minutes if string contains "PM"]
                if (unformTime.Contains("PM") && hours != 12)
                    pmOffset = 720;
                else if (unformTime.Contains("AM") && hours == 12)
                    pmOffset = -720;

                //[Write totals]
                if (b == 0)
                    start = (hours * 60) + minutes + pmOffset;
                else
                    stop = (hours * 60) + minutes + pmOffset;
            }

            //[Add a TimeInfo Class for each unique day]
            List<String> normalWeek = new List<string> { "M", "T", "W", "TH", "F" };
            foreach (var day in normalWeek)
            {
                if (meetDays.Exists(s => s == day))
                    addTimeInfo(day, start, stop);
                else
                    addTimeInfo();
            }

            //(ADD MULTIPLE TIME SLOTS PER DAY FUNCTIONALITY HERE)
        }
    }
}
