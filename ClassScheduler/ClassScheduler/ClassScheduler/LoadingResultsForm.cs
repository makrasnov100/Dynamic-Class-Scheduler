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
        private Bitmap fullBmp;
        private Rectangle timeSlotRect;
        private Rectangle dayLabelRect;
        private int picBoxExtend = 300;
        private float verticalScale = 1.0f; //larger = bigger slots
        private float rectWidth = 50;
        private int dayXPadding = 150;
        private Font dayLabelFont = new Font("Times New Roman", 12f, FontStyle.Italic);
        private Font timeLabelFont = new Font("Microsoft Sans Serif", 7.5f, FontStyle.Regular);
        private SolidBrush drawBrush = new SolidBrush(System.Drawing.Color.Black);
        private SolidBrush drawBrushWhite = new SolidBrush(System.Drawing.Color.White);
        private Pen blackPen = Pens.Black;
        private Pen dimGreyPen = Pens.DimGray;
        private Pen darkGreyPen = Pens.DarkGray;
        private Brush blackBrush = Brushes.Black;
        private Brush greenBrush = Brushes.Green;
        private Brush yellowBrush = Brushes.Yellow;
        private Brush redBrush = Brushes.Red;
        private Brush lightGreyBrush = Brushes.LightGray;
        private StringFormat sCenterFormat = new StringFormat();

        private List<SingleCourse> selectedCourses;
        private List<SingleSchedule> resultSchedules;

        private CourseSelectionForm RefToCourseSelectForm;
        private OptimizationSettingsForm OptimizeSettingsForm;

        private bool firstDraw = true;
        private int curScheduleIndex = 0;
        private float lastXPos = 0;
        private float topSeperator = 30;
        private float lastYPos;

        public LoadingResultsForm(List<SingleCourse> selectedCourses,List<SingleSchedule> resultSchedules, CourseSelectionForm courseForm)
        {
            //References to previous form
            RefToCourseSelectForm = courseForm;

            //Graphics
            sCenterFormat.LineAlignment = StringAlignment.Center;
            sCenterFormat.Alignment = StringAlignment.Center;
            lastYPos = topSeperator + 3; // provides gap for first timeslot

            this.selectedCourses = selectedCourses;
            this.resultSchedules = resultSchedules;
            InitializeComponent();
        }

        //[FUNCTION - ShowNewScheduleSet]
        //Resets form after optimization
        public void ShowNewScheduleSet(List<SingleCourse> selectedCourses, List<SingleSchedule> resultSchedules)
        {
            lastYPos = topSeperator + 3; // provides gap for first timeslot
            curScheduleIndex = 0;

            this.selectedCourses = selectedCourses;
            this.resultSchedules = resultSchedules;

            UpdateShownSchedule();
        }

        //[FUNCTION - UpdateShownSchedule]
        //Performs redraw of schedules
        private void UpdateShownSchedule()
        {
            UpdateScheduleLabels();
            UpdateButtonAppearence();
            CreateGraph();
        }

        private void LoadingResultsForm_Load(object sender, EventArgs e)
        {
            UpdateShownSchedule();
        }

        //[FUNCTION - CreateGraphics]
        //Displays the generated schedule with C# graphics given its index location
        private void CreateGraph()
        {
            lastXPos = 0;
            topSeperator = 30;
            lastYPos = topSeperator + 3;

            if (firstDraw)
            {
                Bitmap bmp = new Bitmap(SectionGraphBox.Width, SectionGraphBox.Height);
                int initYSize = SectionGraphBox.Height;
                fullBmp = new Bitmap(bmp, new Size(SectionGraphBox.Width, (initYSize + picBoxExtend)));
                g = Graphics.FromImage(fullBmp);
                firstDraw = false;
            }

            g.Clear(Color.White);
            dayXPadding = fullBmp.Width / resultSchedules[0].getAllDays().Count();
            rectWidth = (float) fullBmp.Width / (float) resultSchedules[0].getAllDays().Count() / 3.0f;

            //Draw overlap region
            for (int i = 0; i < resultSchedules[0].getAllDays().Count(); i++)
            {
                Rectangle overlapRegion = new Rectangle((i * dayXPadding) + (dayXPadding * 1/3) + 2, (int)topSeperator + 3,  dayXPadding * 2/3, fullBmp.Height);
                g.FillRectangle(lightGreyBrush, overlapRegion);
            }

            //Draw label and hour lines
            g.DrawLine(blackPen, 0, lastYPos, fullBmp.Width, lastYPos);
            for (int i = 1; i <= 16; i++)
                g.DrawLine(dimGreyPen, 0, topSeperator + (i * (60/verticalScale)), fullBmp.Width, topSeperator + (i * (60 / verticalScale)));
            for (int i = 1; i <= 16*4; i++)
            {
                if(i % 4 == 0)
                    continue;
                g.DrawLine(darkGreyPen, 0, topSeperator + (i * (15 / verticalScale)), fullBmp.Width, topSeperator + (i * (15 / verticalScale)));
            }
                

            foreach (var day in resultSchedules[curScheduleIndex].getAllDays())
                GraphDay(day);

            SectionGraphBox.Image = fullBmp;
        }

        //[FUNCTION - GraphDay]
        //Displays a given Schedule day given a starting location
        private void GraphDay(ScheduleDay day)
        {
            GraphDayLabel(day.getDayID());
            GraphDayTimeSlots(day);
            g.DrawLine(blackPen, lastXPos, 0, lastXPos, fullBmp.Height);
        }

        //[FUNCTION - GetTimeSlotString]
        //Returns the info to be displayed on rectangle given particular timeslot
        private string GetTimeSlotString(SingleAssignedTimeSlot timeSlot, int displayCount)
        {
            string result = "";
            result += resultSchedules[(int)curScheduleIndex].getAllSections()[timeSlot.getSectionID()].getID() + "\n";
            result += resultSchedules[(int)curScheduleIndex].getAllSections()[timeSlot.getSectionID()].getStartTimes()[0].Trim() + " -\n";
            result += resultSchedules[(int)curScheduleIndex].getAllSections()[timeSlot.getSectionID()].getStopTimes()[0].Trim() + "\n";
            //result += timeSlot.getStart() + " -\n";
            //result += timeSlot.getEnd() + "\n";

            return result;
        }

        //[FUNCTION - GraphDayLabel]
        //Graphs out the label for current day
        public void GraphDayLabel(string dayID)
        {
            dayLabelRect = new Rectangle((int)lastXPos, 0, (int)dayXPadding, (int)topSeperator);

            switch (dayID)
            {
                case "M":
                    g.DrawString("Monday:", dayLabelFont, drawBrush, dayLabelRect, sCenterFormat);
                    break;
                case "T":
                    g.DrawString("Tuesday:", dayLabelFont, drawBrush, dayLabelRect, sCenterFormat);
                    break;
                case "W":
                    g.DrawString("Wednesday:", dayLabelFont, drawBrush, dayLabelRect, sCenterFormat);
                    break;
                case "TH":
                    g.DrawString("Thursday:", dayLabelFont, drawBrush, dayLabelRect, sCenterFormat);
                    break;
                case "F":
                    g.DrawString("Friday:", dayLabelFont, drawBrush, dayLabelRect, sCenterFormat);
                    break;
                default:
                    Debug.WriteLine("ERROR - Displaying Day Labels");
                    break;
            }
        }

        //[FUNCTION - GraphDayTimeSlots]
        //Prints out the time slot boxes for current day
        public void GraphDayTimeSlots(ScheduleDay day)
        {
            int timeSlotCounter = 0;
            float gapTime = 0;
            float rankOffset = 0;
            foreach (var timeSlot in day.getDayTimes())
            {
                //Gap Calculation
                if (timeSlotCounter == 0)
                {
                    lastYPos = lastYPos + ((timeSlot.getStart() - 360) * 1/3);
                }
                else
                {
                    gapTime = timeSlot.getStart() - day.getDayTimes()[timeSlotCounter - 1].getStart();
                    gapTime *= verticalScale;
                    lastYPos = lastYPos + gapTime;
                }

                //Diplay Slots and Labels
                if (timeSlot.getOverlapState() == false)
                {
                    //Optimal section markup
                    Brush curBrush;
                    if (timeSlot.getOptimizedState() == true)
                        curBrush = yellowBrush;
                    else
                        curBrush = greenBrush;
                    g.FillRectangle(greenBrush, lastXPos, lastYPos, rectWidth, timeSlot.getRange() * verticalScale);
                    g.DrawRectangle(blackPen, lastXPos, lastYPos, rectWidth, timeSlot.getRange() * verticalScale);

                    timeSlotRect = new Rectangle((int)lastXPos, (int)lastYPos, (int)rectWidth, (int)(timeSlot.getRange() * verticalScale));
                    g.DrawString(GetTimeSlotString(timeSlot, timeSlotCounter), timeLabelFont, drawBrushWhite, timeSlotRect, sCenterFormat);
                }
                else
                {
                    rankOffset = timeSlot.getOverlapRank() * rectWidth;

                    g.FillRectangle(redBrush, lastXPos + rankOffset, lastYPos, rectWidth, timeSlot.getRange() * verticalScale);
                    g.DrawRectangle(blackPen, lastXPos + rankOffset, lastYPos, rectWidth, timeSlot.getRange() * verticalScale);

                    timeSlotRect = new Rectangle((int)(lastXPos + rankOffset), (int)lastYPos, (int)rectWidth, (int)(timeSlot.getRange() * verticalScale));
                    g.DrawString(GetTimeSlotString(timeSlot, timeSlotCounter), timeLabelFont, drawBrushWhite, timeSlotRect, sCenterFormat);
                }
                timeSlotCounter++;
            }
            lastXPos += dayXPadding;
            lastYPos = topSeperator + 3;
        }

        private void UpdateScheduleLabels()
        {
            ScheduleAmountLabel.Text = "Schedule " + (curScheduleIndex + 1) + " of " + resultSchedules.Count();

            //Updates Fitness Level Labels (revise to be more accurate)
            if (resultSchedules[curScheduleIndex].getAcceptableLayoutState() == false)
            {
                EffecFitLabel.ForeColor = Color.Red;
                EffecFitLabel.Text = "[N/A]";
                OverlapFitLabel.ForeColor = Color.Red;
                OverlapFitLabel.Text = "[FAIL]";
            }
            else if (curScheduleIndex != 0)
            {
                EffecFitLabel.ForeColor = Color.DarkOrange;
                EffecFitLabel.Text = "[GOOD]";
                OverlapFitLabel.ForeColor = Color.Green;
                OverlapFitLabel.Text = "[PASS]";
            }
            else
            {
                EffecFitLabel.ForeColor = Color.Green;
                EffecFitLabel.Text = "[BEST]";
                OverlapFitLabel.ForeColor = Color.Green;
                OverlapFitLabel.Text = "[PASS]";
            }
        }

        private void UpdateButtonAppearence()
        {
            if(resultSchedules[curScheduleIndex].getAcceptableLayoutState() == false)
            {
                SelectScheduleButton.BackColor = Color.DimGray;
                PrevScheduleButton.Enabled = false;
            }
            else
            {
                SelectScheduleButton.BackColor = Color.Black;
                PrevScheduleButton.Enabled = true;
            }

            //Change appearence based on current schedule index (revise for effeciency)
            if (resultSchedules.Count() == 1)
            {
                PrevScheduleButton.BackColor = Color.DimGray;
                PrevScheduleButton.Enabled = false;
                NextScheduleButton.BackColor = Color.DimGray;
                NextScheduleButton.Enabled = false;
            }
            else
            {
                if (curScheduleIndex == 0)
                {
                    PrevScheduleButton.BackColor = Color.DimGray;
                    PrevScheduleButton.Enabled = false;
                    NextScheduleButton.BackColor = Color.Black;
                    NextScheduleButton.Enabled = true;

                }
                else if (curScheduleIndex != resultSchedules.Count() - 1)
                {
                    PrevScheduleButton.BackColor = Color.Black;
                    PrevScheduleButton.Enabled = true;
                    NextScheduleButton.BackColor = Color.Black;
                    NextScheduleButton.Enabled = true;
                }
                else
                {
                    PrevScheduleButton.BackColor = Color.Black;
                    PrevScheduleButton.Enabled = true;
                    NextScheduleButton.BackColor = Color.DimGray;
                    NextScheduleButton.Enabled = false;
                }
            }
           
        }

        //[FUNCTION - CourseReselectionButton_Click]
        //Closes schedule select form and goes back course select form after buttton "Reselect Courses" click
        private void CourseReselectionButton_Click(object sender, EventArgs e)
        {
            RefToCourseSelectForm.Show();
            this.Hide(); //(revise because form cannot be closed - open forms from main program)!!!!!!!!!!!!!!!
        }

        //[FUNCTION - LoadingResultsForm_FormClosed]
        //Exits aplication when window is closed
        private void LoadingResultsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //[FUNCTION - PrevScheduleButton_Click]
        //Goes back one schedule
        private void PrevScheduleButton_Click(object sender, EventArgs e)
        {
            if (PrevScheduleButton.Enabled == true)
            {
                curScheduleIndex--;
                UpdateShownSchedule();
            }
        }

        //[FUNCTION - NextScheduleButton_Click]
        //Closes schedule select form and goes back course select form after buttton "Reselect Courses" click
        private void NextScheduleButton_Click(object sender, EventArgs e)
        {
            if (NextScheduleButton.Enabled == true)
            {
                curScheduleIndex++;
                UpdateShownSchedule();
            }
        }

        //[FUNCTION - NextScheduleButton_Click]
        //Opens up optimization settings after button "Optimize" is clicked
        private void SuggestedCoursesButton_Click(object sender, EventArgs e)
        {
            if (OptimizeSettingsForm == null)
                OptimizeSettingsForm = new OptimizationSettingsForm(resultSchedules[curScheduleIndex], RefToCourseSelectForm);

            OptimizeSettingsForm.ShowDialog();
        }
    }
}
