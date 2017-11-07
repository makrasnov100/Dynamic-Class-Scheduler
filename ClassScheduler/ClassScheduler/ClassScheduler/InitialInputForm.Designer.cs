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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.InitialInputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro", 16F);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(319, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(446, 379);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(158, 27);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find File";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Location = new System.Drawing.Point(39, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 150);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Minion Pro", 16F);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(323, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Minion Pro", 16F);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(369, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Term: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Minion Pro", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(359, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(540, 86);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dynamic Scheduler";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Minion Pro", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label5.Location = new System.Drawing.Point(316, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(312, 37);
            this.label5.TabIndex = 7;
            this.label5.Text = "Please Enter the Following...";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Minion Pro", 16F);
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(260, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 30);
            this.label6.TabIndex = 8;
            this.label6.Text = "Course Data Path: ";
            // 
            // InputToMainButton
            // 
            this.InputToMainButton.BackColor = System.Drawing.Color.Black;
            this.InputToMainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputToMainButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InputToMainButton.Location = new System.Drawing.Point(395, 456);
            this.InputToMainButton.Name = "InputToMainButton";
            this.InputToMainButton.Size = new System.Drawing.Size(209, 47);
            this.InputToMainButton.TabIndex = 9;
            this.InputToMainButton.Text = "Begin Course Selection";
            this.InputToMainButton.UseVisualStyleBackColor = false;
            this.InputToMainButton.Click += new System.EventHandler(this.InputToMainButton_Click);
            // 
            // PreviewExcelSheetButton
            // 
            this.PreviewExcelSheetButton.Location = new System.Drawing.Point(605, 379);
            this.PreviewExcelSheetButton.Name = "PreviewExcelSheetButton";
            this.PreviewExcelSheetButton.Size = new System.Drawing.Size(108, 27);
            this.PreviewExcelSheetButton.TabIndex = 10;
            this.PreviewExcelSheetButton.Text = "Preview";
            this.PreviewExcelSheetButton.UseVisualStyleBackColor = true;
            // 
            // TermComboBox
            // 
            this.TermComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TermComboBox.Font = new System.Drawing.Font("Minion Pro", 12F);
            this.TermComboBox.FormattingEnabled = true;
            this.TermComboBox.Items.AddRange(new object[] {
            "Fall",
            "January",
            "Spring"});
            this.TermComboBox.Location = new System.Drawing.Point(446, 336);
            this.TermComboBox.Name = "TermComboBox";
            this.TermComboBox.Size = new System.Drawing.Size(158, 30);
            this.TermComboBox.TabIndex = 11;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.FirstNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FirstNameTextBox.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTextBox.Location = new System.Drawing.Point(446, 257);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(158, 27);
            this.FirstNameTextBox.TabIndex = 12;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTextBox.Location = new System.Drawing.Point(446, 297);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(158, 27);
            this.LastNameTextBox.TabIndex = 13;
            // 
            // FirstNameNeedLabel
            // 
            this.FirstNameNeedLabel.AutoSize = true;
            this.FirstNameNeedLabel.ForeColor = System.Drawing.Color.Red;
            this.FirstNameNeedLabel.Location = new System.Drawing.Point(610, 265);
            this.FirstNameNeedLabel.Name = "FirstNameNeedLabel";
            this.FirstNameNeedLabel.Size = new System.Drawing.Size(103, 13);
            this.FirstNameNeedLabel.TabIndex = 14;
            this.FirstNameNeedLabel.Text = "This field is required.";
            // 
            // LastNameNeedLabel
            // 
            this.LastNameNeedLabel.AutoSize = true;
            this.LastNameNeedLabel.ForeColor = System.Drawing.Color.Red;
            this.LastNameNeedLabel.Location = new System.Drawing.Point(610, 305);
            this.LastNameNeedLabel.Name = "LastNameNeedLabel";
            this.LastNameNeedLabel.Size = new System.Drawing.Size(103, 13);
            this.LastNameNeedLabel.TabIndex = 15;
            this.LastNameNeedLabel.Text = "This field is required.";
            // 
            // TermNeedLabel
            // 
            this.TermNeedLabel.AutoSize = true;
            this.TermNeedLabel.ForeColor = System.Drawing.Color.Red;
            this.TermNeedLabel.Location = new System.Drawing.Point(610, 344);
            this.TermNeedLabel.Name = "TermNeedLabel";
            this.TermNeedLabel.Size = new System.Drawing.Size(103, 13);
            this.TermNeedLabel.TabIndex = 16;
            this.TermNeedLabel.Text = "This field is required.";
            // 
            // PreviewStatusLabel
            // 
            this.PreviewStatusLabel.AutoSize = true;
            this.PreviewStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.PreviewStatusLabel.Location = new System.Drawing.Point(719, 386);
            this.PreviewStatusLabel.Name = "PreviewStatusLabel";
            this.PreviewStatusLabel.Size = new System.Drawing.Size(87, 13);
            this.PreviewStatusLabel.TabIndex = 17;
            this.PreviewStatusLabel.Text = "File not selected.";
            // 
            // InitialInputPanel
            // 
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
            this.InitialInputPanel.Name = "InitialInputPanel";
            this.InitialInputPanel.Size = new System.Drawing.Size(985, 562);
            this.InitialInputPanel.TabIndex = 18;
            // 
            // InitialInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.InitialInputPanel);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "InitialInputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Input";
            this.Load += new System.EventHandler(this.InputWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.InitialInputPanel.ResumeLayout(false);
            this.InitialInputPanel.PerformLayout();
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
    }
}

