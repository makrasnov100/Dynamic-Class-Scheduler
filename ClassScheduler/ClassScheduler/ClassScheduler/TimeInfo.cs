using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassScheduler
{
    class TimeInfo
    {
        private int start;
        private int end;
        private int range;

        TimeInfo (int startTime, int endTime)
        {
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
    }
}
