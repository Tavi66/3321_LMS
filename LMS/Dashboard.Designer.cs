namespace LMS
{
    partial class Dashboard
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
            this.ModifyPanel = new System.Windows.Forms.Panel();
            this.editButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.greetingLabel = new System.Windows.Forms.Label();
            this.StudentInfoGrid = new System.Windows.Forms.DataGridView();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Courses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentInfoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ModifyPanel
            // 
            this.ModifyPanel.Controls.Add(this.editButton);
            this.ModifyPanel.Location = new System.Drawing.Point(845, 69);
            this.ModifyPanel.Name = "ModifyPanel";
            this.ModifyPanel.Size = new System.Drawing.Size(105, 453);
            this.ModifyPanel.TabIndex = 0;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(15, 16);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 0;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.Red;
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(860, 21);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 37);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(181, 21);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(96, 31);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "NAME";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(684, 31);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(155, 17);
            this.DateLabel.TabIndex = 5;
            this.DateLabel.Text = "M DD YYYY HH:MM:SS";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // greetingLabel
            // 
            this.greetingLabel.AutoSize = true;
            this.greetingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetingLabel.Location = new System.Drawing.Point(25, 21);
            this.greetingLabel.Name = "greetingLabel";
            this.greetingLabel.Size = new System.Drawing.Size(150, 31);
            this.greetingLabel.TabIndex = 6;
            this.greetingLabel.Text = "Welcome, ";
            // 
            // StudentInfoGrid
            // 
            this.StudentInfoGrid.AllowUserToAddRows = false;
            this.StudentInfoGrid.AllowUserToDeleteRows = false;
            this.StudentInfoGrid.AllowUserToResizeColumns = false;
            this.StudentInfoGrid.AllowUserToResizeRows = false;
            this.StudentInfoGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentInfoGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StudentInfoGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.StudentInfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.StudentInfoGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student,
            this.ID,
            this.Courses,
            this.Scores,
            this.GPA});
            this.StudentInfoGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.StudentInfoGrid.GridColor = System.Drawing.SystemColors.Control;
            this.StudentInfoGrid.Location = new System.Drawing.Point(31, 69);
            this.StudentInfoGrid.Name = "StudentInfoGrid";
            this.StudentInfoGrid.ReadOnly = true;
            this.StudentInfoGrid.RowTemplate.Height = 24;
            this.StudentInfoGrid.Size = new System.Drawing.Size(808, 453);
            this.StudentInfoGrid.TabIndex = 7;
            // 
            // Student
            // 
            this.Student.HeaderText = "Student";
            this.Student.Name = "Student";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Courses
            // 
            this.Courses.HeaderText = "Registered Courses";
            this.Courses.Name = "Courses";
            // 
            // Scores
            // 
            this.Scores.HeaderText = "Exam Scores";
            this.Scores.Name = "Scores";
            // 
            // GPA
            // 
            this.GPA.HeaderText = "GPA";
            this.GPA.Name = "GPA";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 581);
            this.Controls.Add(this.StudentInfoGrid);
            this.Controls.Add(this.greetingLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.ModifyPanel);
            this.Name = "Dashboard";
            this.Text = "LMS";
            this.ModifyPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentInfoGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ModifyPanel;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label greetingLabel;
        private System.Windows.Forms.DataGridView StudentInfoGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Courses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Scores;
        private System.Windows.Forms.DataGridViewTextBoxColumn GPA;
    }
}