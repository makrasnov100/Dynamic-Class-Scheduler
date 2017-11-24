using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassScheduler
{
    public class SingleTimeSlot
    {
        private string dayOfWeek;
        private int start;
        private int end;
        private int range;

        public SingleTimeSlot()
        {
            dayOfWeek = "NA";
        }

        public SingleTimeSlot (string day, int startTime, int endTime)
        {
            dayOfWeek = day;
            start = startTime;
            end = endTime;
            range = end - start;
        }

        public int getStart()
        {
            return start;
        }

        public int getEnd()
        {
            return end;
        }

        public int getRange()
        {
            return range;
        }

        public string getDayOfWeek()
        {
            return dayOfWeek;
        }

        public void setDayOfWeek(string dayOfWeek)
        {
            this.dayOfWeek = dayOfWeek;
        }

        public void setStart(int start)
        {
            this.start = start;
        }

        public void setEnd(int end)
        {
            this.end = end;
        }

        public void setRange(int range)
        {
            this.range = range;
        }
    }
}
