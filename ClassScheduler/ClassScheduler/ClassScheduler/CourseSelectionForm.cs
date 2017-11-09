using System;
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

namespace ClassScheduler
{
    public partial class CourseSelectionForm : Form
    {
        /// <summary>
        /// This is a window in which the user is expected to enter his courses for the term he/she selected in the input window beforehand.
        /// This is the last location before the C++ algorithm is used to create the student's schedule.
        /// </summary>
        /// Author: Kostiantyn Makrasnov

        AddCourseForm CourseAddPopup;

        public List<SingleCourse> availableCourses;
        public List<SingleCourse> selectedCourses = new List<SingleCourse>();
        private DataGridViewRow selectedRow;
        private int selectedTableRowIndex;
        private DataTable selectedCourseTable;
        private UserConfig userInfo;
        bool popUpCreated = false;

        public CourseSelectionForm(InitialInputForm userDataForm)
        {
            userInfo = userDataForm.userData;
            availableCourses = new List<SingleCourse>(userDataForm.courses);
            InitializeComponent();
        }

        //[FUNCTION - CourseSelectionForm_FormClosed]
        //Exits aplication when window is closed
        private void CourseSelectionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //[FUNCTION - MainToResultButton_Click]
        //Shows popup once a "Add Course" button is clicked
        private void AddCourseButton_Click(object sender, EventArgs e)
        {
            if (!popUpCreated)
            {
                CourseAddPopup = new AddCourseForm(this);
                CourseAddPopup.ShowDialog();
                popUpCreated = true;
            }
            else
            {
                CourseAddPopup.TryAddingCourse();
                CourseAddPopup.Show();
            }
        }

        //[FUNCTION - MainToResultButton_Click]
        //Performs actions when "View Results" button is clicked
        private void MainToResultButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResultForm Result = new ResultForm(this);
            Result.ShowDialog();
        }

        //[FUNCTION - CourseSelectionForm_Load]
        //Formats the labels on the courses selection form upon load
        private void CourseSelectionForm_Load(object sender, EventArgs e)
        {
            //Intro label
            string fullTermName;
            if (userInfo.termInterest == "FA")
                fullTermName = "fall";
            else if (userInfo.termInterest == "SP")
                fullTermName = "spring";
            else
                fullTermName = "January";
            CourseSelectionLabel.Text = "Welcome " + userInfo.firstName + ", please add your " + fullTermName + " course(s)... ";

            //Table labels
            selectedCourseTable = new DataTable();

            selectedCourseTable.Columns.Add("ID", typeof(string));
            selectedCourseTable.Columns.Add("Title", typeof(string));

            selectedCourseTable.Rows.Add("N/A", "No Courses Added");

            selectedCoursesGridView.DataSource = selectedCourseTable;
            selectedCoursesGridView.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            selectedCoursesGridView.Columns["ID"].Width = 72;

            selectedRow = selectedCoursesGridView.Rows[0];
            selectedTableRowIndex = 0;
    }

        //[FUNCTION - updateCourseTable]
        //Records index and row info of selected cell
        private void selectedCoursesTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedTableRowIndex = e.RowIndex; //*different method needed for multiple course selection at once*
                selectedRow = selectedCoursesGridView.Rows[selectedTableRowIndex];
            } 
        }

        //[FUNCTION - RemoveCourseButton_Click]
        //Performs removal of a selected course upon click of "Remove"
        private void RemoveCourseButton_Click(object sender, EventArgs e)
        {
            if (selectedCourses.Count() >= 1)
            {
                selectedCourses.Remove(selectedCourses.Find(s => (s.courseName == (string)selectedRow.Cells[1].Value)
                                                              && (s.abrvCourseName == (string)selectedRow.Cells[0].Value)));
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
        //Re-populates the entire table based on updated selectedStorage
        public void RefreshTable()
        {
            //Debug.WriteLine("Selected Courses Avalible:" + selectedCourses.Count());
            //foreach (var course in selectedCourses)
            //{
            //    Debug.WriteLine("selected course ID:" + course.abrvCourseName);
            //}
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
                    selectedCourseTable.Rows.Add(course.abrvCourseName, course.courseName);
                }

                if (selectedTableRowIndex >= selectedCourses.Count())
                    selectedTableRowIndex--;

                selectedCoursesGridView.CurrentCell = selectedCoursesGridView.Rows[selectedTableRowIndex].Cells[0];
                selectedCoursesGridView.Rows[selectedTableRowIndex].Selected = true;
                selectedRow = selectedCoursesGridView.Rows[selectedTableRowIndex];
            }
        }
    }
}
