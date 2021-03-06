﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ClassScheduler
{

    /// <summary>
    /// This is a window in which the user is expected to enter his courses for the term he/she selected in the input window beforehand.
    /// This is the last location before an algorithm is used to create the student's schedule.
    /// </summary>
    /// 
    /// Author: Kostiantyn Makrasnov

    public partial class CourseSelectionForm : Form
    {

        public List<SingleCourse> availableCourses;
        public List<SingleCourse> selectedCourses = new List<SingleCourse>(10);
        private Random random = new Random();
        private int creditAmount = 0;

        private DataGridViewRow selectedRow;
        private int selectedTableRowIndex;
        private DataTable selectedCourseTable;

        private AddCourseForm RefToCourseAddPopup;
        private BasicCalculationForm RefToBasicCalculationForm;
        private LoadingResultsForm RefToScheduleSelectForm;
        private UserConfig userInfo;
        private bool popUpCreated = false;
        private bool isOptimization = false;
        private bool isFirstCalculation = true;
        int numPossib;

        public CourseSelectionForm(InitialInputForm userDataForm)
        {
            userInfo = userDataForm.getUserData();
            availableCourses = new List<SingleCourse>(userDataForm.courses);
            InitializeComponent();
        }

        //[FUNCTION - CourseSelectionForm_FormClosed]
        //Exits aplication when window is closed
        private void CourseSelectionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //[FUNCTION - AddCourseButton_Click]
        //Shows popup once a "Add Course" button is clicked
        private void AddCourseButton_Click(object sender, EventArgs e)
        {
            if (!popUpCreated)
            {
                RefToCourseAddPopup = new AddCourseForm(this);
                RefToCourseAddPopup.ShowDialog();
                popUpCreated = true;
            }
            else
            {
                if (RefToCourseAddPopup.getFilteredCourses().Count() != 0)
                    RefToCourseAddPopup.TryAddingCourse();
                RefToCourseAddPopup.Show();
            }
        }

        //[FUNCTION - MainToResultButton_Click]
        //Performs actions when "View Results" button is clicked
        private void MainToResultButton_Click(object sender, EventArgs e)
        {
            if(selectedCourses.Count() != 0)
            {
                if(isFirstCalculation)
                    ComputeOptimalTimesFirst(selectedCourses);
                else
                {
                    isOptimization = false;
                    ComputeOptimalTimes(selectedCourses);
                }
            }
        }

        //[FUNCTION - CourseSelectionForm_Load]
        //Formats the labels on the courses selection form upon load
        private void CourseSelectionForm_Load(object sender, EventArgs e)
        {
            //Display correct intro label
            string fullTermName;
            if (userInfo.getTermInterest() == "FA")
                fullTermName = "fall";
            else if (userInfo.getTermInterest() == "SP")
                fullTermName = "spring";
            else
                fullTermName = "January";
            CourseSelectionLabel.Text = "Welcome " + userInfo.getFirstName() + ", please add your " + fullTermName + " course(s)... ";
            UpdateCreditAmount();

            //Table Setup
            selectedCourseTable = new DataTable();
            // - Set labels
            selectedCourseTable.Columns.Add("ID", typeof(string));
            selectedCourseTable.Columns.Add("Title", typeof(string));
            // - Set initial entry (doesn't count as course)
            selectedCourseTable.Rows.Add("N/A", "No Courses Added");
            // - Set formatting
            selectedCoursesGridView.DataSource = selectedCourseTable;
            selectedCoursesGridView.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            selectedCoursesGridView.Columns["ID"].Width = 72;
            // - Preselect first row
            selectedRow = selectedCoursesGridView.Rows[0];
            selectedTableRowIndex = 0;
        }

        //[FUNCTION - updateCourseTable]
        //Records index and row info of selected cell
        private void selectedCoursesTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedTableRowIndex = e.RowIndex; //(revise by creating different method for multiple course selection at once)
                selectedRow = selectedCoursesGridView.Rows[selectedTableRowIndex];
            } 
        }

        //[FUNCTION - RemoveCourseButton_Click]
        //Performs removal of a selected course upon click of "Remove" button
        private void RemoveCourseButton_Click(object sender, EventArgs e)
        {
            if (selectedCourses.Count() >= 1)
            {
                selectedCourses.Remove(selectedCourses.Find(s => (s.getCourseName() == (string)selectedRow.Cells[1].Value)
                                                              && (s.getAbrvCourseName() == (string)selectedRow.Cells[0].Value)));
                RefreshTable();
            }
        }

        //[FUNCTION - ResetSelectToFirstIndex]
        //Makes CourseDataGrid have first course selected for removal
        public void ResetSelectToFirstIndex()
        {
            selectedCoursesGridView.CurrentCell = selectedCoursesGridView.Rows[0].Cells[0];
            selectedCoursesGridView.Rows[0].Selected = true;
            selectedRow = selectedCoursesGridView.Rows[0];
            selectedTableRowIndex = 0;
        }

        //[FUNCTION - RefreshTable]
        //Re-populates the entire table based on updated selectedCourses
        public void RefreshTable()
        {
            if (selectedCourses.Count() == 0)
            {
                selectedCourseTable.Rows.Clear();
                selectedCourseTable.Rows.Add("N/A", "No Courses Added");
                ResetSelectToFirstIndex();
            }
            else
            {
                selectedCourseTable.Rows.Clear();
                foreach (SingleCourse course in selectedCourses)
                {
                    selectedCourseTable.Rows.Add(course.getAbrvCourseName(), course.getCourseName());
                }

                if (selectedTableRowIndex >= selectedCourses.Count())
                    selectedTableRowIndex--;

                selectedCoursesGridView.CurrentCell = selectedCoursesGridView.Rows[selectedTableRowIndex].Cells[0];
                selectedCoursesGridView.Rows[selectedTableRowIndex].Selected = true;
                selectedRow = selectedCoursesGridView.Rows[selectedTableRowIndex];
            }
            UpdateCreditAmount();
        }

        //[FUNCTION - UpdateCreditAmount()]
        //Updates the variable value and label for total course credits
        public void UpdateCreditAmount()
        {
            int totalCredits = 0;
            foreach(var course in selectedCourses)
                totalCredits += course.getCreditAmount();

            creditAmount = totalCredits;

            //Find a credit limit based on term
            int creditTopLimit = 0;
            int creditBottomLimit = 0;
            if (userInfo.getTermInterest() == "JA")
            {
                creditTopLimit = 5;
                creditBottomLimit = 3;
            }
            else
            {
                creditTopLimit = 17;
                creditBottomLimit = 12;
            }

            //Display formated credit label
            if (totalCredits < creditBottomLimit)
            {
                TotalCreditsLabel.ForeColor = Color.Red;
                TotalCreditsLabel.Text = "Total Credits: " + totalCredits + "\n - Need " + (creditBottomLimit - totalCredits) + " more for Full-Time!";
            }
            else if (totalCredits > creditTopLimit)
            {
                TotalCreditsLabel.ForeColor = Color.DarkOrange;
                TotalCreditsLabel.Text = "Total Credits: " + totalCredits + "\n - " + (totalCredits - creditTopLimit) + " credit overload!";
            }
            else
            {
                TotalCreditsLabel.ForeColor = Color.Green;
                TotalCreditsLabel.Text = "Total Credits: " + totalCredits + "\n - Full-Time attendence!";
            }
        }

        //[FUNCTION - manipulateSelectedCourses]
        //Displays selected course info in a data grid view on the result form (temporarily unused)
        public void manipulateSelectedCourses(ResultForm form)
        {
            form.timesDataGridView.Columns.Add("courseName", "Course Name");
            form.timesDataGridView.Columns.Add("sectionName", "Section Name");
            form.timesDataGridView.Columns.Add("sectionTime", "Section Time");
            form.timesDataGridView.Columns.Add("sectionDay", "Section Day");
            form.timesDataGridView.Columns.Add("startTimeMinutes", "Start Minutes since midnight");

            //Get all sections and section start times
            for (int i = 0; i < selectedCourses.Count; i++)
            {
                for (int j = 0; j < selectedCourses[i].getSections().Count; j++ )
                {
                    for (int k = 0; k < selectedCourses[i].getSections()[j].getStartTimes().Count; k++)
                    {
                        //Check if the section meets more than one day a week (which it most likely will)
                        if (selectedCourses[i].getSections()[j].getMeetDays().Count() > 1)
                        {
                            int count = selectedCourses[i].getSections()[j].getMeetDays().Count();

                            //A very inefficient way of displaying a row based on the number of days of the week it meets. 
                            //I'm sure there is a simple for loop to display this information, I will look into it...
                            switch (count) {
                                case 2:
                                    form.timesDataGridView.Rows.Add(selectedCourses[i].getCourseName(), 
                                    selectedCourses[i].getSections()[j].getID(), selectedCourses[i].getSections()[j].getStartTimes()[k], 
                                    selectedCourses[i].getSections()[j].getMeetDays()[k] + selectedCourses[i].getSections()[j].getMeetDays()[k+1], 
                                    selectedCourses[i].getSections()[j].getFormatedTime()[0].getStart());
                                    break;
                                case 3:
                                    form.timesDataGridView.Rows.Add(selectedCourses[i].getCourseName(), 
                                    selectedCourses[i].getSections()[j].getID(), selectedCourses[i].getSections()[j].getStartTimes()[k], 
                                    selectedCourses[i].getSections()[j].getMeetDays()[k] + selectedCourses[i].getSections()[j].getMeetDays()[k+1] 
                                    + selectedCourses[i].getSections()[j].getMeetDays()[k + 2],
                                    selectedCourses[i].getSections()[j].getFormatedTime()[0].getStart());
                                    break;
                                case 4:
                                    form.timesDataGridView.Rows.Add(selectedCourses[i].getCourseName(),
                                    selectedCourses[i].getSections()[j].getID(), selectedCourses[i].getSections()[j].getStartTimes()[k],
                                    selectedCourses[i].getSections()[j].getMeetDays()[k] + selectedCourses[i].getSections()[j].getMeetDays()[k + 1]
                                    + selectedCourses[i].getSections()[j].getMeetDays()[k + 2] + selectedCourses[i].getSections()[j].getMeetDays()[k + 3], 
                                    selectedCourses[i].getSections()[j].getFormatedTime()[0].getStart());
                                    break;
                                case 5:
                                    form.timesDataGridView.Rows.Add(selectedCourses[i].getCourseName(),
                                    selectedCourses[i].getSections()[j].getID(), selectedCourses[i].getSections()[j].getStartTimes()[k],
                                    selectedCourses[i].getSections()[j].getMeetDays()[k] + selectedCourses[i].getSections()[j].getMeetDays()[k + 1]
                                    + selectedCourses[i].getSections()[j].getMeetDays()[k + 2] + selectedCourses[i].getSections()[j].getMeetDays()[k + 3] +
                                    selectedCourses[i].getSections()[j].getMeetDays()[k + 4], selectedCourses[i].getSections()[j].getFormatedTime()[0].getStart());
                                    break;
                            }
                        }
                        else //This else clause will only execute if the section meets once a week
                        {
                            form.timesDataGridView.Rows.Add(selectedCourses[i].getCourseName(), selectedCourses[i].getSections()[j].getID(),
                            selectedCourses[i].getSections()[j].getStartTimes()[k], selectedCourses[i].getSections()[j].getMeetDays()[k],
                            selectedCourses[i].getSections()[j].getFormatedTime()[0].getStart());
                        }
                    }
                }
            }
            form.timesDataGridView.AutoResizeColumns();
            form.timesDataGridView.AutoResizeRows();
        }

        //[FUNCTION - ComputeOptimalTimes]
        //Correctly preps schedule calculation for the first time (different enough from the rest to deserve its owwn function)
        public void ComputeOptimalTimesFirst(List<SingleCourse> givenCourses)
        {
            //Find amount of combinations possible
            numPossib = 1;
            foreach (var course in givenCourses)
                if (course.getSections().Count() != 0)
                    numPossib = numPossib * course.getSections().Count();

            //Show calculation info in console
            Debug.WriteLine("Number of Schedule Possibilities: " + numPossib);
            Debug.WriteLine("*****************************************************************");
            Debug.WriteLine("NEW CALCULATION CLASS CREATED");

            //Create NEW calculation object/form
            this.Hide();
            RefToBasicCalculationForm = new BasicCalculationForm(givenCourses, numPossib, random, creditAmount, this, RefToScheduleSelectForm, isOptimization);
            RefToBasicCalculationForm.BeginWorking(false);
            RefToBasicCalculationForm.ShowDialog();
            isOptimization = false;
        }

        //[FUNCTION - ComputeOptimalTimes]
        //Correctly preps schedule calculation w/ optimized sections
        public void ComputeOptimalTimes(List<SingleCourse> givenCourses)
        {
            //Find amount of combinations possible
            numPossib = 1;
            foreach (var course in givenCourses)
                if (course.getSections().Count() != 0)
                    numPossib = numPossib * course.getSections().Count();

            //Show calculation info in console
            Debug.WriteLine("Number of Schedule Possibilities: " + numPossib);
            Debug.WriteLine("*****************************************************************");
            Debug.WriteLine("NEW OPTIMIZED CALCULATION STARTED | " + (isOptimization == true ? "OPTIMIZED" : "NOT OPTIMIZED"));

            //Use OLD calculation object/form
            this.Hide();
            RefToBasicCalculationForm.Show();
            RefToBasicCalculationForm.RestartCalculation(givenCourses, numPossib, creditAmount, isOptimization);
            RefToBasicCalculationForm.BeginWorking(isOptimization);
            isOptimization = false;
        }


        //[FUNCTION - ChooseOptimizationCourses]
        //Adds sections that can be substituted based on user defined settings (revise so courses fit better)
        public void ChooseOptimizationCourses(List<bool> canOptimize, SingleSchedule oldSchedule, LoadingResultsForm ScheduleSelectForm)
        {
            //Create copy of selected courses & set optimization state
            RefToScheduleSelectForm = ScheduleSelectForm;
            List<SingleCourse> selectedCoursesMod = new List<SingleCourse>(selectedCourses.Count());
            foreach (var course in selectedCourses)
                selectedCoursesMod.Add(DeepCopySingleCourse(course));
            isOptimization = true;

            //Add all similar courses to section list (revise to get more accurate substitutions)
            int optimizeCounter = 0;
            foreach (var optimizeOption in canOptimize)
            {
                if (optimizeOption == true)
                {
                    string matchCourseID = oldSchedule.getAllSections()[optimizeCounter].getID();
                    string matchCourseIDTrim = matchCourseID.Substring(0, matchCourseID.IndexOf("-", 4));
                    string depID = matchCourseID.Substring(0, matchCourseID.IndexOf("-", 0));
                    string levelID = matchCourseID.Substring((matchCourseID.IndexOf("-", 0) + 1), 1) + "00";
                    bool isLab = matchCourseIDTrim[matchCourseIDTrim.Length - 1] == 'L' ? true : false;
                    Debug.WriteLine("Dep ID: " + depID + " | Level ID: " + levelID + " | Lab State: " + isLab);

                    bool isLabCourse = false;
                    foreach (var course in availableCourses)
                    {
                        isLabCourse = course.getAbrvCourseName()[course.getAbrvCourseName().Length - 1] == 'L' ? true : false;
                        if ((course.getCourseLevel() == levelID && course.getAbrvCourseName().Contains(depID)) &&
                            (course.getAbrvCourseName() != matchCourseID.Substring(0, matchCourseID.IndexOf("-", 4))) &&
                            (isLab == isLabCourse))
                        {
                            foreach (var section in course.getSections())
                            {
                                Debug.WriteLine("Added a suggested section: " + section.getID());
                                selectedCoursesMod[optimizeCounter].getSections().Add(new SingleSection(section, true));
                            }
                        }
                    }           
                }
                optimizeCounter++;
            }
            ComputeOptimalTimes(selectedCoursesMod);
        }

        //[FUNCTION - DeepCopySingleCourse]
        //Function is mainly the answer from the following post on how to copy a complex object
        //https://stackoverflow.com/questions/16696448/how-to-make-a-copy-of-an-object-in-c-sharp
        //Copies instance of a SingleCourse Object into an identical new object
        public static SingleCourse DeepCopySingleCourse(SingleCourse other)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(ms, other);
                ms.Position = 0;
                return (SingleCourse)formatter.Deserialize(ms);
            }
        }

        //Accessor/mutator functions
        public void setIsFirstCalculationState(bool isFirstCalculation)
        {
            this.isFirstCalculation = isFirstCalculation;
        }
        public bool getIsFirstCalculationState()
        {
            return isFirstCalculation;
        }

        public void setIsOptimizationState(bool isOptimization)
        {
            this.isOptimization = isOptimization;
        }

        public string SelectedFileName { get; set; }

        //Accessor for the FinalSchedule form
        public UserConfig getUserInfo()
        {
            return userInfo;
        }
    }
}
