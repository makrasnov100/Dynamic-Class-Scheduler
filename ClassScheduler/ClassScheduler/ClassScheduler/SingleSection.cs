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
<<<<<<< HEAD
    /// Author: Yuri Fedas (accessor/mutator functions & constructors)
    /// 
    [Serializable]
=======
    /// Author: Yuriy Fedas (accessor/mutator functions & constructors)

>>>>>>> master
    public class SingleSection
    {
        private string term = "";
        private string ID = "";
        private string courseName = "";
        private List<string> meetDays;
        private List<string> instructFirstN;
        private List<string> instructLastN;
        private int seatingCap = 0;

        private List<string> startTimes;
        private List<string> stopTimes;
        private List<SingleTimeSlot> formattedTimes = new List<SingleTimeSlot>();

        private bool isOptimized = false;

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

        public SingleSection(SingleSection oldschedule, bool isOptimized)
        {
            this.term = oldschedule.getTerm();
            this.ID = oldschedule.getID();
            this.courseName = oldschedule.getCourseName();
            this.meetDays = oldschedule.getMeetDays();
            this.instructFirstN = oldschedule.getInstructFirstN();
            this.instructLastN = oldschedule.getInstructLastN();
            this.seatingCap = oldschedule.getSeatingCapacity();

            this.startTimes = oldschedule.getStartTimes();
            this.stopTimes = oldschedule.getStopTimes();
            this.formattedTimes = oldschedule.getFormatedTime();

            this.isOptimized = isOptimized;
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

        public string getCourseName()
        {
            return courseName;
        }
        public void setCourseName(string courseName)
        {
            this.courseName = courseName;
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

<<<<<<< HEAD
        public List<SingleTimeSlot> getFormatedTime()
        {
            return formattedTimes;
        }

        public void setIsOptimizedState(bool isOptimized)
        {
            this.isOptimized = isOptimized;
        }

        public bool getIsOptimizedState()
        {
            return isOptimized;
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
=======
            //Functions extracting hours, minutes, and AM/PM
            int numHour = getTimeHour(stringArr);
            int numMin = getTimeMinute(startTime);
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

        public int getTimeHour(char[] stringArr)
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

        public int getTimeMinute(string startTime)
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
>>>>>>> master
                else
                    unformTime = stopTimes[0];

<<<<<<< HEAD
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
=======
            return stringAmPm;
        }

        public int getStopTimeMinutes()
        {
            string stopTime = stopTimes[0]; //Most sections only have one start time
            stopTime.Trim(); //Removes leading and trailing whitespace 

            //Convert start time string to char array for easier manipulation
            char[] stringArr = stopTime.ToCharArray();

            //Functions extracting hours, minutes, and AM/PM
            int numHour = getTimeHour(stringArr);
            int numMin = getTimeMinute(stopTime);
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
>>>>>>> master
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
