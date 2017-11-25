using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassScheduler
{
    public partial class LoadingResultsForm : Form
    {
        private Graphics g;
        private Bitmap bmp;
        private float verticalScale = 2;
        private float rectWidth = 50;
        private float rectPadding = 3;
        private float dayXPadding = 150;
        private Font dayLabelFont = new Font("Times New Roman", 12f, FontStyle.Italic);
        SolidBrush drawBrush = new SolidBrush(System.Drawing.Color.Black);
        private Pen blackPen = Pens.Black;
        private Brush blackBrush = Brushes.Black;
        private Brush greenBrush = Brushes.Green;
        private Brush redBrush = Brushes.Red;

        private List<SingleCourse> selectedCourses;
        private List<SingleSchedule> resultSchedules;

        private float curScheduleIndex = 0;
        private float lastXPos = 0;
        private float lastYPos = 30;

        public LoadingResultsForm(List<SingleCourse> selectedCourses,List<SingleSchedule> resultSchedules)
        {
            this.selectedCourses = selectedCourses;
            this.resultSchedules = resultSchedules;
            InitializeComponent();
        }

        private void LoadingResultsForm_Load(object sender, EventArgs e)
        {
            CreateGraph(0);
        }

        //[FUNCTION - CreateGraphics]
        //Displays the generated schedule with C# graphics given its index location
        private void CreateGraph(int scheduleIndex)
        {
            bmp = new Bitmap(SectionGraphBox.Width, SectionGraphBox.Height);
            g = Graphics.FromImage(bmp);

            foreach (var day in resultSchedules[scheduleIndex].getAllDays())
                GraphDay(day);

            SectionGraphBox.Image = bmp;
        }

        //[FUNCTION - GraphDay]
        //Displays a given Schedule day given a starting location
        private void GraphDay(ScheduleDay day)
        {
            GraphDayLabel(day.getDayID());
            int timeSlotCounter = 0;
            float gapTime = 0;
            float rankOffset = 0;
            foreach (var timeSlot in day.getDayTimes())
            {
                if (timeSlot.getOverlapState() == false)
                {
                    g.FillRectangle(greenBrush, lastXPos, lastYPos, rectWidth, timeSlot.getRange() / verticalScale);
                    g.DrawRectangle(blackPen, lastXPos, lastYPos, rectWidth, timeSlot.getRange() / verticalScale);

                    if((day.getDayTimes().Count() - 1) > timeSlotCounter)
                    {
                        gapTime = day.getDayTimes()[timeSlotCounter + 1].getStart() - timeSlot.getEnd();
                        gapTime /= verticalScale;
                    }

                    //Debug.WriteLine( "Evaluating: " + lastYPos + " + (" + timeSlot.getRange() + " / 3) + " + gapTime);
                    lastYPos = lastYPos + (timeSlot.getRange() / verticalScale) + gapTime;
                }
                else
                {
                    rankOffset = timeSlot.getOverlapRank() * 50;

                    g.FillRectangle(redBrush, lastXPos + rankOffset, lastYPos, rectWidth, timeSlot.getRange() / verticalScale);
                    g.DrawRectangle(blackPen, lastXPos + rankOffset, lastYPos , rectWidth, timeSlot.getRange() / verticalScale);

                    if ((((day.getDayTimes().Count() - 1) > timeSlotCounter) && (day.getDayTimes()[timeSlotCounter + 1].getOverlapState() == true)))
                    {
                        gapTime = day.getDayTimes()[timeSlotCounter + 1].getOverlapAmount();
                        gapTime /= verticalScale;
                        lastYPos = lastYPos + gapTime;
                    }
                    else if ((day.getDayTimes().Count() - 1) > timeSlotCounter)
                    {
                        gapTime = day.getDayTimes()[timeSlotCounter + 1].getStart() - timeSlot.getEnd();
                        gapTime /= verticalScale;
                        lastYPos = lastYPos + (timeSlot.getRange() / verticalScale) + gapTime;
                    }
                }
                timeSlotCounter++;
            }
            lastXPos += dayXPadding;
            lastYPos = 30;
            timeSlotCounter = 0;
        }

        //[FUNCTION - GraphDayLabel]
        //Prints out the label for current day
        public void GraphDayLabel(string dayID)
        {
            switch (dayID)
            {
                case "M":
                    g.DrawString("Monday:", dayLabelFont, drawBrush, lastXPos, 0);
                    break;
                case "T":
                    g.DrawString("Tuesday:", dayLabelFont, drawBrush, lastXPos, 0);
                    break;
                case "W":
                    g.DrawString("Wednesday:", dayLabelFont, drawBrush, lastXPos, 0);
                    break;
                case "TH":
                    g.DrawString("Thursday:", dayLabelFont, drawBrush, lastXPos, 0);
                    break;
                case "F":
                    g.DrawString("Friday:", dayLabelFont, drawBrush, lastXPos, 0);
                    break;
                default:
                    Debug.WriteLine("ERROR - Displaying Day Labels");
                    break;
            }
        }
    }
}
