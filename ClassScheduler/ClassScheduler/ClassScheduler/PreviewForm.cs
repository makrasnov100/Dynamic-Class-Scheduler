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
    public partial class PreviewForm : Form
    {
        string SelectedFileName = "";

        public PreviewForm()
        {
            InitializeComponent();
        }

        public PreviewForm(string SelectedFileName)
        {
            this.SelectedFileName = SelectedFileName;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public DataGridView getPreviewDGV()
        {
            return previewDataGridView;
        }

        public void setFilenameLabel()
        {
            if (SelectedFileName != null || SelectedFileName != "")
            {
                fileTextBox.Text = SelectedFileName;
            }
            else
                MessageBox.Show("The filename was empty."); //For debug purposes
        }

        public void setFileName(string SelectedFileName)
        {
            this.SelectedFileName = SelectedFileName;
        }
    }
}
