namespace LMS
{
    partial class Assignments
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
            this.profAssignmentsPanel = new System.Windows.Forms.Panel();
            this.addAssignmentButton = new System.Windows.Forms.Button();
            this.modifyAssignmentsGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createAssignmentsGrid = new System.Windows.Forms.DataGridView();
            this.navPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.assignmentsButton = new System.Windows.Forms.Label();
            this.registerCoursesButton = new System.Windows.Forms.Label();
            this.changePasswordButton = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.fNameLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.ModifyPanel = new System.Windows.Forms.Panel();
            this.doneButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.DateLabel = new System.Windows.Forms.Label();
            this.profAssignmentsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modifyAssignmentsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createAssignmentsGrid)).BeginInit();
            this.navPanel.SuspendLayout();
            this.ModifyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // profAssignmentsPanel
            // 
            this.profAssignmentsPanel.Controls.Add(this.addAssignmentButton);
            this.profAssignmentsPanel.Controls.Add(this.modifyAssignmentsGrid);
            this.profAssignmentsPanel.Controls.Add(this.createAssignmentsGrid);
            this.profAssignmentsPanel.Location = new System.Drawing.Point(256, 52);
            this.profAssignmentsPanel.Name = "profAssignmentsPanel";
            this.profAssignmentsPanel.Size = new System.Drawing.Size(771, 486);
            this.profAssignmentsPanel.TabIndex = 14;
            this.profAssignmentsPanel.Visible = false;
            // 
            // addAssignmentButton
            // 
            this.addAssignmentButton.Location = new System.Drawing.Point(391, 231);
            this.addAssignmentButton.Name = "addAssignmentButton";
            this.addAssignmentButton.Size = new System.Drawing.Size(29, 23);
            this.addAssignmentButton.TabIndex = 13;
            this.addAssignmentButton.Text = ">";
            this.addAssignmentButton.UseVisualStyleBackColor = true;
            // 
            // modifyAssignmentsGrid
            // 
            this.modifyAssignmentsGrid.AllowUserToAddRows = false;
            this.modifyAssignmentsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.modifyAssignmentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modifyAssignmentsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3});
            this.modifyAssignmentsGrid.Location = new System.Drawing.Point(426, 17);
            this.modifyAssignmentsGrid.Name = "modifyAssignmentsGrid";
            this.modifyAssignmentsGrid.RowTemplate.Height = 24;
            this.modifyAssignmentsGrid.Size = new System.Drawing.Size(342, 450);
            this.modifyAssignmentsGrid.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Assigned Assignments";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Course";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // createAssignmentsGrid
            // 
            this.createAssignmentsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.createAssignmentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.createAssignmentsGrid.Location = new System.Drawing.Point(3, 17);
            this.createAssignmentsGrid.Name = "createAssignmentsGrid";
            this.createAssignmentsGrid.RowTemplate.Height = 24;
            this.createAssignmentsGrid.Size = new System.Drawing.Size(381, 450);
            this.createAssignmentsGrid.TabIndex = 11;
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
            this.navPanel.Location = new System.Drawing.Point(2, 0);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(248, 583);
            this.navPanel.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-1, 149);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 0, 100, 0);
            this.label2.Size = new System.Drawing.Size(252, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "DASHBOARD";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // assignmentsButton
            // 
            this.assignmentsButton.AutoSize = true;
            this.assignmentsButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.assignmentsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignmentsButton.ForeColor = System.Drawing.Color.Black;
            this.assignmentsButton.Location = new System.Drawing.Point(-1, 196);
            this.assignmentsButton.Name = "assignmentsButton";
            this.assignmentsButton.Padding = new System.Windows.Forms.Padding(5, 0, 75, 0);
            this.assignmentsButton.Size = new System.Drawing.Size(250, 25);
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
            this.registerCoursesButton.Size = new System.Drawing.Size(249, 25);
            this.registerCoursesButton.TabIndex = 4;
            this.registerCoursesButton.Text = "REGISTER";
            this.registerCoursesButton.Visible = false;
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
            this.changePasswordButton.Size = new System.Drawing.Size(247, 37);
            this.changePasswordButton.TabIndex = 3;
            this.changePasswordButton.Text = "Change Password";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.White;
            this.lastNameLabel.Location = new System.Drawing.Point(22, 69);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(118, 25);
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
            this.fNameLabel.Size = new System.Drawing.Size(146, 25);
            this.fNameLabel.TabIndex = 0;
            this.fNameLabel.Text = "GIVEN NAME";
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
            // 
            // ModifyPanel
            // 
            this.ModifyPanel.Controls.Add(this.doneButton);
            this.ModifyPanel.Controls.Add(this.deleteButton);
            this.ModifyPanel.Controls.Add(this.editButton);
            this.ModifyPanel.Location = new System.Drawing.Point(1030, 69);
            this.ModifyPanel.Name = "ModifyPanel";
            this.ModifyPanel.Size = new System.Drawing.Size(105, 453);
            this.ModifyPanel.TabIndex = 15;
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
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(15, 16);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 0;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(965, 32);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(155, 17);
            this.DateLabel.TabIndex = 16;
            this.DateLabel.Text = "M DD YYYY HH:MM:SS";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Assignments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 581);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.ModifyPanel);
            this.Controls.Add(this.profAssignmentsPanel);
            this.Controls.Add(this.navPanel);
            this.Name = "Assignments";
            this.Text = "Assignments";
            this.profAssignmentsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.modifyAssignmentsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createAssignmentsGrid)).EndInit();
            this.navPanel.ResumeLayout(false);
            this.navPanel.PerformLayout();
            this.ModifyPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel profAssignmentsPanel;
        private System.Windows.Forms.Button addAssignmentButton;
        private System.Windows.Forms.DataGridView modifyAssignmentsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView createAssignmentsGrid;
        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label assignmentsButton;
        private System.Windows.Forms.Label registerCoursesButton;
        private System.Windows.Forms.Label changePasswordButton;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label fNameLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Panel ModifyPanel;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label DateLabel;
    }
}