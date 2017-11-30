using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassScheduler
{
    [Serializable]
    public class SingleAssignedTimeSlot : SingleTimeSlot
    {

        private int sectionID;
        private bool isOverlapping = false;
        private bool isOverlapOverride = false;
        private bool isOptimized = false;
        private int gapAmount = 0;
        private int overlapRank = 0;

        public SingleAssignedTimeSlot(SingleTimeSlot oldTime, bool isOptimized, int sectionIndex)
        {
            this.setStart(oldTime.getStart());
            this.setEnd(oldTime.getEnd());
            this.setRange(oldTime.getRange());
            this.isOptimized = isOptimized;
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

        public bool getOptimizedState()
        {
            return isOptimized;
        }
        public void setOptimizedState(bool isOptimized)
        {
            this.isOptimized = isOptimized;
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
