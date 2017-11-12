﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ClassScheduler
{

    /// <summary>
    /// This is a window in which the user is expected to find a particular course to add.
    /// Filter options are avaliable for faster searching.
    /// </summary>
    /// Author: Kostiantyn Makrasnov

    public partial class AddCourseForm : Form
    {

        //EXTRA FEATURES TO ADD
        //- Searchbar
        //- Preloading of this form
        //- dynamic update of filters

        private List<string> courseLevelFilterValues = new List<string>();
        private List<string> departmentFilterValues = new List<string>();
        private List<string> instructorFilterValues = new List<string>();

        private CourseSelectionForm MainCourseForm = null;

        private List<SingleCourse> allCourses;
        private List<SingleCourse> filteredCourses;

        private DataTable courseTable = new DataTable();
        private DataGridViewRow selectedRow;
        private int selectedTableIndex = 0;
        private bool courseAccepted = false;


        public AddCourseForm(CourseSelectionForm MainForm)
        {
            this.allCourses = MainForm.availableCourses;
            this.filteredCourses = new List<SingleCourse>(allCourses);
            MainCourseForm = MainForm as CourseSelectionForm;
            InitializeComponent();
        }


        //[FUNCTION - AddCourseForm_Load]
        //Populates courseDataTable upon initial load of popup
        private void AddCourseForm_Load(object sender, EventArgs e)
        {
            courseTable.Columns.Add("ID", typeof(string));
            courseTable.Columns.Add("Title", typeof(string));

            foreach (SingleCourse course in allCourses)
                courseTable.Rows.Add(course.getAbrvCourseName(), course.getCourseName());

            addCoursesDataTable.DataSource = courseTable;
            addCoursesDataTable.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            addCoursesDataTable.Columns["ID"].Width = 72;

            TryAddingCourse();
            UpdateSearchTotalLabel();
            UpdateFilters();
        }

        //[FUNCTION - addButton_Click]
        //Adds selected course to user's courses when button is clicked
        private void addButton_Click(object sender, EventArgs e)
        {
            if(courseAccepted)
            {
                Debug.WriteLine("Comparing: " + (string)selectedRow.Cells[1].Value + " and " + (string)selectedRow.Cells[0].Value);
                Debug.WriteLine("with" + allCourses[1].getCourseName() + " and " + allCourses[1].getAbrvCourseName());
                selectedRow = addCoursesDataTable.Rows[selectedTableIndex];     
                SingleCourse selectedCourseClass = allCourses[allCourses.IndexOf(allCourses.Find(s => (s.getCourseName() == (string)selectedRow.Cells[1].Value)
                                                                                                   && (s.getAbrvCourseName() == (string)selectedRow.Cells[0].Value)))];
                MainCourseForm.selectedCourses.Add(selectedCourseClass);
                addCourseStateLabel.ForeColor = Color.Green;
                addCourseStateLabel.Text = "Added " + (string)selectedRow.Cells[1].Value + " to course list!";
                MainCourseForm.RefreshTable();
                courseAccepted = false;
            }
        }

        //[FUNCTION - cancelAddButton_Click]
        //Cancels additional course selection (hides pop-up)
        private void cancelAddButton_Click(object sender, EventArgs e)
        {
            MainCourseForm.ResetSelectToFirstIndex();
            this.Hide();
        }

        //[FUNCTION - addCoursesDataTable_CellClick]
        //Records index and row info of selected cell
        private void addCoursesDataTable_CellClick(object sender, DataGridViewCellEventArgs e) 
        {
            if(e.RowIndex >= 0)
            {
                selectedTableIndex = e.RowIndex; //*different method needed for multiple course selection at once*
                TryAddingCourse();
            }
        }

        //[FUNCTION - TryAddingCourse]
        //Attepts to add selected course
        public void TryAddingCourse()
        {
            selectedRow = addCoursesDataTable.Rows[selectedTableIndex];

            if (MainCourseForm.selectedCourses.Count() >= 10)
            {
                addCourseStateLabel.ForeColor = Color.Red;
                addCourseStateLabel.Text = "Cannot have more that 10 courses!";
                courseAccepted = false;
            }
            else if (MainCourseForm.selectedCourses.IndexOf(allCourses.Find(s => (s.getCourseName() == (string)selectedRow.Cells[1].Value) 
                                                                        && (s.getAbrvCourseName() == (string)selectedRow.Cells[0].Value))) != -1)
            {
                addCourseStateLabel.ForeColor = Color.Red;
                addCourseStateLabel.Text = "You already added this course!";
                courseAccepted = false;
            }
            else
            {
                addCourseStateLabel.ForeColor = Color.Blue;
                addCourseStateLabel.Text = "Ready to add " + (string)selectedRow.Cells[1].Value + " to course list!";
                courseAccepted = true;
            }
        }

        //[FUNCTION - UpdateSearchTotalLabel]
        //Updates label indicating howw much courses are displayed
        private void UpdateSearchTotalLabel()
        {
            showingCoursesCount.Text = filteredCourses.Count() + " out of " + allCourses.Count();
        }

        //[FUNCTION - UpdateFilters]
        //Populates filters by which classes can be sorted
        void UpdateFilters()
        {
            foreach(var course in allCourses)
            {
                if (!courseLevelFilterValues.Exists(s => s == course.getCourseLevel())) //**May just switch to manual input in future**
                    courseLevelFilterValues.Add(course.getCourseLevel());

                if (!departmentFilterValues.Exists(s => s == course.getDepartmentName()))
                    departmentFilterValues.Add(course.getDepartmentName());

                foreach (string instruct in course.getInstructAvailable())
                    if (!instructorFilterValues.Exists(s => s == instruct))
                    {
                        instructorFilterValues.Add(instruct);
                        Debug.WriteLine("Added instruct:" + instruct);
                    }
            }

            courseLevelFilterValues = courseLevelFilterValues.OrderBy(s => s.Substring(0)).ToList();
            departmentFilterValues = departmentFilterValues.OrderBy(s => s.Substring(0)).ToList();
            instructorFilterValues = instructorFilterValues.OrderBy(s => s.Substring(0)).ToList();

            courseLevelFilterValues.Insert(0, "Any");
            departmentFilterValues.Insert(0, "Any");
            instructorFilterValues.Insert(0, "Any");

            //courseLevelFilterValues.Sort();
            //departmentFilterValues.Sort();
            //instructorFilterValues.Sort();

            foreach (string levelChoise in courseLevelFilterValues)
                CourseLevelFilter.Items.Add(levelChoise);
            foreach (string departmentChoise in departmentFilterValues)
                DepartmentFilter.Items.Add(departmentChoise);
            foreach (string instructChoise in instructorFilterValues)
                InstructorNameFilter.Items.Add(instructChoise);   

            CourseLevelFilter.SelectedIndex = 0;
            DepartmentFilter.SelectedIndex = 0;
            InstructorNameFilter.SelectedIndex = 0;


            //labelComboBox.Items.Refresh();
        }


        //[FUNCTION - DepartmentFilter_SelectedIndexChanged]
        //Removes all courses not fitting to department criteria
        private void DepartmentFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
           FilterCourses();
        }

        //[FUNCTION - CourseLevelFilter_SelectedIndexChanged]
        //Removes all courses not fitting to course level criteria
        private void CourseLevelFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
           FilterCourses(); 
        }


        //[FUNCTION - InstructorNameFilter_SelectedIndexChanged]
        //Removes all courses not fitting to instructor name criteria
        private void InstructorNameFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterCourses();
        }

        //[FUNCTION - FilterCourses]
        //Changes visible courses in table based on filters selected
        private void FilterCourses()
        {
            filteredCourses.Clear();
            filteredCourses = new List<SingleCourse>(allCourses);

            Debug.WriteLine("Department filter text:" + DepartmentFilter.Text + " | Course Level text: " + CourseLevelFilter.Text + " | Instructor Filter Text: " + InstructorFilter.Text);

            bool departFilterEnabled = (DepartmentFilter.Text == "Any") ? false : true;
            bool levelFilterEnabled = (CourseLevelFilter.Text == "Any") ? false : true;
            bool instructFilterEnabled = (InstructorNameFilter.Text == "Any") ? false : true;

            Debug.WriteLine("Department filter enabled? " + departFilterEnabled + " | Course Level enabled? " + levelFilterEnabled + " | Instructor Filter Enabled? " + instructFilterEnabled);

            if (departFilterEnabled || levelFilterEnabled || instructFilterEnabled)
            {
                foreach (SingleCourse course in allCourses)
                    if ((departFilterEnabled ? course.getDepartmentName() != DepartmentFilter.Text : false) ||
                        (levelFilterEnabled ? course.getCourseLevel() != CourseLevelFilter.Text : false) ||
                        (instructFilterEnabled ? FindIfMatchingInstructs(course) : false))
                    {
                        filteredCourses.Remove(course);
                    }
            }

            courseTable.Rows.Clear();
            foreach (SingleCourse course in filteredCourses)
                courseTable.Rows.Add(course.getAbrvCourseName(), course.getCourseName());

            addCoursesDataTable.DataSource = courseTable;

            UpdateSearchTotalLabel();
        }

        //[FUNCTION - FindIfMatchingInstructs]
        //Returns false if course doesnt have a matching instructor
        bool FindIfMatchingInstructs(SingleCourse course)
        {
            foreach (string instructor in course.getInstructAvailable())
            {
                if (instructor == InstructorNameFilter.Text)
                    return false;
            }

            return true;
        }
    }
}
