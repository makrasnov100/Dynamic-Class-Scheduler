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
            this.PercentCompleteLabel = new System.Windows.Forms.Label();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.CurrentAmountLabel = new System.Windows.Forms.Label();
            this.LoadingTypeLabel = new System.Windows.Forms.Label();
            this.TotalAmountLabel = new System.Windows.Forms.Label();
            this.BackgroundWorkerCourses = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.InitialInputPanel.SuspendLayout();
            this.LoadingCoursesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 16F);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(429, 309);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(595, 460);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(211, 41);
            this.btnFind.TabIndex = 15;
            this.btnFind.Text = "Find File";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Location = new System.Drawing.Point(52, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Heading", 16F);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(436, 358);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 43);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Heading", 16F);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(499, 409);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 43);
            this.label3.TabIndex = 5;
            this.label3.Text = "Term:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Heading", 48F, System.Drawing.FontStyle.Italic);
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(479, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(763, 130);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dynamic Scheduler";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Italic);
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label5.Location = new System.Drawing.Point(421, 239);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(462, 55);
            this.label5.TabIndex = 7;
            this.label5.Text = "Please Enter the Following...";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Heading", 16F);
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(353, 460);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 43);
            this.label6.TabIndex = 8;
            this.label6.Text = "Course Data Path:";
            // 
            // InputToMainButton
            // 
            this.InputToMainButton.BackColor = System.Drawing.Color.Black;
            this.InputToMainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputToMainButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InputToMainButton.Location = new System.Drawing.Point(527, 561);
            this.InputToMainButton.Margin = new System.Windows.Forms.Padding(4);
            this.InputToMainButton.Name = "InputToMainButton";
            this.InputToMainButton.Size = new System.Drawing.Size(279, 58);
            this.InputToMainButton.TabIndex = 17;
            this.InputToMainButton.Text = "Begin Course Selection";
            this.InputToMainButton.UseVisualStyleBackColor = false;
            this.InputToMainButton.Click += new System.EventHandler(this.InputToMainButton_Click);
            // 
            // PreviewExcelSheetButton
            // 
            this.PreviewExcelSheetButton.Location = new System.Drawing.Point(807, 460);
            this.PreviewExcelSheetButton.Margin = new System.Windows.Forms.Padding(4);
            this.PreviewExcelSheetButton.Name = "PreviewExcelSheetButton";
            this.PreviewExcelSheetButton.Size = new System.Drawing.Size(144, 41);
            this.PreviewExcelSheetButton.TabIndex = 16;
            this.PreviewExcelSheetButton.Text = "Preview";
            this.PreviewExcelSheetButton.UseVisualStyleBackColor = true;
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
            this.TermComboBox.Location = new System.Drawing.Point(595, 414);
            this.TermComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.TermComboBox.Name = "TermComboBox";
            this.TermComboBox.Size = new System.Drawing.Size(209, 41);
            this.TermComboBox.TabIndex = 14;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.FirstNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FirstNameTextBox.Font = new System.Drawing.Font("Sitka Heading", 12F);
            this.FirstNameTextBox.Location = new System.Drawing.Point(595, 316);
            this.FirstNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(209, 36);
            this.FirstNameTextBox.TabIndex = 12;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Font = new System.Drawing.Font("Sitka Heading", 12F);
            this.LastNameTextBox.Location = new System.Drawing.Point(595, 366);
            this.LastNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(209, 36);
            this.LastNameTextBox.TabIndex = 13;
            // 
            // FirstNameNeedLabel
            // 
            this.FirstNameNeedLabel.AutoSize = true;
            this.FirstNameNeedLabel.ForeColor = System.Drawing.Color.Red;
            this.FirstNameNeedLabel.Location = new System.Drawing.Point(813, 326);
            this.FirstNameNeedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstNameNeedLabel.Name = "FirstNameNeedLabel";
            this.FirstNameNeedLabel.Size = new System.Drawing.Size(140, 17);
            this.FirstNameNeedLabel.TabIndex = 14;
            this.FirstNameNeedLabel.Text = "This field is required.";
            // 
            // LastNameNeedLabel
            // 
            this.LastNameNeedLabel.AutoSize = true;
            this.LastNameNeedLabel.ForeColor = System.Drawing.Color.Red;
            this.LastNameNeedLabel.Location = new System.Drawing.Point(813, 375);
            this.LastNameNeedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastNameNeedLabel.Name = "LastNameNeedLabel";
            this.LastNameNeedLabel.Size = new System.Drawing.Size(140, 17);
            this.LastNameNeedLabel.TabIndex = 15;
            this.LastNameNeedLabel.Text = "This field is required.";
            // 
            // TermNeedLabel
            // 
            this.TermNeedLabel.AutoSize = true;
            this.TermNeedLabel.ForeColor = System.Drawing.Color.Red;
            this.TermNeedLabel.Location = new System.Drawing.Point(813, 423);
            this.TermNeedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TermNeedLabel.Name = "TermNeedLabel";
            this.TermNeedLabel.Size = new System.Drawing.Size(140, 17);
            this.TermNeedLabel.TabIndex = 16;
            this.TermNeedLabel.Text = "This field is required.";
            // 
            // PreviewStatusLabel
            // 
            this.PreviewStatusLabel.AutoSize = true;
            this.PreviewStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.PreviewStatusLabel.Location = new System.Drawing.Point(959, 475);
            this.PreviewStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PreviewStatusLabel.Name = "PreviewStatusLabel";
            this.PreviewStatusLabel.Size = new System.Drawing.Size(115, 17);
            this.PreviewStatusLabel.TabIndex = 17;
            this.PreviewStatusLabel.Text = "File not selected.";
            // 
            // InitialInputPanel
            // 
            this.InitialInputPanel.Controls.Add(this.LoadingCoursesPanel);
            this.InitialInputPanel.Controls.Add(this.PreviewStatusLabel);
            this.InitialInputPanel.Controls.Add(this.TermNeedLabel);
            this.InitialInputPanel.Controls.Add(this.LastNameNeedLabel);
            this.InitialInputPanel.Controls.Add(this.FirstNameNeedLabel);
            this.InitialInputPanel.Controls.Add(this.LastNameTextBox);
            this.InitialInputPanel.Controls.Add(this.FirstNameTextBox);
            this.InitialInputPanel.Controls.Add(this.TermComboBox);
            this.InitialInputPanel.Controls.Add(this.PreviewExcelSheetButton);
            this.InitialInputPanel.Controls.Add(this.InputToMainButton);
            this.InitialInputPanel.Controls.Add(this.label6);
            this.InitialInputPanel.Controls.Add(this.label5);
            this.InitialInputPanel.Controls.Add(this.label4);
            this.InitialInputPanel.Controls.Add(this.label3);
            this.InitialInputPanel.Controls.Add(this.label2);
            this.InitialInputPanel.Controls.Add(this.pictureBox1);
            this.InitialInputPanel.Controls.Add(this.btnFind);
            this.InitialInputPanel.Controls.Add(this.label1);
            this.InitialInputPanel.Location = new System.Drawing.Point(-1, 0);
            this.InitialInputPanel.Margin = new System.Windows.Forms.Padding(4);
            this.InitialInputPanel.Name = "InitialInputPanel";
            this.InitialInputPanel.Size = new System.Drawing.Size(1313, 692);
            this.InitialInputPanel.TabIndex = 18;
            // 
            // LoadingCoursesPanel
            // 
            this.LoadingCoursesPanel.Controls.Add(this.TotalAmountLabel);
            this.LoadingCoursesPanel.Controls.Add(this.PercentCompleteLabel);
            this.LoadingCoursesPanel.Controls.Add(this.ProgressBar);
            this.LoadingCoursesPanel.Controls.Add(this.CurrentAmountLabel);
            this.LoadingCoursesPanel.Controls.Add(this.LoadingTypeLabel);
            this.LoadingCoursesPanel.Location = new System.Drawing.Point(0, 0);
            this.LoadingCoursesPanel.Name = "LoadingCoursesPanel";
            this.LoadingCoursesPanel.Size = new System.Drawing.Size(1313, 692);
            this.LoadingCoursesPanel.TabIndex = 19;
            // 
            // PercentCompleteLabel
            // 
            this.PercentCompleteLabel.AutoSize = true;
            this.PercentCompleteLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.PercentCompleteLabel.ForeColor = System.Drawing.Color.Black;
            this.PercentCompleteLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.PercentCompleteLabel.Location = new System.Drawing.Point(296, 358);
            this.PercentCompleteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PercentCompleteLabel.Name = "PercentCompleteLabel";
            this.PercentCompleteLabel.Size = new System.Drawing.Size(155, 28);
            this.PercentCompleteLabel.TabIndex = 19;
            this.PercentCompleteLabel.Text = "Progress: 100%";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(301, 309);
            this.ProgressBar.Margin = new System.Windows.Forms.Padding(4);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(749, 39);
            this.ProgressBar.TabIndex = 16;
            // 
            // CurrentAmountLabel
            // 
            this.CurrentAmountLabel.AutoSize = true;
            this.CurrentAmountLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.CurrentAmountLabel.ForeColor = System.Drawing.Color.Black;
            this.CurrentAmountLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.CurrentAmountLabel.Location = new System.Drawing.Point(872, 358);
            this.CurrentAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentAmountLabel.Name = "CurrentAmountLabel";
            this.CurrentAmountLabel.Size = new System.Drawing.Size(178, 28);
            this.CurrentAmountLabel.TabIndex = 17;
            this.CurrentAmountLabel.Text = "Current: 2342344";
            // 
            // LoadingTypeLabel
            // 
            this.LoadingTypeLabel.AutoSize = true;
            this.LoadingTypeLabel.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Bold);
            this.LoadingTypeLabel.ForeColor = System.Drawing.Color.Black;
            this.LoadingTypeLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.LoadingTypeLabel.Location = new System.Drawing.Point(491, 238);
            this.LoadingTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoadingTypeLabel.Name = "LoadingTypeLabel";
            this.LoadingTypeLabel.Size = new System.Drawing.Size(388, 58);
            this.LoadingTypeLabel.TabIndex = 18;
            this.LoadingTypeLabel.Text = "Course Calculation";
            this.LoadingTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalAmountLabel
            // 
            this.TotalAmountLabel.AutoSize = true;
            this.TotalAmountLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.TotalAmountLabel.ForeColor = System.Drawing.Color.Black;
            this.TotalAmountLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TotalAmountLabel.Location = new System.Drawing.Point(898, 386);
            this.TotalAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalAmountLabel.Name = "TotalAmountLabel";
            this.TotalAmountLabel.Size = new System.Drawing.Size(152, 28);
            this.TotalAmountLabel.TabIndex = 20;
            this.TotalAmountLabel.Text = "Total: 2342344\r\n";
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1312, 690);
            this.Controls.Add(this.InitialInputPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1327, 728);
            this.Name = "InitialInputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Input";
            this.Load += new System.EventHandler(this.InputWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.InitialInputPanel.ResumeLayout(false);
            this.InitialInputPanel.PerformLayout();
            this.LoadingCoursesPanel.ResumeLayout(false);
            this.LoadingCoursesPanel.PerformLayout();
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
    }
}

