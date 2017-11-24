using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassScheduler
{
    public class SingleAssignedTimeSlot : SingleTimeSlot
    {

        private int sectionID;

        public SingleAssignedTimeSlot(SingleTimeSlot oldTime, int sectionIndex)
        {
            this.setStart(oldTime.getStart());
            this.setEnd(oldTime.getEnd());
            sectionID = sectionIndex;
        }

        public void setSectionID(int ID)
        {
            this.sectionID = ID;
        }

        public int getSectionID()
        {
            return sectionID;
        }
    }
}
