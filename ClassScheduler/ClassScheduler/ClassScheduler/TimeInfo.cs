using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassScheduler
{
    class TimeInfo
    {
        private string dayOfWeek;
        private int start;
        private int end;
        private int range;

        public TimeInfo (string day, int startTime, int endTime)
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
    }
}
