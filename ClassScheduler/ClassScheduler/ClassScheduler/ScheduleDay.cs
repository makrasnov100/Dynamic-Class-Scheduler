using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassScheduler
{
    public class ScheduleDay
    {
        private string dayID; //M-T-W-TH-F
        private List<SingleAssignedTimeSlot> dayTimes = new List<SingleAssignedTimeSlot>();

        public ScheduleDay()
        {
            dayID = "NA";
            dayTimes = null;
        }

        public ScheduleDay(string dayID)
        {
            this.dayID = dayID;
        }

        public void SortTimes()
        {
            dayTimes = dayTimes.OrderBy(s => s.getStart()).ToList();
        }

        //accessor/mutator functions
        public string getDayID()
        {
            return dayID;
        }

        public List<SingleAssignedTimeSlot> getDayTimes()
        {
            return dayTimes;
        }

        public void addTimetoDay(SingleAssignedTimeSlot timeSlot)
        {
            dayTimes.Add(timeSlot);
        }
    }
}
