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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.resultsToMainButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timesDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timesDataGridView)).BeginInit();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.timesDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(88, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(646, 436);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select course times";
            // 
            // timesDataGridView
            // 
            this.timesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.timesDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.timesDataGridView.Location = new System.Drawing.Point(24, 33);
            this.timesDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.timesDataGridView.MultiSelect = false;
            this.timesDataGridView.Name = "timesDataGridView";
            this.timesDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.timesDataGridView.RowTemplate.Height = 24;
            this.timesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.timesDataGridView.Size = new System.Drawing.Size(590, 364);
            this.timesDataGridView.TabIndex = 0;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resultsToMainButton);
            this.MinimumSize = new System.Drawing.Size(999, 599);
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule Results";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ResultForm_FormClosed);
            this.Load += new System.EventHandler(this.ResultForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button resultsToMainButton;
        public System.Windows.Forms.DataGridView timesDataGridView;
        public System.Windows.Forms.GroupBox groupBox1;
    }
}