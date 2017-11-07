using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassScheduler
{
    public class SingleSection
    {
        public string term = "";
        public string ID = "";
        public List<string> startTimes;
        public List<string> stopTimes;
        public List<string> meetDays;
        public List<string> instructFirstN;
        public List<string> instructLastN;
        public int seatingCap = 0;
    }
}
