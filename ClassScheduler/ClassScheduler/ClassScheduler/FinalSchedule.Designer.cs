﻿namespace ClassScheduler
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
            this.schedulePictureBox = new System.Windows.Forms.PictureBox();
            this.printDialogBox = new System.Windows.Forms.PrintDialog();
            this.schedulePanel = new System.Windows.Forms.Panel();
            this.dayLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.fridayLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.fridayLbl = new System.Windows.Forms.Label();
            this.wednesdayLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.wednesdayLbl = new System.Windows.Forms.Label();
            this.tuesdayLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tuesdayLbl = new System.Windows.Forms.Label();
            this.mondayLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.mondayLbl = new System.Windows.Forms.Label();
            this.thursdayLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.thursdayLbl = new System.Windows.Forms.Label();
            this.displayLbl = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.schedulePictureBox)).BeginInit();
            this.schedulePanel.SuspendLayout();
            this.dayLayoutPanel.SuspendLayout();
            this.fridayLayoutPanel.SuspendLayout();
            this.wednesdayLayoutPanel.SuspendLayout();
            this.tuesdayLayoutPanel.SuspendLayout();
            this.mondayLayoutPanel.SuspendLayout();
            this.thursdayLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // schedulePictureBox
            // 
            this.schedulePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulePictureBox.Location = new System.Drawing.Point(0, 0);
            this.schedulePictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.schedulePictureBox.MinimumSize = new System.Drawing.Size(1053, 776);
            this.schedulePictureBox.Name = "schedulePictureBox";
            this.schedulePictureBox.Size = new System.Drawing.Size(1053, 1342);
            this.schedulePictureBox.TabIndex = 5;
            this.schedulePictureBox.TabStop = false;
            // 
            // printDialogBox
            // 
            this.printDialogBox.UseEXDialog = true;
            // 
            // schedulePanel
            // 
            this.schedulePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.schedulePanel.Controls.Add(this.printButton);
            this.schedulePanel.Controls.Add(this.backButton);
            this.schedulePanel.Controls.Add(this.saveBtn);
            this.schedulePanel.Controls.Add(this.dayLayoutPanel);
            this.schedulePanel.Controls.Add(this.displayLbl);
            this.schedulePanel.Location = new System.Drawing.Point(0, 0);
            this.schedulePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.schedulePanel.MaximumSize = new System.Drawing.Size(934, 1342);
            this.schedulePanel.MinimumSize = new System.Drawing.Size(934, 1342);
            this.schedulePanel.Name = "schedulePanel";
            this.schedulePanel.Size = new System.Drawing.Size(934, 1342);
            this.schedulePanel.TabIndex = 6;
            // 
            // dayLayoutPanel
            // 
            this.dayLayoutPanel.AutoScroll = true;
            this.dayLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.dayLayoutPanel.ColumnCount = 1;
            this.dayLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dayLayoutPanel.Controls.Add(this.fridayLayoutPanel, 0, 4);
            this.dayLayoutPanel.Controls.Add(this.wednesdayLayoutPanel, 0, 2);
            this.dayLayoutPanel.Controls.Add(this.tuesdayLayoutPanel, 0, 1);
            this.dayLayoutPanel.Controls.Add(this.mondayLayoutPanel, 0, 0);
            this.dayLayoutPanel.Controls.Add(this.thursdayLayoutPanel, 0, 3);
            this.dayLayoutPanel.Location = new System.Drawing.Point(0, 84);
            this.dayLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dayLayoutPanel.Name = "dayLayoutPanel";
            this.dayLayoutPanel.RowCount = 5;
            this.dayLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.dayLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.dayLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.dayLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.dayLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.dayLayoutPanel.Size = new System.Drawing.Size(934, 1216);
            this.dayLayoutPanel.TabIndex = 1;
            // 
            // fridayLayoutPanel
            // 
            this.fridayLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.fridayLayoutPanel.ColumnCount = 1;
            this.fridayLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.fridayLayoutPanel.Controls.Add(this.fridayLbl, 0, 0);
            this.fridayLayoutPanel.Location = new System.Drawing.Point(4, 977);
            this.fridayLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fridayLayoutPanel.Name = "fridayLayoutPanel";
            this.fridayLayoutPanel.RowCount = 5;
            this.fridayLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.fridayLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.fridayLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.fridayLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.fridayLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.fridayLayoutPanel.Size = new System.Drawing.Size(925, 234);
            this.fridayLayoutPanel.TabIndex = 12;
            // 
            // fridayLbl
            // 
            this.fridayLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fridayLbl.AutoSize = true;
            this.fridayLbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fridayLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fridayLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fridayLbl.Location = new System.Drawing.Point(5, 2);
            this.fridayLbl.Name = "fridayLbl";
            this.fridayLbl.Size = new System.Drawing.Size(915, 44);
            this.fridayLbl.TabIndex = 1;
            this.fridayLbl.Text = "Friday";
            this.fridayLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wednesdayLayoutPanel
            // 
            this.wednesdayLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.wednesdayLayoutPanel.ColumnCount = 1;
            this.wednesdayLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.wednesdayLayoutPanel.Controls.Add(this.wednesdayLbl, 0, 0);
            this.wednesdayLayoutPanel.Location = new System.Drawing.Point(4, 491);
            this.wednesdayLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.wednesdayLayoutPanel.Name = "wednesdayLayoutPanel";
            this.wednesdayLayoutPanel.RowCount = 5;
            this.wednesdayLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.wednesdayLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.wednesdayLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.wednesdayLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.wednesdayLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.wednesdayLayoutPanel.Size = new System.Drawing.Size(925, 234);
            this.wednesdayLayoutPanel.TabIndex = 10;
            // 
            // wednesdayLbl
            // 
            this.wednesdayLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wednesdayLbl.AutoSize = true;
            this.wednesdayLbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.wednesdayLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wednesdayLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.wednesdayLbl.Location = new System.Drawing.Point(5, 2);
            this.wednesdayLbl.Name = "wednesdayLbl";
            this.wednesdayLbl.Size = new System.Drawing.Size(915, 44);
            this.wednesdayLbl.TabIndex = 1;
            this.wednesdayLbl.Text = "Wednesday";
            this.wednesdayLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tuesdayLayoutPanel
            // 
            this.tuesdayLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tuesdayLayoutPanel.ColumnCount = 1;
            this.tuesdayLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tuesdayLayoutPanel.Controls.Add(this.tuesdayLbl, 0, 0);
            this.tuesdayLayoutPanel.Location = new System.Drawing.Point(4, 248);
            this.tuesdayLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tuesdayLayoutPanel.Name = "tuesdayLayoutPanel";
            this.tuesdayLayoutPanel.RowCount = 5;
            this.tuesdayLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tuesdayLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tuesdayLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tuesdayLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tuesdayLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tuesdayLayoutPanel.Size = new System.Drawing.Size(925, 234);
            this.tuesdayLayoutPanel.TabIndex = 9;
            // 
            // tuesdayLbl
            // 
            this.tuesdayLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tuesdayLbl.AutoSize = true;
            this.tuesdayLbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tuesdayLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuesdayLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tuesdayLbl.Location = new System.Drawing.Point(5, 2);
            this.tuesdayLbl.Name = "tuesdayLbl";
            this.tuesdayLbl.Size = new System.Drawing.Size(915, 44);
            this.tuesdayLbl.TabIndex = 1;
            this.tuesdayLbl.Text = "Tuesday";
            this.tuesdayLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mondayLayoutPanel
            // 
            this.mondayLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.mondayLayoutPanel.ColumnCount = 1;
            this.mondayLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mondayLayoutPanel.Controls.Add(this.mondayLbl, 0, 0);
            this.mondayLayoutPanel.Location = new System.Drawing.Point(4, 5);
            this.mondayLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mondayLayoutPanel.Name = "mondayLayoutPanel";
            this.mondayLayoutPanel.RowCount = 5;
            this.mondayLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mondayLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mondayLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mondayLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mondayLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mondayLayoutPanel.Size = new System.Drawing.Size(925, 234);
            this.mondayLayoutPanel.TabIndex = 8;
            // 
            // mondayLbl
            // 
            this.mondayLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mondayLbl.AutoSize = true;
            this.mondayLbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mondayLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mondayLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mondayLbl.Location = new System.Drawing.Point(5, 2);
            this.mondayLbl.Name = "mondayLbl";
            this.mondayLbl.Size = new System.Drawing.Size(915, 44);
            this.mondayLbl.TabIndex = 0;
            this.mondayLbl.Text = "Monday";
            this.mondayLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thursdayLayoutPanel
            // 
            this.thursdayLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.thursdayLayoutPanel.ColumnCount = 1;
            this.thursdayLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.thursdayLayoutPanel.Controls.Add(this.thursdayLbl, 0, 0);
            this.thursdayLayoutPanel.Location = new System.Drawing.Point(4, 734);
            this.thursdayLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.thursdayLayoutPanel.Name = "thursdayLayoutPanel";
            this.thursdayLayoutPanel.RowCount = 5;
            this.thursdayLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.thursdayLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.thursdayLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.thursdayLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.thursdayLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.thursdayLayoutPanel.Size = new System.Drawing.Size(925, 234);
            this.thursdayLayoutPanel.TabIndex = 11;
            // 
            // thursdayLbl
            // 
            this.thursdayLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.thursdayLbl.AutoSize = true;
            this.thursdayLbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.thursdayLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thursdayLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.thursdayLbl.Location = new System.Drawing.Point(5, 2);
            this.thursdayLbl.Name = "thursdayLbl";
            this.thursdayLbl.Size = new System.Drawing.Size(915, 44);
            this.thursdayLbl.TabIndex = 1;
            this.thursdayLbl.Text = "Thursday";
            this.thursdayLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayLbl
            // 
            this.displayLbl.AutoSize = true;
            this.displayLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLbl.Location = new System.Drawing.Point(2, 40);
            this.displayLbl.Name = "displayLbl";
            this.displayLbl.Size = new System.Drawing.Size(182, 38);
            this.displayLbl.TabIndex = 0;
            this.displayLbl.Text = "Schedule - ";
            this.displayLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Black;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(673, 31);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(125, 50);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.Black;
            this.printButton.ForeColor = System.Drawing.Color.White;
            this.printButton.Location = new System.Drawing.Point(542, 31);
            this.printButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(125, 50);
            this.printButton.TabIndex = 8;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.saveAsPdfButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.backButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backButton.Location = new System.Drawing.Point(804, 31);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(125, 50);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "Go Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // FinalSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(961, 1045);
            this.Controls.Add(this.schedulePanel);
            this.Controls.Add(this.schedulePictureBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1571, 1922);
            this.MinimumSize = new System.Drawing.Size(943, 958);
            this.Name = "FinalSchedule";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Schedule";
            ((System.ComponentModel.ISupportInitialize)(this.schedulePictureBox)).EndInit();
            this.schedulePanel.ResumeLayout(false);
            this.schedulePanel.PerformLayout();
            this.dayLayoutPanel.ResumeLayout(false);
            this.fridayLayoutPanel.ResumeLayout(false);
            this.fridayLayoutPanel.PerformLayout();
            this.wednesdayLayoutPanel.ResumeLayout(false);
            this.wednesdayLayoutPanel.PerformLayout();
            this.tuesdayLayoutPanel.ResumeLayout(false);
            this.tuesdayLayoutPanel.PerformLayout();
            this.mondayLayoutPanel.ResumeLayout(false);
            this.mondayLayoutPanel.PerformLayout();
            this.thursdayLayoutPanel.ResumeLayout(false);
            this.thursdayLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox schedulePictureBox;
        private System.Windows.Forms.PrintDialog printDialogBox;
        private System.Windows.Forms.Panel schedulePanel;
        private System.Windows.Forms.Label displayLbl;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TableLayoutPanel dayLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel mondayLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel fridayLayoutPanel;
        private System.Windows.Forms.Label fridayLbl;
        private System.Windows.Forms.TableLayoutPanel wednesdayLayoutPanel;
        private System.Windows.Forms.Label wednesdayLbl;
        private System.Windows.Forms.TableLayoutPanel tuesdayLayoutPanel;
        private System.Windows.Forms.Label tuesdayLbl;
        private System.Windows.Forms.Label mondayLbl;
        private System.Windows.Forms.TableLayoutPanel thursdayLayoutPanel;
        private System.Windows.Forms.Label thursdayLbl;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button backButton;
    }
}