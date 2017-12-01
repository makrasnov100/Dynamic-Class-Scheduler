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
            this.AddCourseButton = new System.Windows.Forms.Button();
            this.CourseSelectionLabel = new System.Windows.Forms.Label();
            this.RemoveCourseButton = new System.Windows.Forms.Button();
            this.MainToResultButton = new System.Windows.Forms.Button();
            this.selectedCoursesGridView = new System.Windows.Forms.DataGridView();
            this.TotalCreditsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.selectedCoursesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddCourseButton
            // 
            this.AddCourseButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddCourseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AddCourseButton.ForeColor = System.Drawing.Color.White;
            this.AddCourseButton.Location = new System.Drawing.Point(74, 90);
            this.AddCourseButton.Name = "AddCourseButton";
            this.AddCourseButton.Size = new System.Drawing.Size(146, 43);
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
            this.CourseSelectionLabel.Location = new System.Drawing.Point(67, 38);
            this.CourseSelectionLabel.Name = "CourseSelectionLabel";
            this.CourseSelectionLabel.Size = new System.Drawing.Size(327, 39);
            this.CourseSelectionLabel.TabIndex = 8;
            this.CourseSelectionLabel.Text = "Please Select Your Courses...";
            this.CourseSelectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RemoveCourseButton
            // 
            this.RemoveCourseButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RemoveCourseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RemoveCourseButton.ForeColor = System.Drawing.Color.White;
            this.RemoveCourseButton.Location = new System.Drawing.Point(74, 139);
            this.RemoveCourseButton.Name = "RemoveCourseButton";
            this.RemoveCourseButton.Size = new System.Drawing.Size(146, 43);
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
            this.MainToResultButton.Location = new System.Drawing.Point(74, 499);
            this.MainToResultButton.Name = "MainToResultButton";
            this.MainToResultButton.Size = new System.Drawing.Size(146, 43);
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
            this.selectedCoursesGridView.Location = new System.Drawing.Point(250, 90);
            this.selectedCoursesGridView.MultiSelect = false;
            this.selectedCoursesGridView.Name = "selectedCoursesGridView";
            this.selectedCoursesGridView.ReadOnly = true;
            this.selectedCoursesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.selectedCoursesGridView.Size = new System.Drawing.Size(695, 452);
            this.selectedCoursesGridView.TabIndex = 12;
            this.selectedCoursesGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectedCoursesTable_CellClick);
            // 
            // TotalCreditsLabel
            // 
            this.TotalCreditsLabel.AutoSize = true;
            this.TotalCreditsLabel.ForeColor = System.Drawing.Color.Red;
            this.TotalCreditsLabel.Location = new System.Drawing.Point(81, 210);
            this.TotalCreditsLabel.Name = "TotalCreditsLabel";
            this.TotalCreditsLabel.Size = new System.Drawing.Size(78, 13);
            this.TotalCreditsLabel.TabIndex = 16;
            this.TotalCreditsLabel.Text = "Total Credits: 0";
            // 
            // CourseSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.TotalCreditsLabel);
            this.Controls.Add(this.selectedCoursesGridView);
            this.Controls.Add(this.MainToResultButton);
            this.Controls.Add(this.RemoveCourseButton);
            this.Controls.Add(this.CourseSelectionLabel);
            this.Controls.Add(this.AddCourseButton);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "CourseSelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Selection";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CourseSelectionForm_FormClosed);
            this.Load += new System.EventHandler(this.CourseSelectionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selectedCoursesGridView)).EndInit();
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
    }
}