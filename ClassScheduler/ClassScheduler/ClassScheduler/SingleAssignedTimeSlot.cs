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
        private bool isOverlapping = false;
        private bool isOverlapOverride = false;
        private int gapAmount = 0;
        private int overlapRank = 0;

        public SingleAssignedTimeSlot(SingleTimeSlot oldTime, int sectionIndex)
        {
            this.setStart(oldTime.getStart());
            this.setEnd(oldTime.getEnd());
            this.setRange(oldTime.getRange());
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

        public bool getOverlapState()
        {
            return isOverlapping;
        }
        public void setOverlapState(bool isOverlapping)
        {
            this.isOverlapping = isOverlapping;
        }

        public bool getOverlapOverrideState()
        {
            return isOverlapOverride;
        }
        public void setOverlapOverrideState(bool isOverlapOverride)
        {
            this.isOverlapOverride = isOverlapOverride;
        }

        public int getGapAmount()
        {
            return gapAmount;
        }
        public void setGapAmount(int gapAmount)
        {
            this.gapAmount = gapAmount;
        }

        public int getOverlapRank()
        {
            return overlapRank;
        }
        public void setOverlapRank(int overlapRank)
        {
            this.overlapRank = overlapRank;
        }
    }
}
