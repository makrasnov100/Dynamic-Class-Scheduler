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
            this.ScheduleSelectionLabel.Location = new System.Drawing.Point(15, 19);
            this.ScheduleSelectionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScheduleSelectionLabel.Name = "ScheduleSelectionLabel";
            this.ScheduleSelectionLabel.Size = new System.Drawing.Size(459, 49);
            this.ScheduleSelectionLabel.TabIndex = 9;
            this.ScheduleSelectionLabel.Text = "Choose Your Schedule Option...";
            this.ScheduleSelectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EfficiencyFitnessLabel
            // 
            this.EfficiencyFitnessLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EfficiencyFitnessLabel.AutoSize = true;
            this.EfficiencyFitnessLabel.ForeColor = System.Drawing.Color.Black;
            this.EfficiencyFitnessLabel.Location = new System.Drawing.Point(32, 706);
            this.EfficiencyFitnessLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EfficiencyFitnessLabel.Name = "EfficiencyFitnessLabel";
            this.EfficiencyFitnessLabel.Size = new System.Drawing.Size(121, 17);
            this.EfficiencyFitnessLabel.TabIndex = 16;
            this.EfficiencyFitnessLabel.Text = "Efficiency Fitness:";
            // 
            // OverlapFitnessLabel
            // 
            this.OverlapFitnessLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OverlapFitnessLabel.AutoSize = true;
            this.OverlapFitnessLabel.ForeColor = System.Drawing.Color.Black;
            this.OverlapFitnessLabel.Location = new System.Drawing.Point(42, 730);
            this.OverlapFitnessLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OverlapFitnessLabel.Name = "OverlapFitnessLabel";
            this.OverlapFitnessLabel.Size = new System.Drawing.Size(111, 17);
            this.OverlapFitnessLabel.TabIndex = 17;
            this.OverlapFitnessLabel.Text = "Overlap Fitness:";
            // 
            // SectionGraphBox
            // 
            this.SectionGraphBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionGraphBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SectionGraphBox.Location = new System.Drawing.Point(0, 0);
            this.SectionGraphBox.Name = "SectionGraphBox";
            this.SectionGraphBox.Size = new System.Drawing.Size(1126, 668);
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
            this.PrevScheduleButton.Location = new System.Drawing.Point(214, 703);
            this.PrevScheduleButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PrevScheduleButton.Name = "PrevScheduleButton";
            this.PrevScheduleButton.Size = new System.Drawing.Size(46, 50);
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
            this.NextScheduleButton.Location = new System.Drawing.Point(375, 703);
            this.NextScheduleButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NextScheduleButton.Name = "NextScheduleButton";
            this.NextScheduleButton.Size = new System.Drawing.Size(46, 50);
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
            this.SelectScheduleButton.Location = new System.Drawing.Point(268, 703);
            this.SelectScheduleButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectScheduleButton.Name = "SelectScheduleButton";
            this.SelectScheduleButton.Size = new System.Drawing.Size(99, 50);
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
            this.SuggestedCoursesButton.Location = new System.Drawing.Point(1291, 703);
            this.SuggestedCoursesButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SuggestedCoursesButton.Name = "SuggestedCoursesButton";
            this.SuggestedCoursesButton.Size = new System.Drawing.Size(241, 50);
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
            this.SuggestionScheduleLabel.Location = new System.Drawing.Point(450, 629);
            this.SuggestionScheduleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SuggestionScheduleLabel.Name = "SuggestionScheduleLabel";
            this.SuggestionScheduleLabel.Size = new System.Drawing.Size(0, 20);
            this.SuggestionScheduleLabel.TabIndex = 24;
            // 
            // ScheduleSuggestionLabel
            // 
            this.ScheduleSuggestionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ScheduleSuggestionLabel.AutoSize = true;
            this.ScheduleSuggestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.13333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScheduleSuggestionLabel.ForeColor = System.Drawing.Color.Black;
            this.ScheduleSuggestionLabel.Location = new System.Drawing.Point(958, 703);
            this.ScheduleSuggestionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScheduleSuggestionLabel.Name = "ScheduleSuggestionLabel";
            this.ScheduleSuggestionLabel.Size = new System.Drawing.Size(293, 40);
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
            this.CourseReselectionButton.Location = new System.Drawing.Point(1331, 19);
            this.CourseReselectionButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CourseReselectionButton.Name = "CourseReselectionButton";
            this.CourseReselectionButton.Size = new System.Drawing.Size(199, 50);
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
            this.ScheduleAmountLabel.Location = new System.Drawing.Point(1098, 27);
            this.ScheduleAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScheduleAmountLabel.Name = "ScheduleAmountLabel";
            this.ScheduleAmountLabel.Size = new System.Drawing.Size(136, 29);
            this.ScheduleAmountLabel.TabIndex = 27;
            this.ScheduleAmountLabel.Text = "Schedule 0 of 0\r\n";
            this.ScheduleAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ExampleSchedulePanel
            // 
            this.ExampleSchedulePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ExampleSchedulePanel.AutoScroll = true;
            this.ExampleSchedulePanel.AutoSize = true;
            this.ExampleSchedulePanel.Controls.Add(this.SectionGraphBox);
            this.ExampleSchedulePanel.Location = new System.Drawing.Point(0, 0);
            this.ExampleSchedulePanel.Name = "ExampleSchedulePanel";
            this.ExampleSchedulePanel.Size = new System.Drawing.Size(1502, 57);
            this.ExampleSchedulePanel.TabIndex = 28;
            // 
            // EffecFitLabel
            // 
            this.EffecFitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EffecFitLabel.AutoSize = true;
            this.EffecFitLabel.ForeColor = System.Drawing.Color.Green;
            this.EffecFitLabel.Location = new System.Drawing.Point(149, 706);
            this.EffecFitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EffecFitLabel.Name = "EffecFitLabel";
            this.EffecFitLabel.Size = new System.Drawing.Size(52, 17);
            this.EffecFitLabel.TabIndex = 29;
            this.EffecFitLabel.Text = "[BEST]";
            // 
            // OverlapFitLabel
            // 
            this.OverlapFitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OverlapFitLabel.AutoSize = true;
            this.OverlapFitLabel.ForeColor = System.Drawing.Color.Green;
            this.OverlapFitLabel.Location = new System.Drawing.Point(149, 730);
            this.OverlapFitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OverlapFitLabel.Name = "OverlapFitLabel";
            this.OverlapFitLabel.Size = new System.Drawing.Size(52, 17);
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
            this.LayoutPanel.Location = new System.Drawing.Point(28, 77);
            this.LayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LayoutPanel.Name = "LayoutPanel";
            this.LayoutPanel.Size = new System.Drawing.Size(1502, 611);
            this.LayoutPanel.TabIndex = 31;
            // 
            // LoadingResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1563, 755);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1113, 729);
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