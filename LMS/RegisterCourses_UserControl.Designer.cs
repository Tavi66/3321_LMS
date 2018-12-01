namespace LMS
{
    partial class RegisterCourses_UserControl
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
            this.dgvEnrollCourses = new System.Windows.Forms.DataGridView();
            this.Enroll = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdateEnrollments = new System.Windows.Forms.Button();
            this.cboUsers = new System.Windows.Forms.ComboBox();
            this.lblUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrollCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEnrollCourses
            // 
            this.dgvEnrollCourses.AllowUserToAddRows = false;
            this.dgvEnrollCourses.AllowUserToDeleteRows = false;
            this.dgvEnrollCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnrollCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Enroll,
            this.CourseID,
            this.CourseDesc});
            this.dgvEnrollCourses.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvEnrollCourses.Location = new System.Drawing.Point(0, 32);
            this.dgvEnrollCourses.Name = "dgvEnrollCourses";
            this.dgvEnrollCourses.Size = new System.Drawing.Size(900, 549);
            this.dgvEnrollCourses.TabIndex = 0;
            this.dgvEnrollCourses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEnrollCourses_CellContentClick);
            // 
            // Enroll
            // 
            this.Enroll.HeaderText = "Enroll";
            this.Enroll.Name = "Enroll";
            // 
            // CourseID
            // 
            this.CourseID.HeaderText = "CourseID";
            this.CourseID.Name = "CourseID";
            this.CourseID.Visible = false;
            // 
            // CourseDesc
            // 
            this.CourseDesc.HeaderText = "Course Desc";
            this.CourseDesc.Name = "CourseDesc";
            this.CourseDesc.Width = 200;
            // 
            // btnUpdateEnrollments
            // 
            this.btnUpdateEnrollments.Location = new System.Drawing.Point(168, 3);
            this.btnUpdateEnrollments.Name = "btnUpdateEnrollments";
            this.btnUpdateEnrollments.Size = new System.Drawing.Size(121, 23);
            this.btnUpdateEnrollments.TabIndex = 1;
            this.btnUpdateEnrollments.Text = "Update Enrollments";
            this.btnUpdateEnrollments.UseVisualStyleBackColor = true;
            this.btnUpdateEnrollments.Click += new System.EventHandler(this.btnEnroll_Click);
            // 
            // cboUsers
            // 
            this.cboUsers.FormattingEnabled = true;
            this.cboUsers.Location = new System.Drawing.Point(41, 3);
            this.cboUsers.Name = "cboUsers";
            this.cboUsers.Size = new System.Drawing.Size(121, 21);
            this.cboUsers.TabIndex = 2;
            this.cboUsers.SelectedIndexChanged += new System.EventHandler(this.cboUsers_SelectedIndexChanged);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(4, 6);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(32, 13);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "User:";
            // 
            // RegisterCourses_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.cboUsers);
            this.Controls.Add(this.btnUpdateEnrollments);
            this.Controls.Add(this.dgvEnrollCourses);
            this.Name = "RegisterCourses_UserControl";
            this.Size = new System.Drawing.Size(900, 581);
            this.Load += new System.EventHandler(this.RegisterCourses_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrollCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEnrollCourses;
        private System.Windows.Forms.Button btnUpdateEnrollments;
        private System.Windows.Forms.ComboBox cboUsers;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Enroll;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseDesc;
        private System.Windows.Forms.Label lblUser;
    }
}
