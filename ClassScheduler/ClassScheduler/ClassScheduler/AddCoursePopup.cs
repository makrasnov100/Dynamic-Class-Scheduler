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
    public partial class AddCourseForm : Form
    {
        List<SingleCourse> allCourses;
        public AddCourseForm(CourseSelectionForm MainForm)
        {
            this.allCourses = MainForm.availableCourses;
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
        }

        //[FUNCTION - addButton_Click]
        //Adds selected course to user's courses when button is clicked
        private void addButton_Click(object sender, EventArgs e)
        {
        }

        //[FUNCTION - addButton_Click]
        //Cancels additional course selection (closes pop-up)
        private void cancelAddButton_Click(object sender, EventArgs e)
        {
            this.Close(); //MAKE POP UP HIDE INSTEAD OF CLOSE
        }
    }
}
