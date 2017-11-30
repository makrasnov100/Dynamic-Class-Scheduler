namespace ClassScheduler
{
    partial class OptimizationSettingsForm
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
            this.ScheduleSelectionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectScheduleButton = new System.Windows.Forms.Button();
            this.GoBackToScheduleSelectionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ScheduleSelectionLabel
            // 
            this.ScheduleSelectionLabel.AutoSize = true;
            this.ScheduleSelectionLabel.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Italic);
            this.ScheduleSelectionLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ScheduleSelectionLabel.Location = new System.Drawing.Point(13, 25);
            this.ScheduleSelectionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScheduleSelectionLabel.Name = "ScheduleSelectionLabel";
            this.ScheduleSelectionLabel.Size = new System.Drawing.Size(522, 55);
            this.ScheduleSelectionLabel.TabIndex = 10;
            this.ScheduleSelectionLabel.Text = "Indicate your required courses...";
            this.ScheduleSelectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 14F, System.Drawing.FontStyle.Italic);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(64, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(538, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "Please check any courses that you need to keep:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SelectScheduleButton
            // 
            this.SelectScheduleButton.BackColor = System.Drawing.Color.Black;
            this.SelectScheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SelectScheduleButton.ForeColor = System.Drawing.Color.White;
            this.SelectScheduleButton.Location = new System.Drawing.Point(503, 478);
            this.SelectScheduleButton.Margin = new System.Windows.Forms.Padding(4);
            this.SelectScheduleButton.Name = "SelectScheduleButton";
            this.SelectScheduleButton.Size = new System.Drawing.Size(99, 50);
            this.SelectScheduleButton.TabIndex = 23;
            this.SelectScheduleButton.Text = "Done";
            this.SelectScheduleButton.UseVisualStyleBackColor = false;
            this.SelectScheduleButton.Click += new System.EventHandler(this.SelectScheduleButton_Click);
            // 
            // GoBackToScheduleSelectionButton
            // 
            this.GoBackToScheduleSelectionButton.BackColor = System.Drawing.Color.Black;
            this.GoBackToScheduleSelectionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.GoBackToScheduleSelectionButton.ForeColor = System.Drawing.Color.White;
            this.GoBackToScheduleSelectionButton.Location = new System.Drawing.Point(381, 478);
            this.GoBackToScheduleSelectionButton.Margin = new System.Windows.Forms.Padding(4);
            this.GoBackToScheduleSelectionButton.Name = "GoBackToScheduleSelectionButton";
            this.GoBackToScheduleSelectionButton.Size = new System.Drawing.Size(99, 50);
            this.GoBackToScheduleSelectionButton.TabIndex = 24;
            this.GoBackToScheduleSelectionButton.Text = "Back";
            this.GoBackToScheduleSelectionButton.UseVisualStyleBackColor = false;
            this.GoBackToScheduleSelectionButton.Click += new System.EventHandler(this.GoBackToScheduleSelectionButton_Click);
            // 
            // OptimizationSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 548);
            this.Controls.Add(this.GoBackToScheduleSelectionButton);
            this.Controls.Add(this.SelectScheduleButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ScheduleSelectionLabel);
            this.Name = "OptimizationSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Optimization Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScheduleSelectionLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SelectScheduleButton;
        private System.Windows.Forms.Button GoBackToScheduleSelectionButton;
    }
}