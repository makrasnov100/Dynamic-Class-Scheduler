namespace ClassScheduler
{
    partial class FinalSchedule
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
            this.filePictureBox = new System.Windows.Forms.PictureBox();
            this.scheduleLabel = new System.Windows.Forms.Label();
            this.studentScheduleLabel = new System.Windows.Forms.Label();
            this.schedulePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.filePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // filePictureBox
            // 
            this.filePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filePictureBox.Location = new System.Drawing.Point(12, 12);
            this.filePictureBox.Name = "filePictureBox";
            this.filePictureBox.Size = new System.Drawing.Size(673, 769);
            this.filePictureBox.TabIndex = 0;
            this.filePictureBox.TabStop = false;
            // 
            // scheduleLabel
            // 
            this.scheduleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scheduleLabel.AutoSize = true;
            this.scheduleLabel.Location = new System.Drawing.Point(506, 134);
            this.scheduleLabel.Name = "scheduleLabel";
            this.scheduleLabel.Size = new System.Drawing.Size(75, 17);
            this.scheduleLabel.TabIndex = 1;
            this.scheduleLabel.Text = "Schedule: ";
            // 
            // studentScheduleLabel
            // 
            this.studentScheduleLabel.AutoSize = true;
            this.studentScheduleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentScheduleLabel.Location = new System.Drawing.Point(45, 55);
            this.studentScheduleLabel.Name = "studentScheduleLabel";
            this.studentScheduleLabel.Size = new System.Drawing.Size(221, 25);
            this.studentScheduleLabel.TabIndex = 4;
            this.studentScheduleLabel.Text = "Student Schedule for ";
            // 
            // schedulePictureBox
            // 
            this.schedulePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.schedulePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.schedulePictureBox.Location = new System.Drawing.Point(50, 83);
            this.schedulePictureBox.Name = "schedulePictureBox";
            this.schedulePictureBox.Size = new System.Drawing.Size(423, 675);
            this.schedulePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.schedulePictureBox.TabIndex = 2;
            this.schedulePictureBox.TabStop = false;
            // 
            // FinalSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 793);
            this.Controls.Add(this.schedulePictureBox);
            this.Controls.Add(this.studentScheduleLabel);
            this.Controls.Add(this.scheduleLabel);
            this.Controls.Add(this.filePictureBox);
            this.Name = "FinalSchedule";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Schedule";
            ((System.ComponentModel.ISupportInitialize)(this.filePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox filePictureBox;
        private System.Windows.Forms.Label scheduleLabel;
        private System.Windows.Forms.Label studentScheduleLabel;
        private System.Windows.Forms.PictureBox schedulePictureBox;
    }
}