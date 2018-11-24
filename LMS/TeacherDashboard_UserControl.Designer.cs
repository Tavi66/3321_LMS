namespace LMS
{
    partial class TeacherDashboard_UserControl
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
            this.TeacherDashInfo = new System.Windows.Forms.DataGridView();
            this.CourseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoToClass = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherDashInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // TeacherDashInfo
            // 
            this.TeacherDashInfo.AllowUserToAddRows = false;
            this.TeacherDashInfo.AllowUserToDeleteRows = false;
            this.TeacherDashInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeacherDashInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseId,
            this.CourseDesc,
            this.GoToClass});
            this.TeacherDashInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TeacherDashInfo.Location = new System.Drawing.Point(0, 37);
            this.TeacherDashInfo.Name = "TeacherDashInfo";
            this.TeacherDashInfo.ReadOnly = true;
            this.TeacherDashInfo.Size = new System.Drawing.Size(900, 544);
            this.TeacherDashInfo.TabIndex = 0;
            this.TeacherDashInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TeacherDashInfo_CellContentClick);
            // 
            // CourseId
            // 
            this.CourseId.HeaderText = "Course ID";
            this.CourseId.Name = "CourseId";
            this.CourseId.ReadOnly = true;
            this.CourseId.Visible = false;
            // 
            // CourseDesc
            // 
            this.CourseDesc.HeaderText = "Course Desc";
            this.CourseDesc.Name = "CourseDesc";
            this.CourseDesc.ReadOnly = true;
            // 
            // GoToClass
            // 
            this.GoToClass.HeaderText = "Go To Class";
            this.GoToClass.Name = "GoToClass";
            this.GoToClass.ReadOnly = true;
            this.GoToClass.Text = "Go To Class";
            this.GoToClass.UseColumnTextForButtonValue = true;
            // 
            // TeacherDashboard_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TeacherDashInfo);
            this.Name = "TeacherDashboard_UserControl";
            this.Size = new System.Drawing.Size(900, 581);
            this.Load += new System.EventHandler(this.TeacherDashboard_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TeacherDashInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TeacherDashInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseDesc;
        private System.Windows.Forms.DataGridViewButtonColumn GoToClass;
    }
}
