namespace ClassScheduler
{
    partial class CourseSelectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseSelectionForm));
            this.AddCourseButton = new System.Windows.Forms.Button();
            this.CourseSelectionLabel = new System.Windows.Forms.Label();
            this.RemoveCourseButton = new System.Windows.Forms.Button();
            this.MainToResultButton = new System.Windows.Forms.Button();
            this.selectedCoursesGridView = new System.Windows.Forms.DataGridView();
            this.TotalCreditsLabel = new System.Windows.Forms.Label();
            this.LoadingSchedulesPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TotalAmountLabel = new System.Windows.Forms.Label();
            this.PercentCompleteLabel = new System.Windows.Forms.Label();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.CurrentAmountLabel = new System.Windows.Forms.Label();
            this.LoadingTypeLabel = new System.Windows.Forms.Label();
            this.BackgroundWorkerSchedule = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.selectedCoursesGridView)).BeginInit();
            this.LoadingSchedulesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddCourseButton
            // 
            this.AddCourseButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddCourseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AddCourseButton.ForeColor = System.Drawing.Color.White;
            this.AddCourseButton.Location = new System.Drawing.Point(111, 138);
            this.AddCourseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddCourseButton.Name = "AddCourseButton";
            this.AddCourseButton.Size = new System.Drawing.Size(219, 66);
            this.AddCourseButton.TabIndex = 0;
            this.AddCourseButton.Text = "Add Course";
            this.AddCourseButton.UseVisualStyleBackColor = false;
            this.AddCourseButton.Click += new System.EventHandler(this.AddCourseButton_Click);
            // 
            // CourseSelectionLabel
            // 
            this.CourseSelectionLabel.AutoSize = true;
            this.CourseSelectionLabel.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Italic);
            this.CourseSelectionLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.CourseSelectionLabel.Location = new System.Drawing.Point(100, 58);
            this.CourseSelectionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CourseSelectionLabel.Name = "CourseSelectionLabel";
            this.CourseSelectionLabel.Size = new System.Drawing.Size(496, 59);
            this.CourseSelectionLabel.TabIndex = 8;
            this.CourseSelectionLabel.Text = "Please Select Your Courses...";
            this.CourseSelectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RemoveCourseButton
            // 
            this.RemoveCourseButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RemoveCourseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RemoveCourseButton.ForeColor = System.Drawing.Color.White;
            this.RemoveCourseButton.Location = new System.Drawing.Point(111, 214);
            this.RemoveCourseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RemoveCourseButton.Name = "RemoveCourseButton";
            this.RemoveCourseButton.Size = new System.Drawing.Size(219, 66);
            this.RemoveCourseButton.TabIndex = 9;
            this.RemoveCourseButton.Text = "Remove Course";
            this.RemoveCourseButton.UseVisualStyleBackColor = false;
            this.RemoveCourseButton.Click += new System.EventHandler(this.RemoveCourseButton_Click);
            // 
            // MainToResultButton
            // 
            this.MainToResultButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainToResultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MainToResultButton.ForeColor = System.Drawing.Color.White;
            this.MainToResultButton.Location = new System.Drawing.Point(111, 768);
            this.MainToResultButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MainToResultButton.Name = "MainToResultButton";
            this.MainToResultButton.Size = new System.Drawing.Size(219, 66);
            this.MainToResultButton.TabIndex = 11;
            this.MainToResultButton.Text = "View Results";
            this.MainToResultButton.UseVisualStyleBackColor = false;
            this.MainToResultButton.Click += new System.EventHandler(this.MainToResultButton_Click);
            // 
            // selectedCoursesGridView
            // 
            this.selectedCoursesGridView.AllowUserToAddRows = false;
            this.selectedCoursesGridView.AllowUserToDeleteRows = false;
            this.selectedCoursesGridView.AllowUserToResizeRows = false;
            this.selectedCoursesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.selectedCoursesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectedCoursesGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.selectedCoursesGridView.Location = new System.Drawing.Point(375, 138);
            this.selectedCoursesGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selectedCoursesGridView.MultiSelect = false;
            this.selectedCoursesGridView.Name = "selectedCoursesGridView";
            this.selectedCoursesGridView.ReadOnly = true;
            this.selectedCoursesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.selectedCoursesGridView.Size = new System.Drawing.Size(1042, 695);
            this.selectedCoursesGridView.TabIndex = 12;
            this.selectedCoursesGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectedCoursesTable_CellClick);
            // 
            // TotalCreditsLabel
            // 
            this.TotalCreditsLabel.AutoSize = true;
            this.TotalCreditsLabel.ForeColor = System.Drawing.Color.Red;
            this.TotalCreditsLabel.Location = new System.Drawing.Point(122, 323);
            this.TotalCreditsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalCreditsLabel.Name = "TotalCreditsLabel";
            this.TotalCreditsLabel.Size = new System.Drawing.Size(115, 20);
            this.TotalCreditsLabel.TabIndex = 16;
            this.TotalCreditsLabel.Text = "Total Credits: 0";
            // 
            // LoadingSchedulesPanel
            // 
            this.LoadingSchedulesPanel.Controls.Add(this.pictureBox1);
            this.LoadingSchedulesPanel.Controls.Add(this.label4);
            this.LoadingSchedulesPanel.Controls.Add(this.panel2);
            this.LoadingSchedulesPanel.Location = new System.Drawing.Point(0, -1);
            this.LoadingSchedulesPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoadingSchedulesPanel.Name = "LoadingSchedulesPanel";
            this.LoadingSchedulesPanel.Size = new System.Drawing.Size(1477, 865);
            this.LoadingSchedulesPanel.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Location = new System.Drawing.Point(24, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Heading", 48F, System.Drawing.FontStyle.Italic);
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(484, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(816, 139);
            this.label4.TabIndex = 23;
            this.label4.Text = "Dynamic Scheduler";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.TotalAmountLabel);
            this.panel2.Controls.Add(this.PercentCompleteLabel);
            this.panel2.Controls.Add(this.ProgressBar);
            this.panel2.Controls.Add(this.CurrentAmountLabel);
            this.panel2.Controls.Add(this.LoadingTypeLabel);
            this.panel2.Location = new System.Drawing.Point(0, 290);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1477, 575);
            this.panel2.TabIndex = 21;
            // 
            // TotalAmountLabel
            // 
            this.TotalAmountLabel.AutoSize = true;
            this.TotalAmountLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.TotalAmountLabel.ForeColor = System.Drawing.Color.Black;
            this.TotalAmountLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TotalAmountLabel.Location = new System.Drawing.Point(1000, 276);
            this.TotalAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalAmountLabel.Name = "TotalAmountLabel";
            this.TotalAmountLabel.Size = new System.Drawing.Size(157, 29);
            this.TotalAmountLabel.TabIndex = 20;
            this.TotalAmountLabel.Text = "Total: 2342344\r\n";
            // 
            // PercentCompleteLabel
            // 
            this.PercentCompleteLabel.AutoSize = true;
            this.PercentCompleteLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.PercentCompleteLabel.ForeColor = System.Drawing.Color.Black;
            this.PercentCompleteLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.PercentCompleteLabel.Location = new System.Drawing.Point(662, 279);
            this.PercentCompleteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PercentCompleteLabel.Name = "PercentCompleteLabel";
            this.PercentCompleteLabel.Size = new System.Drawing.Size(159, 29);
            this.PercentCompleteLabel.TabIndex = 19;
            this.PercentCompleteLabel.Text = "Progress: 100%";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(318, 218);
            this.ProgressBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(843, 49);
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBar.TabIndex = 16;
            // 
            // CurrentAmountLabel
            // 
            this.CurrentAmountLabel.AutoSize = true;
            this.CurrentAmountLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.CurrentAmountLabel.ForeColor = System.Drawing.Color.Black;
            this.CurrentAmountLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.CurrentAmountLabel.Location = new System.Drawing.Point(313, 279);
            this.CurrentAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentAmountLabel.Name = "CurrentAmountLabel";
            this.CurrentAmountLabel.Size = new System.Drawing.Size(183, 29);
            this.CurrentAmountLabel.TabIndex = 17;
            this.CurrentAmountLabel.Text = "Current: 2342344";
            this.CurrentAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LoadingTypeLabel
            // 
            this.LoadingTypeLabel.AutoSize = true;
            this.LoadingTypeLabel.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Bold);
            this.LoadingTypeLabel.ForeColor = System.Drawing.Color.Black;
            this.LoadingTypeLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.LoadingTypeLabel.Location = new System.Drawing.Point(514, 137);
            this.LoadingTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoadingTypeLabel.Name = "LoadingTypeLabel";
            this.LoadingTypeLabel.Size = new System.Drawing.Size(457, 61);
            this.LoadingTypeLabel.TabIndex = 18;
            this.LoadingTypeLabel.Text = "Schedule Calculation";
            this.LoadingTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackgroundWorkerSchedule
            // 
            this.BackgroundWorkerSchedule.WorkerReportsProgress = true;
            this.BackgroundWorkerSchedule.WorkerSupportsCancellation = true;
            this.BackgroundWorkerSchedule.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerSchedule_DoWork);
            this.BackgroundWorkerSchedule.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorkerSchedule_ProgressChanged);
            this.BackgroundWorkerSchedule.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorkerSchedule_RunWorkerCompleted);
            // 
            // CourseSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1476, 863);
            this.Controls.Add(this.LoadingSchedulesPanel);
            this.Controls.Add(this.TotalCreditsLabel);
            this.Controls.Add(this.selectedCoursesGridView);
            this.Controls.Add(this.MainToResultButton);
            this.Controls.Add(this.RemoveCourseButton);
            this.Controls.Add(this.CourseSelectionLabel);
            this.Controls.Add(this.AddCourseButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1489, 893);
            this.Name = "CourseSelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Selection";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CourseSelectionForm_FormClosed);
            this.Load += new System.EventHandler(this.CourseSelectionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selectedCoursesGridView)).EndInit();
            this.LoadingSchedulesPanel.ResumeLayout(false);
            this.LoadingSchedulesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddCourseButton;
        private System.Windows.Forms.Label CourseSelectionLabel;
        private System.Windows.Forms.Button RemoveCourseButton;
        private System.Windows.Forms.Button MainToResultButton;
        private System.Windows.Forms.DataGridView selectedCoursesGridView;
        private System.Windows.Forms.Label TotalCreditsLabel;
        private System.Windows.Forms.Panel LoadingSchedulesPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TotalAmountLabel;
        private System.Windows.Forms.Label PercentCompleteLabel;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label CurrentAmountLabel;
        private System.Windows.Forms.Label LoadingTypeLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker BackgroundWorkerSchedule;
    }
}