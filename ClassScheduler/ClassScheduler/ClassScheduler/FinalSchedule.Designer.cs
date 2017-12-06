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
            this.studentScheduleLabel = new System.Windows.Forms.Label();
            this.schedulePictureBox = new System.Windows.Forms.PictureBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.scheduleTable = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.schedulePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // studentScheduleLabel
            // 
            this.studentScheduleLabel.AutoSize = true;
            this.studentScheduleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentScheduleLabel.Location = new System.Drawing.Point(24, 32);
            this.studentScheduleLabel.Name = "studentScheduleLabel";
            this.studentScheduleLabel.Size = new System.Drawing.Size(221, 25);
            this.studentScheduleLabel.TabIndex = 4;
            this.studentScheduleLabel.Text = "Student Schedule for ";
            // 
            // schedulePictureBox
            // 
            this.schedulePictureBox.Location = new System.Drawing.Point(29, 72);
            this.schedulePictureBox.Name = "schedulePictureBox";
            this.schedulePictureBox.Size = new System.Drawing.Size(936, 621);
            this.schedulePictureBox.TabIndex = 5;
            this.schedulePictureBox.TabStop = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // scheduleTable
            // 
            this.scheduleTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.scheduleTable.ColumnCount = 5;
            this.scheduleTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.scheduleTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.scheduleTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.scheduleTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.scheduleTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.scheduleTable.Location = new System.Drawing.Point(45, 86);
            this.scheduleTable.Name = "scheduleTable";
            this.scheduleTable.RowCount = 6;
            this.scheduleTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.scheduleTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.scheduleTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.scheduleTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.scheduleTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.scheduleTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.scheduleTable.Size = new System.Drawing.Size(906, 595);
            this.scheduleTable.TabIndex = 6;
            // 
            // FinalSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 729);
            this.Controls.Add(this.scheduleTable);
            this.Controls.Add(this.schedulePictureBox);
            this.Controls.Add(this.studentScheduleLabel);
            this.Name = "FinalSchedule";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Schedule";
            ((System.ComponentModel.ISupportInitialize)(this.schedulePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label studentScheduleLabel;
        private System.Windows.Forms.PictureBox schedulePictureBox;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.TableLayoutPanel scheduleTable;
    }
}