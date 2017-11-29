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
    public partial class OptimizationSettingsForm : Form
    {
        private List<CheckBox> allCB = new List<CheckBox>();
        private SingleSchedule oldSchedule;

        private CourseSelectionForm RefToCourseSelectForm;
        private LoadingResultsForm RefToLoadResultsForm;

        public OptimizationSettingsForm(SingleSchedule oldSchedule, CourseSelectionForm CourseSelectForm, LoadingResultsForm LoadResultsForm)
        {
            //Build references
            RefToCourseSelectForm = CourseSelectForm;
            RefToLoadResultsForm = LoadResultsForm;
            this.oldSchedule = oldSchedule;

            InitializeComponent();
            UpdateCheckBoxes(oldSchedule);
        }

        private void UpdateCheckBoxes(SingleSchedule oldSchedule)
        {
            //Remove last checkboxes
            foreach (var cb in allCB)
                this.Controls.Remove(cb);
            allCB.Clear();

            //Create new checkboxes 
            int locationCounter = 0;
            foreach(var section in oldSchedule.getAllSections())
            {
                allCB.Add(new CheckBox());
                allCB[allCB.Count()-1].Location = new Point(70, 120 + (locationCounter * 25));
                allCB[allCB.Count()-1].Text = section.getID().Substring(0, section.getID().IndexOf("-", 4)) + " | " + section.getCourseName();
                allCB[allCB.Count()-1].Size = new Size(500,20);
                this.Controls.Add(allCB[allCB.Count() - 1]);
                locationCounter++;
            }
        }

        private void GoBackToScheduleSelectionButton_Click(object sender, EventArgs e)
        {
            RefToLoadResultsForm.setIsOptimizedState(!RefToLoadResultsForm.getIsOptimizedState());
            RefToLoadResultsForm.ChangeOptimizationText();
            this.Hide();
        }

        private void SelectScheduleButton_Click(object sender, EventArgs e)
        {
            List<bool> canOptimize = new List<bool>(allCB.Count()-1);
            foreach (var checkBox in allCB)
            {
                if (checkBox.Checked == true)
                    canOptimize.Add(false);
                else
                    canOptimize.Add(true);
            }
            RefToCourseSelectForm.ChooseOptimizationCourses(canOptimize, oldSchedule, RefToLoadResultsForm);
            this.Hide();
        }
    }
}
