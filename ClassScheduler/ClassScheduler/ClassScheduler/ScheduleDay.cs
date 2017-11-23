using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassScheduler
{
    class ScheduleDay
    {
        private string dayID; //M-T-W-TH-F
        private List<TimeInfo> dayTimes = new List<TimeInfo>();

        public string getDayID()
        {
            return dayID;
        }

        public List<TimeInfo> getDayTimes()
        {
            return dayTimes;
        }

        public void addTimetoDay(TimeInfo timeSlot)
        {
            dayTimes.Add(timeSlot);
        }
    }
}
