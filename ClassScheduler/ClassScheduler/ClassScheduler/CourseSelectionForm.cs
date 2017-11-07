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

namespace ClassScheduler
{
    public partial class CourseSelectionForm : Form
    {
        public List<SingleCourse> availableCourses;
        UserConfig userInfo;

        public CourseSelectionForm(InitialInputForm userDataForm)
        {
            userInfo = userDataForm.userData;
            availableCourses = new List<SingleCourse>(userDataForm.courses);
            InitializeComponent();
        }

        private void CourseSelectionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AddCourseButton_Click(object sender, EventArgs e)
        {
            AddCourseForm CourseAdd = new AddCourseForm(this);
            CourseAdd.ShowDialog();
        }

        private void MainToResultButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResultForm Result = new ResultForm(this);
            Result.ShowDialog();
        }

        private void CourseSelectionForm_Load(object sender, EventArgs e)
        {
            string fullTermName;
            if (userInfo.termInterest == "FA")
                fullTermName = "fall";
            else if (userInfo.termInterest == "SP")
                fullTermName = "spring";
            else
                fullTermName = "January";
            CourseSelectionLabel.Text = "Welcome " + userInfo.firstName + ", please add your " + fullTermName + " course(s)... ";
        }
    }
}
