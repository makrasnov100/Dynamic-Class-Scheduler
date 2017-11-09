using System;
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

        //FEATURES TO ADD
        //- Searchbar

        private List<string> courseLevelFilterValues = new List<string> { "Any" };
        private List<string> departmentFilterrValues = new List<string> { "Any" };
        private List<string> instructorFilterrValues = new List<string> { "Any" };

        private CourseSelectionForm MainCourseForm = null;
        private List<SingleCourse> allCourses;
        private DataGridViewRow selectedRow;
        private int selectedTableIndex = 0;
        private bool courseAccepted = false;


        public AddCourseForm(CourseSelectionForm MainForm)
        {
            this.allCourses = MainForm.availableCourses;
            MainCourseForm = MainForm as CourseSelectionForm;
            InitializeComponent();
        }


        //[FUNCTION - AddCourseForm_Load]
        //Populates courseDataTable upon initial load of popup
        private void AddCourseForm_Load(object sender, EventArgs e)
        {
            DataTable courseTable = new DataTable();

            courseTable.Columns.Add("ID", typeof(string));
            courseTable.Columns.Add("Title", typeof(string));

            foreach (var course in allCourses)
                courseTable.Rows.Add(course.abrvCourseName, course.courseName);

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
            if(courseAccepted == true)
            {
                selectedRow = addCoursesDataTable.Rows[selectedTableIndex];     
                SingleCourse selectedCourseClass = allCourses[allCourses.IndexOf(allCourses.Find(s => (s.courseName == (string)selectedRow.Cells[1].Value)
                                                                                                   && (s.abrvCourseName == (string)selectedRow.Cells[0].Value)))];
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
            else if (MainCourseForm.selectedCourses.IndexOf(allCourses.Find(s => (s.courseName == (string)selectedRow.Cells[1].Value) 
                                                                        && (s.abrvCourseName == (string)selectedRow.Cells[0].Value))) != -1)
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
            showingCoursesCount.Text = allCourses.Count() + " out of " + allCourses.Count();
        }

        //[FUNCTION - UpdateFilters]
        //Populates filters by which classes can be sorted
        void UpdateFilters()
        {
            foreach(var course in allCourses)
            {
                if (!courseLevelFilterValues.Exists(s => s == course.courseLevel)) //**May just switch to manual input in future**
                    courseLevelFilterValues.Add(course.courseLevel);
            }

            foreach (var choise in courseLevelFilterValues)
                CourseLevelFilter.Items.Add(choise);

            CourseLevelFilter.SelectedIndex = 0;
            //labelComboBox.Items.Refresh();
        }
    }
}
