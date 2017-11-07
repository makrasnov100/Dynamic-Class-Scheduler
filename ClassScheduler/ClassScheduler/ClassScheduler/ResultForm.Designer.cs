namespace ClassScheduler
{
    partial class ResultForm
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
            this.resultsToMainButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultsToMainButton
            // 
            this.resultsToMainButton.BackColor = System.Drawing.Color.Black;
            this.resultsToMainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.resultsToMainButton.ForeColor = System.Drawing.Color.White;
            this.resultsToMainButton.Location = new System.Drawing.Point(793, 482);
            this.resultsToMainButton.Name = "resultsToMainButton";
            this.resultsToMainButton.Size = new System.Drawing.Size(148, 46);
            this.resultsToMainButton.TabIndex = 0;
            this.resultsToMainButton.Text = "Edit Courses";
            this.resultsToMainButton.UseVisualStyleBackColor = false;
            this.resultsToMainButton.Click += new System.EventHandler(this.resultsToMainButton_Click);
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.resultsToMainButton);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule Results";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ResultForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button resultsToMainButton;
    }
}