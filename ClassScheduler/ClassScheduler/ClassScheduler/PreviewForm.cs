using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;

namespace ClassScheduler
{
    public partial class PreviewForm : Form
    {
        string fileName;

        public PreviewForm()
        {
            InitializeComponent();
        }

        public PreviewForm(string fileName)
        {
            InitializeComponent();
            this.fileName = fileName;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PreviewForm_Load(object sender, EventArgs e)
        {
            
        }

        //Accessor method to access private control previewDataGridView
        public DataGridView getPreviewDGV()
        {
            return previewDataGridView;
        }
    }
}
