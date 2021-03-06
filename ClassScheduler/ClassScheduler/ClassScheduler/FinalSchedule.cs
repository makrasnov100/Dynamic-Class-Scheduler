﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp;
using iTextSharp.text.pdf;
using System.Drawing.Printing;

namespace ClassScheduler
{
    public partial class FinalSchedule : Form
    {
        private Panel panel;
        private PictureBox pictureBox;
        private Bitmap fullbmp;
        LoadingResultsForm loadingResultsForm;

        PrintDocument doc = new PrintDocument();

        public FinalSchedule(LoadingResultsForm loadingResultsForm)
        {
            this.loadingResultsForm = loadingResultsForm;
            InitializeComponent();
        }

        public void setPictureBox(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
        }

        public void setBitmap(Bitmap fullbmp)
        {
            this.fullbmp = fullbmp;
        }

        public void appendStudentScheduleLabelText(string text)
        {
            displayLbl.Text += text;
        }

        public void changeDisplayLabelText(string text)
        {
            displayLbl.Text = text;
        }

        private void savePanelToImage()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + @"\test.jpeg";

            try
            {
                var pnl = this.schedulePanel;
                using (var bmp = new Bitmap(pnl.Width, pnl.Height))
                {
                    pnl.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                    bmp.Save(path);
                    MessageBox.Show("File save to " + path + " successful!");
                    bmp.Dispose();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            savePanelToImage();
        }

        public void changeDisplayLabelAnchor()
        {
            displayLbl.Anchor = (AnchorStyles.Left | AnchorStyles.Right);
        }

        public void displayLblParent()
        {
            displayLbl.Parent = schedulePanel;
            changeDisplayLabelAnchor();
        }

        public int getSchedulePanelWidth()
        {
            return schedulePanel.Width;
        }

        public TableLayoutPanel getDayLayoutPanel()
        {
            return dayLayoutPanel;
        }

        public TableLayoutPanel getMondayLayoutPanel()
        {
            return mondayLayoutPanel;
        }

        public TableLayoutPanel getSpecificPanel(int day)
        {
            switch (day)
            {
                case 0:
                    return mondayLayoutPanel;
                case 1:
                    return tuesdayLayoutPanel;
                case 2:
                    return wednesdayLayoutPanel;
                case 3:
                    return thursdayLayoutPanel;
                case 4:
                    return fridayLayoutPanel;
            }
            return null;
        }
        
        //from Microsoft Documentation on the PrintDialog class
        private void saveAsPdfButton_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            doc.PrintPage += Doc_PrintPage;
            printDialog.Document = doc;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            var pnl = this.schedulePanel;
            using (var bmp = new Bitmap(pnl.Width, pnl.Height))
            {
                pnl.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                e.Graphics.DrawImage(bmp, 0, 0);
                bmp.Dispose();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //clear the monday through friday labels
            loadingResultsForm.clearDayLabels();
            this.Hide();
            loadingResultsForm.Show();
        }
    }
}
