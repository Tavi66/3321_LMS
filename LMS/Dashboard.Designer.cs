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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ModifyPanel = new System.Windows.Forms.Panel();
            this.doneButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.DateLabel = new System.Windows.Forms.Label();
            this.StudentInfoGrid = new System.Windows.Forms.DataGridView();
            this.StudentDashInfo = new System.Windows.Forms.DataGridView();
            this.registeredCourses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewGPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.navPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.assignmentsButton = new System.Windows.Forms.Label();
            this.registerCoursesButton = new System.Windows.Forms.Label();
            this.changePasswordButton = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.fNameLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ModifyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentInfoGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDashInfo)).BeginInit();
            this.navPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ModifyPanel
            // 
            this.ModifyPanel.Controls.Add(this.doneButton);
            this.ModifyPanel.Controls.Add(this.deleteButton);
            this.ModifyPanel.Controls.Add(this.editButton);
            this.ModifyPanel.Location = new System.Drawing.Point(1030, 69);
            this.ModifyPanel.Name = "ModifyPanel";
            this.ModifyPanel.Size = new System.Drawing.Size(105, 453);
            this.ModifyPanel.TabIndex = 0;
            this.ModifyPanel.Visible = false;
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(15, 88);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(75, 23);
            this.doneButton.TabIndex = 2;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Visible = false;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Red;
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(15, 45);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 37);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
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
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(83, 514);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 37);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(965, 32);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(123, 13);
            this.DateLabel.TabIndex = 5;
            this.DateLabel.Text = "M DD YYYY HH:MM:SS";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.StudentInfoGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.StudentInfoGrid.GridColor = System.Drawing.SystemColors.Control;
            this.StudentInfoGrid.Location = new System.Drawing.Point(253, 69);
            this.StudentInfoGrid.Name = "StudentInfoGrid";
            this.StudentInfoGrid.RowTemplate.Height = 24;
            this.StudentInfoGrid.Size = new System.Drawing.Size(771, 453);
            this.StudentInfoGrid.TabIndex = 7;
            this.StudentInfoGrid.Visible = false;
            // 
            // StudentDashInfo
            // 
            this.StudentDashInfo.AllowUserToAddRows = false;
            this.StudentDashInfo.AllowUserToDeleteRows = false;
            this.StudentDashInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentDashInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentDashInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.registeredCourses,
            this.Grade,
            this.viewGPA});
            this.StudentDashInfo.Location = new System.Drawing.Point(253, 69);
            this.StudentDashInfo.Name = "StudentDashInfo";
            this.StudentDashInfo.ReadOnly = true;
            this.StudentDashInfo.RowTemplate.Height = 24;
            this.StudentDashInfo.Size = new System.Drawing.Size(867, 453);
            this.StudentDashInfo.TabIndex = 8;
            this.StudentDashInfo.Visible = false;
            // 
            // registeredCourses
            // 
            this.registeredCourses.HeaderText = "Enrolled Courses";
            this.registeredCourses.Name = "registeredCourses";
            this.registeredCourses.ReadOnly = true;
            // 
            // Grade
            // 
            this.Grade.HeaderText = "Grade";
            this.Grade.Name = "Grade";
            this.Grade.ReadOnly = true;
            // 
            // viewGPA
            // 
            this.viewGPA.HeaderText = "GPA";
            this.viewGPA.Name = "viewGPA";
            this.viewGPA.ReadOnly = true;
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.navPanel.Controls.Add(this.label2);
            this.navPanel.Controls.Add(this.assignmentsButton);
            this.navPanel.Controls.Add(this.registerCoursesButton);
            this.navPanel.Controls.Add(this.changePasswordButton);
            this.navPanel.Controls.Add(this.lastNameLabel);
            this.navPanel.Controls.Add(this.fNameLabel);
            this.navPanel.Controls.Add(this.logoutButton);
            this.navPanel.Location = new System.Drawing.Point(-1, 0);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(248, 583);
            this.navPanel.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(-1, 149);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 0, 100, 0);
            this.label2.Size = new System.Drawing.Size(227, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "DASHBOARD";
            // 
            // assignmentsButton
            // 
            this.assignmentsButton.AutoSize = true;
            this.assignmentsButton.BackColor = System.Drawing.Color.Transparent;
            this.assignmentsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignmentsButton.ForeColor = System.Drawing.Color.White;
            this.assignmentsButton.Location = new System.Drawing.Point(-1, 196);
            this.assignmentsButton.Name = "assignmentsButton";
            this.assignmentsButton.Padding = new System.Windows.Forms.Padding(5, 0, 75, 0);
            this.assignmentsButton.Size = new System.Drawing.Size(217, 20);
            this.assignmentsButton.TabIndex = 5;
            this.assignmentsButton.Text = "ASSIGNMENTS";
            this.assignmentsButton.Visible = false;
            // 
            // registerCoursesButton
            // 
            this.registerCoursesButton.AutoSize = true;
            this.registerCoursesButton.BackColor = System.Drawing.Color.Transparent;
            this.registerCoursesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerCoursesButton.ForeColor = System.Drawing.Color.White;
            this.registerCoursesButton.Location = new System.Drawing.Point(-1, 241);
            this.registerCoursesButton.Name = "registerCoursesButton";
            this.registerCoursesButton.Padding = new System.Windows.Forms.Padding(5, 0, 125, 0);
            this.registerCoursesButton.Size = new System.Drawing.Size(231, 20);
            this.registerCoursesButton.TabIndex = 4;
            this.registerCoursesButton.Text = "REGISTER";
            this.registerCoursesButton.Click += new System.EventHandler(this.registerCoursesButton_Click);
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.AutoSize = true;
            this.changePasswordButton.BackColor = System.Drawing.Color.Transparent;
            this.changePasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordButton.ForeColor = System.Drawing.Color.White;
            this.changePasswordButton.Location = new System.Drawing.Point(-3, 388);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Padding = new System.Windows.Forms.Padding(10, 10, 100, 10);
            this.changePasswordButton.Size = new System.Drawing.Size(218, 33);
            this.changePasswordButton.TabIndex = 3;
            this.changePasswordButton.Text = "Change Password";
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.White;
            this.lastNameLabel.Location = new System.Drawing.Point(22, 69);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(97, 20);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "SURNAME";
            // 
            // fNameLabel
            // 
            this.fNameLabel.AutoSize = true;
            this.fNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.fNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameLabel.ForeColor = System.Drawing.Color.White;
            this.fNameLabel.Location = new System.Drawing.Point(22, 44);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(120, 20);
            this.fNameLabel.TabIndex = 0;
            this.fNameLabel.Text = "GIVEN NAME";
            // 
            // Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1147, 581);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StudentInfoGrid);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.ModifyPanel);
            this.Controls.Add(this.navPanel);
            this.Controls.Add(this.StudentDashInfo);
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.Text = "LMS";
            this.ModifyPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentInfoGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDashInfo)).EndInit();
            this.navPanel.ResumeLayout(false);
            this.navPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ModifyPanel;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.DataGridView StudentInfoGrid;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView StudentDashInfo;
        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label fNameLabel;
        private System.Windows.Forms.Label changePasswordButton;
        private System.Windows.Forms.Label registerCoursesButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label assignmentsButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn registeredCourses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn viewGPA;
        private System.Windows.Forms.Button button1;
    }
}