using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        //Return start time as an integer - the number of minutes since midnight
        public int getStartTimeMinutes()
        {
            string startTime = startTimes[0]; //Most sections only have one start time
            startTime.Trim(); //Removes leading and trailing whitespace 

            //Convert start time string to char array for easier manipulation
            char[] stringArr = startTime.ToCharArray();

            string stringHour = "";
            //Extract the hour from the startTimes[0] string
            for (int i = 0; i < stringArr.Count(); i++)
            {
                if (stringArr[i] != ':')
                {
                    stringHour += stringArr[i];
                }
                else
                {
                    break; //Exit the loop once it tests the colon
                }
            }

            //Extract the minutes from the startTimes[0] string
            string stringMin = "";

            string temp = startTime.Trim();
            var charsToRemove = new string[] { " ", ":", "A", "a", "P", "p", "M", "m"};
            for (int i = 0; i < temp.Count(); i++)
            {
                foreach (var c in charsToRemove)
                {
                    temp = temp.Replace(c, string.Empty);
                }
            }

            int tempLen = temp.Count();

            if(tempLen == 3)
            {
                stringMin = temp[1].ToString() + temp[2].ToString();
            }
            else if (tempLen == 4)
            {
                stringMin = temp[2].ToString() + temp[3].ToString();
            }

            //Extract whether the time is AM or PM 
            string stringAmPm = "NA";
            for (int i = 0; i < stringArr.Count(); i++)
            {
                if (stringArr[i] == 'P' || stringArr[i] == 'p') {
                    stringAmPm = "PM";
                    break;
                }
                else
                {
                    stringAmPm = "AM";
                }
            }

            //Calculate the number of minutes since midnight, given the number of hours, 
            //the number of minutes, and whether it is in the morning or afternoon
            int hours = 0;
            Int32.TryParse(stringHour, out hours);
            int minutes = 0;
            Int32.TryParse(stringMin, out minutes);

            //Test whether the time is morning or afternoon
            if (stringAmPm == "AM")
            {
                return (hours * 60) + minutes;
            }
            else if (stringAmPm == "PM")
            {
                if (hours == 12)
                {
                    return (12 * 60) + minutes;
                }
                else
                {
                    return ((hours + 12) * 60) + minutes;
                }
            }
            else
            {
                return -1;
            }
        }
    }
}
