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
            this.selectedCoursesTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.selectedCoursesTable)).BeginInit();
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
            this.CourseSelectionLabel.Font = new System.Drawing.Font("Minion Pro", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseSelectionLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.CourseSelectionLabel.Location = new System.Drawing.Point(64, 40);
            this.CourseSelectionLabel.Name = "CourseSelectionLabel";
            this.CourseSelectionLabel.Size = new System.Drawing.Size(312, 37);
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
            // 
            // MainToResultButton
            // 
            this.MainToResultButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainToResultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MainToResultButton.ForeColor = System.Drawing.Color.White;
            this.MainToResultButton.Location = new System.Drawing.Point(71, 500);
            this.MainToResultButton.Name = "MainToResultButton";
            this.MainToResultButton.Size = new System.Drawing.Size(146, 43);
            this.MainToResultButton.TabIndex = 11;
            this.MainToResultButton.Text = "View Results";
            this.MainToResultButton.UseVisualStyleBackColor = false;
            this.MainToResultButton.Click += new System.EventHandler(this.MainToResultButton_Click);
            // 
            // selectedCoursesTable
            // 
            this.selectedCoursesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectedCoursesTable.Location = new System.Drawing.Point(250, 90);
            this.selectedCoursesTable.Name = "selectedCoursesTable";
            this.selectedCoursesTable.Size = new System.Drawing.Size(695, 452);
            this.selectedCoursesTable.TabIndex = 12;
            // 
            // CourseSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.selectedCoursesTable);
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
            ((System.ComponentModel.ISupportInitialize)(this.selectedCoursesTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddCourseButton;
        private System.Windows.Forms.Label CourseSelectionLabel;
        private System.Windows.Forms.Button RemoveCourseButton;
        private System.Windows.Forms.Button MainToResultButton;
        private System.Windows.Forms.DataGridView selectedCoursesTable;
    }
}