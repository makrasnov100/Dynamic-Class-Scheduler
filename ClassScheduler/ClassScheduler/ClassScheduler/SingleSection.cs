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

            //Functions extracting hours, minutes, and AM/PM
            int numHour = getStartTimeHour(stringArr);
            int numMin = getStartTimeMinute(startTime);
            string amPm = getAmPm(stringArr);

            //Test whether the time is morning or afternoon
            if (amPm == "AM")
            {
                return (numHour * 60) + numMin;
            }
            else if (amPm == "PM")
            {
                if (numHour == 12)
                {
                    return (12 * 60) + numMin;
                }
                else
                {
                    return ((numHour + 12) * 60) + numMin;
                }
            }
            else
            {
                return -1;
            }
        }

        public int getStartTimeHour(char[] stringArr)
        {
            int hours = -1;
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
            //Parse the string into an integer
            Int32.TryParse(stringHour, out hours);

            return hours;
        }

        public int getStartTimeMinute(string startTime)
        {
            int minutes = -1;
            string timeString = startTime.Trim();

            char delimiter = ' ';
            string[] substrings = timeString.Split(delimiter);

            delimiter = ':';
            string[] hourMin = substrings[0].Split(delimiter);

            Int32.TryParse(hourMin[1], out minutes);

            return minutes; 
        }

        public string getAmPm(char[] stringArr)
        {
            //Extract whether the time is AM or PM 
            string stringAmPm = "NA";
            for (int i = 0; i < stringArr.Count(); i++)
            {
                if (stringArr[i] == 'P' || stringArr[i] == 'p')
                {
                    stringAmPm = "PM";
                    break;
                }
                else
                {
                    stringAmPm = "AM";
                }
            }

            return stringAmPm;
        }
    }
}
