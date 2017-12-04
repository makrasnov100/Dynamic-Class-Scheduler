namespace ClassScheduler
{
    partial class BasicCalculationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasicCalculationForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TotalAmountLabel = new System.Windows.Forms.Label();
            this.CurrentAmountLabel = new System.Windows.Forms.Label();
            this.PercentCompleteLabel = new System.Windows.Forms.Label();
            this.BackgroundWorkerSchedules = new System.ComponentModel.BackgroundWorker();
            this.LoadingTypeLabel = new System.Windows.Forms.Label();
            this.ProgressBarSchedules = new System.Windows.Forms.ProgressBar();
            this.CancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Location = new System.Drawing.Point(29, 29);
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
            this.label4.Location = new System.Drawing.Point(511, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(816, 139);
            this.label4.TabIndex = 23;
            this.label4.Text = "Dynamic Scheduler";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.CancelBtn);
            this.panel2.Controls.Add(this.ProgressBarSchedules);
            this.panel2.Controls.Add(this.LoadingTypeLabel);
            this.panel2.Controls.Add(this.TotalAmountLabel);
            this.panel2.Controls.Add(this.CurrentAmountLabel);
            this.panel2.Controls.Add(this.PercentCompleteLabel);
            this.panel2.Location = new System.Drawing.Point(-2, 292);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1484, 562);
            this.panel2.TabIndex = 21;
            // 
            // TotalAmountLabel
            // 
            this.TotalAmountLabel.AutoSize = true;
            this.TotalAmountLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.TotalAmountLabel.Location = new System.Drawing.Point(960, 315);
            this.TotalAmountLabel.Name = "TotalAmountLabel";
            this.TotalAmountLabel.Size = new System.Drawing.Size(73, 29);
            this.TotalAmountLabel.TabIndex = 2;
            this.TotalAmountLabel.Text = "Total: ";
            // 
            // CurrentAmountLabel
            // 
            this.CurrentAmountLabel.AutoSize = true;
            this.CurrentAmountLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.CurrentAmountLabel.Location = new System.Drawing.Point(310, 318);
            this.CurrentAmountLabel.Name = "CurrentAmountLabel";
            this.CurrentAmountLabel.Size = new System.Drawing.Size(99, 29);
            this.CurrentAmountLabel.TabIndex = 1;
            this.CurrentAmountLabel.Text = "Current: ";
            // 
            // PercentCompleteLabel
            // 
            this.PercentCompleteLabel.AutoSize = true;
            this.PercentCompleteLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.PercentCompleteLabel.Location = new System.Drawing.Point(614, 318);
            this.PercentCompleteLabel.Name = "PercentCompleteLabel";
            this.PercentCompleteLabel.Size = new System.Drawing.Size(106, 29);
            this.PercentCompleteLabel.TabIndex = 0;
            this.PercentCompleteLabel.Text = "Progress: ";
            // 
            // BackgroundWorkerSchedules
            // 
            this.BackgroundWorkerSchedules.WorkerReportsProgress = true;
            this.BackgroundWorkerSchedules.WorkerSupportsCancellation = true;
            this.BackgroundWorkerSchedules.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerSchedules_DoWork);
            this.BackgroundWorkerSchedules.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorkerSchedules_ProgressChanged);
            this.BackgroundWorkerSchedules.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorkerSchedules_RunWorkerCompleted);
            // 
            // LoadingTypeLabel
            // 
            this.LoadingTypeLabel.AutoSize = true;
            this.LoadingTypeLabel.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Bold);
            this.LoadingTypeLabel.ForeColor = System.Drawing.Color.Black;
            this.LoadingTypeLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.LoadingTypeLabel.Location = new System.Drawing.Point(388, 195);
            this.LoadingTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoadingTypeLabel.Name = "LoadingTypeLabel";
            this.LoadingTypeLabel.Size = new System.Drawing.Size(698, 61);
            this.LoadingTypeLabel.TabIndex = 19;
            this.LoadingTypeLabel.Text = "Creating Schedule Combinations";
            this.LoadingTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProgressBarSchedules
            // 
            this.ProgressBarSchedules.Location = new System.Drawing.Point(308, 261);
            this.ProgressBarSchedules.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProgressBarSchedules.Name = "ProgressBarSchedules";
            this.ProgressBarSchedules.Size = new System.Drawing.Size(843, 49);
            this.ProgressBarSchedules.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBarSchedules.TabIndex = 20;
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.Black;
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(1159, 261);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(130, 51);
            this.CancelBtn.TabIndex = 21;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // BasicCalculationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1478, 844);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(1500, 900);
            this.Name = "BasicCalculationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculating Schedules...";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BasicCalculationForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.ComponentModel.BackgroundWorker BackgroundWorkerSchedules;
        private System.Windows.Forms.Label PercentCompleteLabel;
        private System.Windows.Forms.Label TotalAmountLabel;
        private System.Windows.Forms.Label CurrentAmountLabel;
        private System.Windows.Forms.Label LoadingTypeLabel;
        private System.Windows.Forms.ProgressBar ProgressBarSchedules;
        private System.Windows.Forms.Button CancelBtn;
    }
}