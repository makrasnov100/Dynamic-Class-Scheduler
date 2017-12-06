using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassScheduler
{
    public partial class FinalSchedule : Form
    {
        private Panel panel;
        private PictureBox pictureBox;
        private Bitmap fullbmp;

        public FinalSchedule()
        {
            InitializeComponent();
        }

        public FinalSchedule(Panel panel, PictureBox pictureBox)
        {
            this.panel = panel;
            this.pictureBox = pictureBox;
        }

        public void setPictureBox(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
        }

        public void setBitmap(Bitmap fullbmp)
        {
            this.fullbmp = fullbmp;
        }

        public void setBmpToPictureBox()
        {
            schedulePictureBox.Image = fullbmp;
        }
    }
}
