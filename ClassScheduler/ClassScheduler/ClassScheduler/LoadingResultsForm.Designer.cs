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
            this.EfficiencyFitnessLabel = new System.Windows.Forms.Label();
            this.OverlapFitnessLabel = new System.Windows.Forms.Label();
            this.SectionGraphBox = new System.Windows.Forms.PictureBox();
            this.PrevScheduleButton = new System.Windows.Forms.Button();
            this.NextScheduleButton = new System.Windows.Forms.Button();
            this.SelectScheduleButton = new System.Windows.Forms.Button();
            this.SuggestedCoursesButton = new System.Windows.Forms.Button();
            this.SuggestionScheduleLabel = new System.Windows.Forms.Label();
            this.ScheduleSuggestionLabel = new System.Windows.Forms.Label();
            this.CourseReselectionButton = new System.Windows.Forms.Button();
            this.ScheduleAmountLabel = new System.Windows.Forms.Label();
            this.ExampleSchedulePanel = new System.Windows.Forms.Panel();
            this.EffecFitLabel = new System.Windows.Forms.Label();
            this.OverlapFitLabel = new System.Windows.Forms.Label();
            this.LayoutPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.SectionGraphBox)).BeginInit();
            this.ExampleSchedulePanel.SuspendLayout();
            this.LayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScheduleSelectionLabel
            // 
            this.ScheduleSelectionLabel.AutoSize = true;
            this.ScheduleSelectionLabel.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Italic);
            this.ScheduleSelectionLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ScheduleSelectionLabel.Location = new System.Drawing.Point(17, 24);
            this.ScheduleSelectionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScheduleSelectionLabel.Name = "ScheduleSelectionLabel";
            this.ScheduleSelectionLabel.Size = new System.Drawing.Size(544, 59);
            this.ScheduleSelectionLabel.TabIndex = 9;
            this.ScheduleSelectionLabel.Text = "Choose Your Schedule Option...";
            this.ScheduleSelectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EfficiencyFitnessLabel
            // 
            this.EfficiencyFitnessLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EfficiencyFitnessLabel.AutoSize = true;
            this.EfficiencyFitnessLabel.ForeColor = System.Drawing.Color.Black;
            this.EfficiencyFitnessLabel.Location = new System.Drawing.Point(36, 883);
            this.EfficiencyFitnessLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EfficiencyFitnessLabel.Name = "EfficiencyFitnessLabel";
            this.EfficiencyFitnessLabel.Size = new System.Drawing.Size(137, 20);
            this.EfficiencyFitnessLabel.TabIndex = 16;
            this.EfficiencyFitnessLabel.Text = "Efficiency Fitness:";
            // 
            // OverlapFitnessLabel
            // 
            this.OverlapFitnessLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OverlapFitnessLabel.AutoSize = true;
            this.OverlapFitnessLabel.ForeColor = System.Drawing.Color.Black;
            this.OverlapFitnessLabel.Location = new System.Drawing.Point(47, 912);
            this.OverlapFitnessLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OverlapFitnessLabel.Name = "OverlapFitnessLabel";
            this.OverlapFitnessLabel.Size = new System.Drawing.Size(123, 20);
            this.OverlapFitnessLabel.TabIndex = 17;
            this.OverlapFitnessLabel.Text = "Overlap Fitness:";
            // 
            // SectionGraphBox
            // 
            this.SectionGraphBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SectionGraphBox.Location = new System.Drawing.Point(0, 0);
            this.SectionGraphBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SectionGraphBox.Name = "SectionGraphBox";
            this.SectionGraphBox.Size = new System.Drawing.Size(1105, 668);
            this.SectionGraphBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.SectionGraphBox.TabIndex = 19;
            this.SectionGraphBox.TabStop = false;
            // 
            // PrevScheduleButton
            // 
            this.PrevScheduleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PrevScheduleButton.BackColor = System.Drawing.Color.Black;
            this.PrevScheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PrevScheduleButton.ForeColor = System.Drawing.Color.White;
            this.PrevScheduleButton.Location = new System.Drawing.Point(241, 879);
            this.PrevScheduleButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PrevScheduleButton.Name = "PrevScheduleButton";
            this.PrevScheduleButton.Size = new System.Drawing.Size(52, 62);
            this.PrevScheduleButton.TabIndex = 20;
            this.PrevScheduleButton.Text = "<";
            this.PrevScheduleButton.UseVisualStyleBackColor = false;
            this.PrevScheduleButton.Click += new System.EventHandler(this.PrevScheduleButton_Click);
            // 
            // NextScheduleButton
            // 
            this.NextScheduleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NextScheduleButton.BackColor = System.Drawing.Color.Black;
            this.NextScheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NextScheduleButton.ForeColor = System.Drawing.Color.White;
            this.NextScheduleButton.Location = new System.Drawing.Point(422, 879);
            this.NextScheduleButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NextScheduleButton.Name = "NextScheduleButton";
            this.NextScheduleButton.Size = new System.Drawing.Size(52, 62);
            this.NextScheduleButton.TabIndex = 21;
            this.NextScheduleButton.Text = ">";
            this.NextScheduleButton.UseVisualStyleBackColor = false;
            this.NextScheduleButton.Click += new System.EventHandler(this.NextScheduleButton_Click);
            // 
            // SelectScheduleButton
            // 
            this.SelectScheduleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectScheduleButton.BackColor = System.Drawing.Color.Black;
            this.SelectScheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SelectScheduleButton.ForeColor = System.Drawing.Color.White;
            this.SelectScheduleButton.Location = new System.Drawing.Point(302, 879);
            this.SelectScheduleButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SelectScheduleButton.Name = "SelectScheduleButton";
            this.SelectScheduleButton.Size = new System.Drawing.Size(111, 62);
            this.SelectScheduleButton.TabIndex = 22;
            this.SelectScheduleButton.Text = "Select";
            this.SelectScheduleButton.UseVisualStyleBackColor = false;
            this.SelectScheduleButton.Click += new System.EventHandler(this.SelectScheduleButton_Click);
            // 
            // SuggestedCoursesButton
            // 
            this.SuggestedCoursesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SuggestedCoursesButton.BackColor = System.Drawing.Color.ForestGreen;
            this.SuggestedCoursesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SuggestedCoursesButton.ForeColor = System.Drawing.Color.Black;
            this.SuggestedCoursesButton.Location = new System.Drawing.Point(1452, 879);
            this.SuggestedCoursesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SuggestedCoursesButton.Name = "SuggestedCoursesButton";
            this.SuggestedCoursesButton.Size = new System.Drawing.Size(271, 62);
            this.SuggestedCoursesButton.TabIndex = 23;
            this.SuggestedCoursesButton.Text = "Optimize Schedule";
            this.SuggestedCoursesButton.UseVisualStyleBackColor = false;
            this.SuggestedCoursesButton.Click += new System.EventHandler(this.SuggestedCoursesButton_Click);
            // 
            // SuggestionScheduleLabel
            // 
            this.SuggestionScheduleLabel.AutoSize = true;
            this.SuggestionScheduleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SuggestionScheduleLabel.ForeColor = System.Drawing.Color.Black;
            this.SuggestionScheduleLabel.Location = new System.Drawing.Point(506, 786);
            this.SuggestionScheduleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SuggestionScheduleLabel.Name = "SuggestionScheduleLabel";
            this.SuggestionScheduleLabel.Size = new System.Drawing.Size(0, 25);
            this.SuggestionScheduleLabel.TabIndex = 24;
            // 
            // ScheduleSuggestionLabel
            // 
            this.ScheduleSuggestionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ScheduleSuggestionLabel.AutoSize = true;
            this.ScheduleSuggestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.13333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScheduleSuggestionLabel.ForeColor = System.Drawing.Color.Black;
            this.ScheduleSuggestionLabel.Location = new System.Drawing.Point(1078, 879);
            this.ScheduleSuggestionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScheduleSuggestionLabel.Name = "ScheduleSuggestionLabel";
            this.ScheduleSuggestionLabel.Size = new System.Drawing.Size(372, 50);
            this.ScheduleSuggestionLabel.TabIndex = 25;
            this.ScheduleSuggestionLabel.Text = "Optimize to shorten time at school by \r\nchoosing from similar courses!";
            this.ScheduleSuggestionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CourseReselectionButton
            // 
            this.CourseReselectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CourseReselectionButton.BackColor = System.Drawing.Color.Black;
            this.CourseReselectionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.CourseReselectionButton.ForeColor = System.Drawing.Color.White;
            this.CourseReselectionButton.Location = new System.Drawing.Point(1497, 24);
            this.CourseReselectionButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CourseReselectionButton.Name = "CourseReselectionButton";
            this.CourseReselectionButton.Size = new System.Drawing.Size(224, 62);
            this.CourseReselectionButton.TabIndex = 26;
            this.CourseReselectionButton.Text = "Reselect Courses";
            this.CourseReselectionButton.UseVisualStyleBackColor = false;
            this.CourseReselectionButton.Click += new System.EventHandler(this.CourseReselectionButton_Click);
            // 
            // ScheduleAmountLabel
            // 
            this.ScheduleAmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ScheduleAmountLabel.AutoSize = true;
            this.ScheduleAmountLabel.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Italic);
            this.ScheduleAmountLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ScheduleAmountLabel.Location = new System.Drawing.Point(1235, 34);
            this.ScheduleAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScheduleAmountLabel.Name = "ScheduleAmountLabel";
            this.ScheduleAmountLabel.Size = new System.Drawing.Size(163, 35);
            this.ScheduleAmountLabel.TabIndex = 27;
            this.ScheduleAmountLabel.Text = "Schedule 0 of 0\r\n";
            this.ScheduleAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ExampleSchedulePanel
            // 
            this.ExampleSchedulePanel.AutoScroll = true;
            this.ExampleSchedulePanel.AutoSize = true;
            this.ExampleSchedulePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExampleSchedulePanel.Controls.Add(this.SectionGraphBox);
            this.ExampleSchedulePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExampleSchedulePanel.Location = new System.Drawing.Point(0, 0);
            this.ExampleSchedulePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ExampleSchedulePanel.Name = "ExampleSchedulePanel";
            this.ExampleSchedulePanel.Size = new System.Drawing.Size(1690, 764);
            this.ExampleSchedulePanel.TabIndex = 28;
            // 
            // EffecFitLabel
            // 
            this.EffecFitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EffecFitLabel.AutoSize = true;
            this.EffecFitLabel.ForeColor = System.Drawing.Color.Green;
            this.EffecFitLabel.Location = new System.Drawing.Point(168, 883);
            this.EffecFitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EffecFitLabel.Name = "EffecFitLabel";
            this.EffecFitLabel.Size = new System.Drawing.Size(59, 20);
            this.EffecFitLabel.TabIndex = 29;
            this.EffecFitLabel.Text = "[BEST]";
            // 
            // OverlapFitLabel
            // 
            this.OverlapFitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OverlapFitLabel.AutoSize = true;
            this.OverlapFitLabel.ForeColor = System.Drawing.Color.Green;
            this.OverlapFitLabel.Location = new System.Drawing.Point(168, 912);
            this.OverlapFitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OverlapFitLabel.Name = "OverlapFitLabel";
            this.OverlapFitLabel.Size = new System.Drawing.Size(59, 20);
            this.OverlapFitLabel.TabIndex = 30;
            this.OverlapFitLabel.Text = "[BEST]";
            // 
            // LayoutPanel
            // 
            this.LayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LayoutPanel.Controls.Add(this.ExampleSchedulePanel);
            this.LayoutPanel.Location = new System.Drawing.Point(31, 96);
            this.LayoutPanel.Name = "LayoutPanel";
            this.LayoutPanel.Size = new System.Drawing.Size(1690, 764);
            this.LayoutPanel.TabIndex = 31;
            // 
            // LoadingResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1758, 944);
            this.Controls.Add(this.OverlapFitLabel);
            this.Controls.Add(this.EffecFitLabel);
            this.Controls.Add(this.ScheduleAmountLabel);
            this.Controls.Add(this.CourseReselectionButton);
            this.Controls.Add(this.ScheduleSuggestionLabel);
            this.Controls.Add(this.SuggestionScheduleLabel);
            this.Controls.Add(this.SuggestedCoursesButton);
            this.Controls.Add(this.SelectScheduleButton);
            this.Controls.Add(this.NextScheduleButton);
            this.Controls.Add(this.PrevScheduleButton);
            this.Controls.Add(this.OverlapFitnessLabel);
            this.Controls.Add(this.EfficiencyFitnessLabel);
            this.Controls.Add(this.ScheduleSelectionLabel);
            this.Controls.Add(this.LayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1780, 2160);
            this.MinimumSize = new System.Drawing.Size(1250, 900);
            this.Name = "LoadingResultsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule Layout Select";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoadingResultsForm_FormClosed);
            this.Load += new System.EventHandler(this.LoadingResultsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SectionGraphBox)).EndInit();
            this.ExampleSchedulePanel.ResumeLayout(false);
            this.ExampleSchedulePanel.PerformLayout();
            this.LayoutPanel.ResumeLayout(false);
            this.LayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScheduleSelectionLabel;
        private System.Windows.Forms.Label EfficiencyFitnessLabel;
        private System.Windows.Forms.Label OverlapFitnessLabel;
        private System.Windows.Forms.PictureBox SectionGraphBox;
        private System.Windows.Forms.Button PrevScheduleButton;
        private System.Windows.Forms.Button NextScheduleButton;
        private System.Windows.Forms.Button SelectScheduleButton;
        private System.Windows.Forms.Button SuggestedCoursesButton;
        private System.Windows.Forms.Label SuggestionScheduleLabel;
        private System.Windows.Forms.Label ScheduleSuggestionLabel;
        private System.Windows.Forms.Button CourseReselectionButton;
        private System.Windows.Forms.Label ScheduleAmountLabel;
        private System.Windows.Forms.Panel ExampleSchedulePanel;
        private System.Windows.Forms.Label EffecFitLabel;
        private System.Windows.Forms.Label OverlapFitLabel;
        private System.Windows.Forms.Panel LayoutPanel;
    }
}