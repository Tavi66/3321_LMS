﻿namespace LMS
{
    partial class StudentDashboard_UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StudentDashInfo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGPA = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDashInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentDashInfo
            // 
            this.StudentDashInfo.AllowUserToAddRows = false;
            this.StudentDashInfo.AllowUserToDeleteRows = false;
            this.StudentDashInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentDashInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StudentDashInfo.Location = new System.Drawing.Point(0, 30);
            this.StudentDashInfo.Name = "StudentDashInfo";
            this.StudentDashInfo.ReadOnly = true;
            this.StudentDashInfo.Size = new System.Drawing.Size(900, 551);
            this.StudentDashInfo.TabIndex = 0;
            this.StudentDashInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentDashInfo_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(787, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "GPA:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtGPA
            // 
            this.txtGPA.Enabled = false;
            this.txtGPA.Location = new System.Drawing.Point(825, 8);
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.Size = new System.Drawing.Size(51, 20);
            this.txtGPA.TabIndex = 2;
            // 
            // txtYear
            // 
            this.txtYear.Enabled = false;
            this.txtYear.Location = new System.Drawing.Point(717, 8);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(51, 20);
            this.txtYear.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(679, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Year:";
            // 
            // StudentDashboard_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGPA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentDashInfo);
            this.Name = "StudentDashboard_UserControl";
            this.Size = new System.Drawing.Size(900, 581);
            this.Load += new System.EventHandler(this.StudentDashboard_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentDashInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentDashInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGPA;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label2;
    }
}