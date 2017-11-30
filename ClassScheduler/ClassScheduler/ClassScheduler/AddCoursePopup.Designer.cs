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
            this.DepartmentFilterLabel = new System.Windows.Forms.Label();
            this.CourseLevelFilterLabel = new System.Windows.Forms.Label();
            this.InstructorFilterLabel = new System.Windows.Forms.Label();
            this.InstructorNameFilter = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelAddButton = new System.Windows.Forms.Button();
            this.addCoursesDataTable = new System.Windows.Forms.DataGridView();
            this.addCourseStateLabel = new System.Windows.Forms.Label();
            this.showingCoursesCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.addCoursesDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // CourseSelectionLabel
            // 
            this.CourseSelectionLabel.AutoSize = true;
            this.CourseSelectionLabel.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Italic);
            this.CourseSelectionLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.CourseSelectionLabel.Location = new System.Drawing.Point(61, 49);
            this.CourseSelectionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CourseSelectionLabel.Name = "CourseSelectionLabel";
            this.CourseSelectionLabel.Size = new System.Drawing.Size(397, 55);
            this.CourseSelectionLabel.TabIndex = 9;
            this.CourseSelectionLabel.Text = "Select a Course to Add...";
            this.CourseSelectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 15F, System.Drawing.FontStyle.Italic);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(64, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 42);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filters:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DepartmentFilter
            // 
            this.DepartmentFilter.BackColor = System.Drawing.SystemColors.Window;
            this.DepartmentFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepartmentFilter.Font = new System.Drawing.Font("Sitka Heading", 10F);
            this.DepartmentFilter.FormattingEnabled = true;
            this.DepartmentFilter.Location = new System.Drawing.Point(160, 137);
            this.DepartmentFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DepartmentFilter.Name = "DepartmentFilter";
            this.DepartmentFilter.Size = new System.Drawing.Size(171, 36);
            this.DepartmentFilter.TabIndex = 11;
            this.DepartmentFilter.SelectedIndexChanged += new System.EventHandler(this.DepartmentFilter_SelectedIndexChanged);
            // 
            // CourseLevelFilter
            // 
            this.CourseLevelFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CourseLevelFilter.Font = new System.Drawing.Font("Sitka Heading", 10F);
            this.CourseLevelFilter.FormattingEnabled = true;
            this.CourseLevelFilter.Location = new System.Drawing.Point(340, 137);
            this.CourseLevelFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CourseLevelFilter.Name = "CourseLevelFilter";
            this.CourseLevelFilter.Size = new System.Drawing.Size(123, 36);
            this.CourseLevelFilter.TabIndex = 12;
            this.CourseLevelFilter.SelectedIndexChanged += new System.EventHandler(this.CourseLevelFilter_SelectedIndexChanged);
            // 
            // DepartmentFilterLabel
            // 
            this.DepartmentFilterLabel.AutoSize = true;
            this.DepartmentFilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic);
            this.DepartmentFilterLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.DepartmentFilterLabel.Location = new System.Drawing.Point(156, 117);
            this.DepartmentFilterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DepartmentFilterLabel.Name = "DepartmentFilterLabel";
            this.DepartmentFilterLabel.Size = new System.Drawing.Size(89, 18);
            this.DepartmentFilterLabel.TabIndex = 13;
            this.DepartmentFilterLabel.Text = "Department:";
            this.DepartmentFilterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CourseLevelFilterLabel
            // 
            this.CourseLevelFilterLabel.AutoSize = true;
            this.CourseLevelFilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic);
            this.CourseLevelFilterLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.CourseLevelFilterLabel.Location = new System.Drawing.Point(336, 117);
            this.CourseLevelFilterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CourseLevelFilterLabel.Name = "CourseLevelFilterLabel";
            this.CourseLevelFilterLabel.Size = new System.Drawing.Size(99, 18);
            this.CourseLevelFilterLabel.TabIndex = 14;
            this.CourseLevelFilterLabel.Text = "Course Level:";
            this.CourseLevelFilterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // InstructorFilterLabel
            // 
            this.InstructorFilterLabel.AutoSize = true;
            this.InstructorFilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic);
            this.InstructorFilterLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.InstructorFilterLabel.Location = new System.Drawing.Point(468, 117);
            this.InstructorFilterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InstructorFilterLabel.Name = "InstructorFilterLabel";
            this.InstructorFilterLabel.Size = new System.Drawing.Size(78, 18);
            this.InstructorFilterLabel.TabIndex = 15;
            this.InstructorFilterLabel.Text = "Instructor: ";
            this.InstructorFilterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // InstructorNameFilter
            // 
            this.InstructorNameFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InstructorNameFilter.Font = new System.Drawing.Font("Sitka Heading", 10F);
            this.InstructorNameFilter.FormattingEnabled = true;
            this.InstructorNameFilter.Location = new System.Drawing.Point(472, 137);
            this.InstructorNameFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InstructorNameFilter.Name = "InstructorNameFilter";
            this.InstructorNameFilter.Size = new System.Drawing.Size(275, 36);
            this.InstructorNameFilter.TabIndex = 16;
            this.InstructorNameFilter.SelectedIndexChanged += new System.EventHandler(this.InstructorNameFilter_SelectedIndexChanged);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Black;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(756, 127);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(95, 50);
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
            this.cancelAddButton.Location = new System.Drawing.Point(859, 127);
            this.cancelAddButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelAddButton.Name = "cancelAddButton";
            this.cancelAddButton.Size = new System.Drawing.Size(121, 50);
            this.cancelAddButton.TabIndex = 19;
            this.cancelAddButton.Text = "Close";
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
            this.addCoursesDataTable.Location = new System.Drawing.Point(71, 193);
            this.addCoursesDataTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addCoursesDataTable.MultiSelect = false;
            this.addCoursesDataTable.Name = "addCoursesDataTable";
            this.addCoursesDataTable.ReadOnly = true;
            this.addCoursesDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.addCoursesDataTable.Size = new System.Drawing.Size(909, 521);
            this.addCoursesDataTable.TabIndex = 20;
            this.addCoursesDataTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.addCoursesDataTable_CellClick);
            // 
            // addCourseStateLabel
            // 
            this.addCourseStateLabel.AutoSize = true;
            this.addCourseStateLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addCourseStateLabel.ForeColor = System.Drawing.Color.Green;
            this.addCourseStateLabel.Location = new System.Drawing.Point(67, 174);
            this.addCourseStateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addCourseStateLabel.Name = "addCourseStateLabel";
            this.addCourseStateLabel.Size = new System.Drawing.Size(108, 17);
            this.addCourseStateLabel.TabIndex = 21;
            this.addCourseStateLabel.Text = "Ready to Begin!";
            // 
            // showingCoursesCount
            // 
            this.showingCoursesCount.AutoSize = true;
            this.showingCoursesCount.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.showingCoursesCount.ForeColor = System.Drawing.Color.Gray;
            this.showingCoursesCount.Location = new System.Drawing.Point(879, 718);
            this.showingCoursesCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.showingCoursesCount.Name = "showingCoursesCount";
            this.showingCoursesCount.Size = new System.Drawing.Size(100, 17);
            this.showingCoursesCount.TabIndex = 22;
            this.showingCoursesCount.Text = "___ out of ___";
            this.showingCoursesCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1045, 752);
            this.Controls.Add(this.showingCoursesCount);
            this.Controls.Add(this.addCourseStateLabel);
            this.Controls.Add(this.addCoursesDataTable);
            this.Controls.Add(this.cancelAddButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.InstructorNameFilter);
            this.Controls.Add(this.InstructorFilterLabel);
            this.Controls.Add(this.CourseLevelFilterLabel);
            this.Controls.Add(this.DepartmentFilterLabel);
            this.Controls.Add(this.CourseLevelFilter);
            this.Controls.Add(this.DepartmentFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CourseSelectionLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1060, 788);
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
        private System.Windows.Forms.Label DepartmentFilterLabel;
        private System.Windows.Forms.Label CourseLevelFilterLabel;
        private System.Windows.Forms.Label InstructorFilterLabel;
        private System.Windows.Forms.ComboBox InstructorNameFilter;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelAddButton;
        private System.Windows.Forms.DataGridView addCoursesDataTable;
        private System.Windows.Forms.Label addCourseStateLabel;
        private System.Windows.Forms.Label showingCoursesCount;
    }
}