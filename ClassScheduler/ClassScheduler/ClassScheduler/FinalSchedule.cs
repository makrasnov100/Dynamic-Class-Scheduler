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

        private int index;

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

        public void appendStudentScheduleLabelText(string text)
        {
            displayLbl.Text += text;
        }

        public void changeDisplayLabelText(string text)
        {
            displayLbl.Text = text;
        }

        private void savePanelToImage()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + @"\test.jpeg";

            try
            {
                var pnl = this.schedulePanel;
                using (var bmp = new Bitmap(pnl.Width, pnl.Height))
                {
                    pnl.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                    bmp.Save(path);
                    MessageBox.Show("File save to " + path + " successful!");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            savePanelToImage();
        }

        public void changeDisplayLabelAnchor()
        {
            displayLbl.Anchor = (AnchorStyles.Left | AnchorStyles.Right);
        }

        public void displayLblParent()
        {
            displayLbl.Parent = schedulePanel;
            changeDisplayLabelAnchor();
        }

        public int getSchedulePanelWidth()
        {
            return schedulePanel.Width;
        }

        public TableLayoutPanel getDayLayoutPanel()
        {
            return dayLayoutPanel;
        }

        public TableLayoutPanel getMondayLayoutPanel()
        {
            return mondayLayoutPanel;
        }

        public TableLayoutPanel getSpecificPanel(int day)
        {
            switch (day)
            {
                case 0:
                    return mondayLayoutPanel;
                case 1:
                    return tuesdayLayoutPanel;
                case 2:
                    return wednesdayLayoutPanel;
                case 3:
                    return thursdayLayoutPanel;
                case 4:
                    return fridayLayoutPanel;
            }
            return null;
        }
    }
}
