namespace ClassScheduler
{
    partial class LoadingResultsForm
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
            this.GenerationLabel = new System.Windows.Forms.Label();
            this.EfficiencyFitnessLabel = new System.Windows.Forms.Label();
            this.OverlapFitnessLabel = new System.Windows.Forms.Label();
            this.TotalFitnessLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ScheduleSelectionLabel
            // 
            this.ScheduleSelectionLabel.AutoSize = true;
            this.ScheduleSelectionLabel.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Italic);
            this.ScheduleSelectionLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ScheduleSelectionLabel.Location = new System.Drawing.Point(44, 30);
            this.ScheduleSelectionLabel.Name = "ScheduleSelectionLabel";
            this.ScheduleSelectionLabel.Size = new System.Drawing.Size(339, 39);
            this.ScheduleSelectionLabel.TabIndex = 9;
            this.ScheduleSelectionLabel.Text = "Optimal Schedule Calculation";
            this.ScheduleSelectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GenerationLabel
            // 
            this.GenerationLabel.AutoSize = true;
            this.GenerationLabel.ForeColor = System.Drawing.Color.Red;
            this.GenerationLabel.Location = new System.Drawing.Point(84, 516);
            this.GenerationLabel.Name = "GenerationLabel";
            this.GenerationLabel.Size = new System.Drawing.Size(62, 13);
            this.GenerationLabel.TabIndex = 15;
            this.GenerationLabel.Text = "Generation:";
            // 
            // EfficiencyFitnessLabel
            // 
            this.EfficiencyFitnessLabel.AutoSize = true;
            this.EfficiencyFitnessLabel.ForeColor = System.Drawing.Color.Red;
            this.EfficiencyFitnessLabel.Location = new System.Drawing.Point(314, 516);
            this.EfficiencyFitnessLabel.Name = "EfficiencyFitnessLabel";
            this.EfficiencyFitnessLabel.Size = new System.Drawing.Size(92, 13);
            this.EfficiencyFitnessLabel.TabIndex = 16;
            this.EfficiencyFitnessLabel.Text = "Efficiency Fitness:";
            // 
            // OverlapFitnessLabel
            // 
            this.OverlapFitnessLabel.AutoSize = true;
            this.OverlapFitnessLabel.ForeColor = System.Drawing.Color.Red;
            this.OverlapFitnessLabel.Location = new System.Drawing.Point(436, 516);
            this.OverlapFitnessLabel.Name = "OverlapFitnessLabel";
            this.OverlapFitnessLabel.Size = new System.Drawing.Size(83, 13);
            this.OverlapFitnessLabel.TabIndex = 17;
            this.OverlapFitnessLabel.Text = "Overlap Fitness:";
            // 
            // TotalFitnessLabel
            // 
            this.TotalFitnessLabel.AutoSize = true;
            this.TotalFitnessLabel.ForeColor = System.Drawing.Color.Red;
            this.TotalFitnessLabel.Location = new System.Drawing.Point(586, 516);
            this.TotalFitnessLabel.Name = "TotalFitnessLabel";
            this.TotalFitnessLabel.Size = new System.Drawing.Size(70, 13);
            this.TotalFitnessLabel.TabIndex = 18;
            this.TotalFitnessLabel.Text = "Total Fitness:";
            // 
            // LoadingResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(735, 538);
            this.Controls.Add(this.TotalFitnessLabel);
            this.Controls.Add(this.OverlapFitnessLabel);
            this.Controls.Add(this.EfficiencyFitnessLabel);
            this.Controls.Add(this.GenerationLabel);
            this.Controls.Add(this.ScheduleSelectionLabel);
            this.Name = "LoadingResultsForm";
            this.Text = "Loading...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScheduleSelectionLabel;
        private System.Windows.Forms.Label GenerationLabel;
        private System.Windows.Forms.Label EfficiencyFitnessLabel;
        private System.Windows.Forms.Label OverlapFitnessLabel;
        private System.Windows.Forms.Label TotalFitnessLabel;
    }
}