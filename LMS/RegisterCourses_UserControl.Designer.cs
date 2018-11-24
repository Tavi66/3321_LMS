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
            this.btnEnroll = new System.Windows.Forms.Button();
            this.cboUsers = new System.Windows.Forms.ComboBox();
            this.Enroll = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dgvEnrollCourses.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvEnrollCourses.Location = new System.Drawing.Point(0, 0);
            this.dgvEnrollCourses.Name = "dgvEnrollCourses";
            this.dgvEnrollCourses.Size = new System.Drawing.Size(900, 501);
            this.dgvEnrollCourses.TabIndex = 0;
            this.dgvEnrollCourses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEnrollCourses_CellContentClick);
            // 
            // btnEnroll
            // 
            this.btnEnroll.Location = new System.Drawing.Point(188, 529);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(75, 23);
            this.btnEnroll.TabIndex = 1;
            this.btnEnroll.Text = "Enroll";
            this.btnEnroll.UseVisualStyleBackColor = true;
            this.btnEnroll.Click += new System.EventHandler(this.btnEnroll_Click);
            // 
            // cboUsers
            // 
            this.cboUsers.FormattingEnabled = true;
            this.cboUsers.Location = new System.Drawing.Point(36, 529);
            this.cboUsers.Name = "cboUsers";
            this.cboUsers.Size = new System.Drawing.Size(121, 21);
            this.cboUsers.TabIndex = 2;
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
            // 
            // RegisterCourses_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboUsers);
            this.Controls.Add(this.btnEnroll);
            this.Controls.Add(this.dgvEnrollCourses);
            this.Name = "RegisterCourses_UserControl";
            this.Size = new System.Drawing.Size(900, 581);
            this.Load += new System.EventHandler(this.RegisterCourses_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrollCourses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEnrollCourses;
        private System.Windows.Forms.Button btnEnroll;
        private System.Windows.Forms.ComboBox cboUsers;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Enroll;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseDesc;
    }
}
