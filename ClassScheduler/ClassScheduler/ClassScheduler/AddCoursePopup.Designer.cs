namespace ClassScheduler
{
    partial class AddCourseForm
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
            this.CourseSelectionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DepartmentFilter = new System.Windows.Forms.ComboBox();
            this.CourseLevelFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.InstructorFilter = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelAddButton = new System.Windows.Forms.Button();
            this.addCoursesDataTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.addCoursesDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // CourseSelectionLabel
            // 
            this.CourseSelectionLabel.AutoSize = true;
            this.CourseSelectionLabel.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Italic);
            this.CourseSelectionLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.CourseSelectionLabel.Location = new System.Drawing.Point(46, 40);
            this.CourseSelectionLabel.Name = "CourseSelectionLabel";
            this.CourseSelectionLabel.Size = new System.Drawing.Size(283, 39);
            this.CourseSelectionLabel.TabIndex = 9;
            this.CourseSelectionLabel.Text = "Select a Course to Add...";
            this.CourseSelectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 15F, System.Drawing.FontStyle.Italic);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(48, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filters:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DepartmentFilter
            // 
            this.DepartmentFilter.Font = new System.Drawing.Font("Sitka Heading", 12F);
            this.DepartmentFilter.FormattingEnabled = true;
            this.DepartmentFilter.Location = new System.Drawing.Point(120, 111);
            this.DepartmentFilter.Name = "DepartmentFilter";
            this.DepartmentFilter.Size = new System.Drawing.Size(129, 31);
            this.DepartmentFilter.TabIndex = 11;
            // 
            // CourseLevelFilter
            // 
            this.CourseLevelFilter.Font = new System.Drawing.Font("Sitka Heading", 12F);
            this.CourseLevelFilter.FormattingEnabled = true;
            this.CourseLevelFilter.Location = new System.Drawing.Point(255, 111);
            this.CourseLevelFilter.Name = "CourseLevelFilter";
            this.CourseLevelFilter.Size = new System.Drawing.Size(93, 31);
            this.CourseLevelFilter.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(116, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Department:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label3.Location = new System.Drawing.Point(251, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Course Level:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // InstructorFilter
            // 
            this.InstructorFilter.AutoSize = true;
            this.InstructorFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.InstructorFilter.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.InstructorFilter.Location = new System.Drawing.Point(350, 89);
            this.InstructorFilter.Name = "InstructorFilter";
            this.InstructorFilter.Size = new System.Drawing.Size(75, 17);
            this.InstructorFilter.TabIndex = 15;
            this.InstructorFilter.Text = "Instructor: ";
            this.InstructorFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Sitka Heading", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(354, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(207, 31);
            this.comboBox1.TabIndex = 16;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Black;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(567, 105);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(71, 41);
            this.addButton.TabIndex = 18;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelAddButton
            // 
            this.cancelAddButton.BackColor = System.Drawing.Color.Black;
            this.cancelAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cancelAddButton.ForeColor = System.Drawing.Color.White;
            this.cancelAddButton.Location = new System.Drawing.Point(644, 105);
            this.cancelAddButton.Name = "cancelAddButton";
            this.cancelAddButton.Size = new System.Drawing.Size(91, 41);
            this.cancelAddButton.TabIndex = 19;
            this.cancelAddButton.Text = "Cancel";
            this.cancelAddButton.UseVisualStyleBackColor = false;
            this.cancelAddButton.Click += new System.EventHandler(this.cancelAddButton_Click);
            // 
            // addCoursesDataTable
            // 
            this.addCoursesDataTable.AllowUserToAddRows = false;
            this.addCoursesDataTable.AllowUserToDeleteRows = false;
            this.addCoursesDataTable.AllowUserToResizeRows = false;
            this.addCoursesDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.addCoursesDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addCoursesDataTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.addCoursesDataTable.Location = new System.Drawing.Point(53, 169);
            this.addCoursesDataTable.Name = "addCoursesDataTable";
            this.addCoursesDataTable.ReadOnly = true;
            this.addCoursesDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.addCoursesDataTable.Size = new System.Drawing.Size(682, 411);
            this.addCoursesDataTable.TabIndex = 20;
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.addCoursesDataTable);
            this.Controls.Add(this.cancelAddButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.InstructorFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CourseLevelFilter);
            this.Controls.Add(this.DepartmentFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CourseSelectionLabel);
            this.MinimumSize = new System.Drawing.Size(800, 650);
            this.Name = "AddCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Course";
            this.Load += new System.EventHandler(this.AddCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addCoursesDataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CourseSelectionLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DepartmentFilter;
        private System.Windows.Forms.ComboBox CourseLevelFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label InstructorFilter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelAddButton;
        private System.Windows.Forms.DataGridView addCoursesDataTable;
    }
}