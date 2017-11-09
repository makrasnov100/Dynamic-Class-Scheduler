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

    /// <summary>
    /// This is a window in which the user is given the final layout of his courses.
    /// </summary>
    /// Author:


    public partial class ResultForm : Form
    {
        public CourseSelectionForm MainPageForm;
        bool isRevision = false;

        public ResultForm(CourseSelectionForm CoursesSelectionForm)
        {
            MainPageForm = CoursesSelectionForm;
            InitializeComponent();
        }

        private void resultsToMainButton_Click(object sender, EventArgs e)
        {
            MainPageForm.Show();
            isRevision = true;
            this.Close();
        }

        private void ResultForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!isRevision)
                Application.Exit();
        }
    }
}
