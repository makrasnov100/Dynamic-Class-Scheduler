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

    /// <summary>
    /// This is a window in which the user is expected to enter his courses for the term he/she selected in the input window beforehand.
    /// This is the last location before the C++ algorithm is used to create the student's schedule.
    /// </summary>
    /// Author: Kostiantyn Makrasnov

    public partial class CourseSelectionForm : Form
    {

        AddCourseForm CourseAddPopup;

        public List<SingleCourse> availableCourses;
        public List<SingleCourse> selectedCourses = new List<SingleCourse>();
        private List<List<SingleCourse>> suggestedCourses;
        private int creditAmount = 0;

        private DataGridViewRow selectedRow;
        private int selectedTableRowIndex;
        private DataTable selectedCourseTable;

        private UserConfig userInfo;
        private bool popUpCreated = false;

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
                if (CourseAddPopup.getFilteredCourses().Count() != 0)
                {
                    CourseAddPopup.TryAddingCourse();
                } 
                CourseAddPopup.Show();
            }
        }

        //[FUNCTION - MainToResultButton_Click]
        //Performs actions when "View Results" button is clicked
        private void MainToResultButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ComputeOptimalTimes();

            //ResultForm Result = new ResultForm(this);
            //Manipulate the Result form before it is displayed...
            //manipulateSelectedCourses();

            //Result.ShowDialog();
            //manipulateSelectedCourses();
        }

        //[FUNCTION - CourseSelectionForm_Load]
        //Formats the labels on the courses selection form upon load
        private void CourseSelectionForm_Load(object sender, EventArgs e)
        {
            //Intro label
            string fullTermName;
            if (userInfo.getTermInterest() == "FA")
                fullTermName = "fall";
            else if (userInfo.getTermInterest() == "SP")
                fullTermName = "spring";
            else
                fullTermName = "January";
            CourseSelectionLabel.Text = "Welcome " + userInfo.getFirstName() + ", please add your " + fullTermName + " course(s)... ";
            UpdateCreditAmount();

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
        //Chooses the correct algorithm
        public void ComputeOptimalTimes()
        {
            LoadingResultsForm ResultLoad = new LoadingResultsForm();
            //ShowDialog(ResultLoad);

            Random random = new Random();

            int numPossib = 1;
            foreach (var course in availableCourses)
            {
                Debug.WriteLine(course.sections.Count());
                if(course.sections.Count() != 0)
                    numPossib *= course.sections.Count();
            }
            Debug.WriteLine("NUMBER OF SCHEDULE POSSIBILITIES: " + numPossib);
            //if (numPossib <= 20)
            //{
            //    BasicCalculation sectionCalculation = new BasicCalculation(selectedCourses);
            //}
            //else
            //{
            //    GeneticCalculation sectionCalculation = new GeneticCalculation(20, selectedCourses.Count(), creditAmount, random, selectedCourses, ResultLoad, mutationRate: .01);
            //}
        }

        public void ComputeOptimalTimes(List<List<SingleCourse>> suggestedCourses)
        {
            //performs List Algorithms with suggested courses variable
        }
    }
}
