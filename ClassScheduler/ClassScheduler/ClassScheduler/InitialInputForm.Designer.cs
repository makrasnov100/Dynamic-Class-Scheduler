namespace ClassScheduler
{
    partial class InitialInputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitialInputForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.InputToMainButton = new System.Windows.Forms.Button();
            this.PreviewExcelSheetButton = new System.Windows.Forms.Button();
            this.TermComboBox = new System.Windows.Forms.ComboBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameNeedLabel = new System.Windows.Forms.Label();
            this.LastNameNeedLabel = new System.Windows.Forms.Label();
            this.TermNeedLabel = new System.Windows.Forms.Label();
            this.PreviewStatusLabel = new System.Windows.Forms.Label();
            this.InitialInputPanel = new System.Windows.Forms.Panel();
            this.LoadingCoursesPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TotalAmountLabel = new System.Windows.Forms.Label();
            this.PercentCompleteLabel = new System.Windows.Forms.Label();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.CurrentAmountLabel = new System.Windows.Forms.Label();
            this.LoadingTypeLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackgroundWorkerCourses = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.InitialInputPanel.SuspendLayout();
            this.LoadingCoursesPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 16F);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(421, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Black;
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(616, 338);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(237, 51);
            this.btnFind.TabIndex = 15;
            this.btnFind.Text = "Find File";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Location = new System.Drawing.Point(26, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Font = new System.Drawing.Font("Sitka Heading", 16F);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(428, 212);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 47);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Font = new System.Drawing.Font("Sitka Heading", 16F);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(502, 274);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 47);
            this.label3.TabIndex = 5;
            this.label3.Text = "Term:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Heading", 48F, System.Drawing.FontStyle.Italic);
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(486, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(816, 139);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dynamic Scheduler";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Italic);
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label5.Location = new System.Drawing.Point(190, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(497, 59);
            this.label5.TabIndex = 7;
            this.label5.Text = "Please Enter the Following...";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gainsboro;
            this.label6.Font = new System.Drawing.Font("Sitka Heading", 16F);
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(334, 335);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 47);
            this.label6.TabIndex = 8;
            this.label6.Text = "Course Data Path:";
            // 
            // InputToMainButton
            // 
            this.InputToMainButton.BackColor = System.Drawing.Color.Black;
            this.InputToMainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputToMainButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InputToMainButton.Location = new System.Drawing.Point(616, 399);
            this.InputToMainButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InputToMainButton.Name = "InputToMainButton";
            this.InputToMainButton.Size = new System.Drawing.Size(408, 72);
            this.InputToMainButton.TabIndex = 17;
            this.InputToMainButton.Text = "Begin Course Selection";
            this.InputToMainButton.UseVisualStyleBackColor = false;
            this.InputToMainButton.Click += new System.EventHandler(this.InputToMainButton_Click);
            // 
            // PreviewExcelSheetButton
            // 
            this.PreviewExcelSheetButton.BackColor = System.Drawing.Color.Black;
            this.PreviewExcelSheetButton.ForeColor = System.Drawing.Color.White;
            this.PreviewExcelSheetButton.Location = new System.Drawing.Point(863, 338);
            this.PreviewExcelSheetButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PreviewExcelSheetButton.Name = "PreviewExcelSheetButton";
            this.PreviewExcelSheetButton.Size = new System.Drawing.Size(162, 51);
            this.PreviewExcelSheetButton.TabIndex = 16;
            this.PreviewExcelSheetButton.Text = "Preview";
            this.PreviewExcelSheetButton.UseVisualStyleBackColor = false;
            this.PreviewExcelSheetButton.Click += new System.EventHandler(this.PreviewExcelSheetButton_Click_1);
            // 
            // TermComboBox
            // 
            this.TermComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TermComboBox.Font = new System.Drawing.Font("Sitka Heading", 12F);
            this.TermComboBox.FormattingEnabled = true;
            this.TermComboBox.Items.AddRange(new object[] {
            "Fall",
            "January",
            "Spring"});
            this.TermComboBox.Location = new System.Drawing.Point(616, 276);
            this.TermComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TermComboBox.Name = "TermComboBox";
            this.TermComboBox.Size = new System.Drawing.Size(235, 43);
            this.TermComboBox.TabIndex = 14;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.FirstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FirstNameTextBox.Font = new System.Drawing.Font("Sitka Heading", 12F);
            this.FirstNameTextBox.Location = new System.Drawing.Point(616, 166);
            this.FirstNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(235, 38);
            this.FirstNameTextBox.TabIndex = 12;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastNameTextBox.Font = new System.Drawing.Font("Sitka Heading", 12F);
            this.LastNameTextBox.Location = new System.Drawing.Point(616, 221);
            this.LastNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(235, 38);
            this.LastNameTextBox.TabIndex = 13;
            // 
            // FirstNameNeedLabel
            // 
            this.FirstNameNeedLabel.AutoSize = true;
            this.FirstNameNeedLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.FirstNameNeedLabel.ForeColor = System.Drawing.Color.Red;
            this.FirstNameNeedLabel.Location = new System.Drawing.Point(867, 185);
            this.FirstNameNeedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstNameNeedLabel.Name = "FirstNameNeedLabel";
            this.FirstNameNeedLabel.Size = new System.Drawing.Size(152, 20);
            this.FirstNameNeedLabel.TabIndex = 14;
            this.FirstNameNeedLabel.Text = "This field is required.";
            // 
            // LastNameNeedLabel
            // 
            this.LastNameNeedLabel.AutoSize = true;
            this.LastNameNeedLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.LastNameNeedLabel.ForeColor = System.Drawing.Color.Red;
            this.LastNameNeedLabel.Location = new System.Drawing.Point(867, 239);
            this.LastNameNeedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastNameNeedLabel.Name = "LastNameNeedLabel";
            this.LastNameNeedLabel.Size = new System.Drawing.Size(152, 20);
            this.LastNameNeedLabel.TabIndex = 15;
            this.LastNameNeedLabel.Text = "This field is required.";
            // 
            // TermNeedLabel
            // 
            this.TermNeedLabel.AutoSize = true;
            this.TermNeedLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.TermNeedLabel.ForeColor = System.Drawing.Color.Red;
            this.TermNeedLabel.Location = new System.Drawing.Point(867, 296);
            this.TermNeedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TermNeedLabel.Name = "TermNeedLabel";
            this.TermNeedLabel.Size = new System.Drawing.Size(152, 20);
            this.TermNeedLabel.TabIndex = 16;
            this.TermNeedLabel.Text = "This field is required.";
            // 
            // PreviewStatusLabel
            // 
            this.PreviewStatusLabel.AutoSize = true;
            this.PreviewStatusLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.PreviewStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.PreviewStatusLabel.Location = new System.Drawing.Point(1034, 352);
            this.PreviewStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PreviewStatusLabel.Name = "PreviewStatusLabel";
            this.PreviewStatusLabel.Size = new System.Drawing.Size(129, 20);
            this.PreviewStatusLabel.TabIndex = 17;
            this.PreviewStatusLabel.Text = "File not selected.";
            // 
            // InitialInputPanel
            // 
            this.InitialInputPanel.Controls.Add(this.pictureBox1);
            this.InitialInputPanel.Controls.Add(this.label4);
            this.InitialInputPanel.Controls.Add(this.LoadingCoursesPanel);
            this.InitialInputPanel.Controls.Add(this.panel1);
            this.InitialInputPanel.Location = new System.Drawing.Point(-1, 0);
            this.InitialInputPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InitialInputPanel.Name = "InitialInputPanel";
            this.InitialInputPanel.Size = new System.Drawing.Size(1477, 865);
            this.InitialInputPanel.TabIndex = 18;
            // 
            // LoadingCoursesPanel
            // 
            this.LoadingCoursesPanel.Controls.Add(this.panel2);
            this.LoadingCoursesPanel.Location = new System.Drawing.Point(0, 0);
            this.LoadingCoursesPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoadingCoursesPanel.Name = "LoadingCoursesPanel";
            this.LoadingCoursesPanel.Size = new System.Drawing.Size(1477, 865);
            this.LoadingCoursesPanel.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.TotalAmountLabel);
            this.panel2.Controls.Add(this.PercentCompleteLabel);
            this.panel2.Controls.Add(this.ProgressBar);
            this.panel2.Controls.Add(this.CurrentAmountLabel);
            this.panel2.Controls.Add(this.LoadingTypeLabel);
            this.panel2.Location = new System.Drawing.Point(0, 294);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1477, 567);
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
            this.LoadingTypeLabel.Location = new System.Drawing.Point(465, 152);
            this.LoadingTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoadingTypeLabel.Name = "LoadingTypeLabel";
            this.LoadingTypeLabel.Size = new System.Drawing.Size(560, 61);
            this.LoadingTypeLabel.TabIndex = 18;
            this.LoadingTypeLabel.Text = "Creating Course Database";
            this.LoadingTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.PreviewStatusLabel);
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.TermNeedLabel);
            this.panel1.Controls.Add(this.PreviewExcelSheetButton);
            this.panel1.Controls.Add(this.LastNameNeedLabel);
            this.panel1.Controls.Add(this.InputToMainButton);
            this.panel1.Controls.Add(this.FirstNameNeedLabel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.FirstNameTextBox);
            this.panel1.Controls.Add(this.LastNameTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TermComboBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 294);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1477, 571);
            this.panel1.TabIndex = 21;
            // 
            // BackgroundWorkerCourses
            // 
            this.BackgroundWorkerCourses.WorkerReportsProgress = true;
            this.BackgroundWorkerCourses.WorkerSupportsCancellation = true;
            this.BackgroundWorkerCourses.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerCourses_DoWork);
            this.BackgroundWorkerCourses.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorkerCourses_ProgressChanged);
            this.BackgroundWorkerCourses.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorkerCourses_RunWorkerCompleted);
            // 
            // InitialInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1482, 862);
            this.Controls.Add(this.InitialInputPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1499, 897);
            this.Name = "InitialInputForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Input";
            this.Load += new System.EventHandler(this.InputWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.InitialInputPanel.ResumeLayout(false);
            this.InitialInputPanel.PerformLayout();
            this.LoadingCoursesPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button InputToMainButton;
        private System.Windows.Forms.Button PreviewExcelSheetButton;
        private System.Windows.Forms.ComboBox TermComboBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label FirstNameNeedLabel;
        private System.Windows.Forms.Label LastNameNeedLabel;
        private System.Windows.Forms.Label TermNeedLabel;
        private System.Windows.Forms.Label PreviewStatusLabel;
        private System.Windows.Forms.Panel InitialInputPanel;
        private System.Windows.Forms.Label LoadingTypeLabel;
        private System.Windows.Forms.Label CurrentAmountLabel;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Panel LoadingCoursesPanel;
        private System.Windows.Forms.Label PercentCompleteLabel;
        private System.Windows.Forms.Label TotalAmountLabel;
        private System.ComponentModel.BackgroundWorker BackgroundWorkerCourses;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

