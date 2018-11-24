namespace LMS
{
    partial class Class_UserControl
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
            this.dgvAssignments = new System.Windows.Forms.DataGridView();
            this.txtTotalPoints = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnAddAssignment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCourseDesc = new System.Windows.Forms.TextBox();
            this.pnlAddAssignment = new System.Windows.Forms.Panel();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradeBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TurnIn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignments)).BeginInit();
            this.pnlAddAssignment.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAssignments
            // 
            this.dgvAssignments.AllowUserToAddRows = false;
            this.dgvAssignments.AllowUserToDeleteRows = false;
            this.dgvAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TotalPoints,
            this.Desc,
            this.Grade,
            this.GradeBtn,
            this.Delete,
            this.TurnIn});
            this.dgvAssignments.Location = new System.Drawing.Point(0, 31);
            this.dgvAssignments.Name = "dgvAssignments";
            this.dgvAssignments.ReadOnly = true;
            this.dgvAssignments.Size = new System.Drawing.Size(900, 414);
            this.dgvAssignments.TabIndex = 0;
            this.dgvAssignments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssignments_CellContentClick);
            // 
            // txtTotalPoints
            // 
            this.txtTotalPoints.Location = new System.Drawing.Point(23, 52);
            this.txtTotalPoints.Name = "txtTotalPoints";
            this.txtTotalPoints.Size = new System.Drawing.Size(100, 20);
            this.txtTotalPoints.TabIndex = 1;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(133, 52);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(519, 20);
            this.txtDesc.TabIndex = 2;
            // 
            // btnAddAssignment
            // 
            this.btnAddAssignment.Location = new System.Drawing.Point(691, 49);
            this.btnAddAssignment.Name = "btnAddAssignment";
            this.btnAddAssignment.Size = new System.Drawing.Size(75, 23);
            this.btnAddAssignment.TabIndex = 3;
            this.btnAddAssignment.Text = "Add";
            this.btnAddAssignment.UseVisualStyleBackColor = true;
            this.btnAddAssignment.Click += new System.EventHandler(this.btnAddAssignment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Points";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Class";
            // 
            // txtCourseDesc
            // 
            this.txtCourseDesc.Enabled = false;
            this.txtCourseDesc.Location = new System.Drawing.Point(75, 8);
            this.txtCourseDesc.Name = "txtCourseDesc";
            this.txtCourseDesc.Size = new System.Drawing.Size(577, 20);
            this.txtCourseDesc.TabIndex = 7;
            // 
            // pnlAddAssignment
            // 
            this.pnlAddAssignment.Controls.Add(this.label1);
            this.pnlAddAssignment.Controls.Add(this.txtTotalPoints);
            this.pnlAddAssignment.Controls.Add(this.label2);
            this.pnlAddAssignment.Controls.Add(this.btnAddAssignment);
            this.pnlAddAssignment.Controls.Add(this.txtDesc);
            this.pnlAddAssignment.Location = new System.Drawing.Point(30, 448);
            this.pnlAddAssignment.Name = "pnlAddAssignment";
            this.pnlAddAssignment.Size = new System.Drawing.Size(828, 100);
            this.pnlAddAssignment.TabIndex = 8;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // TotalPoints
            // 
            this.TotalPoints.HeaderText = "Total Points";
            this.TotalPoints.Name = "TotalPoints";
            this.TotalPoints.ReadOnly = true;
            // 
            // Desc
            // 
            this.Desc.HeaderText = "Description";
            this.Desc.Name = "Desc";
            this.Desc.ReadOnly = true;
            this.Desc.Width = 300;
            // 
            // Grade
            // 
            this.Grade.HeaderText = "Grade";
            this.Grade.Name = "Grade";
            this.Grade.ReadOnly = true;
            // 
            // GradeBtn
            // 
            this.GradeBtn.HeaderText = "Grade";
            this.GradeBtn.Name = "GradeBtn";
            this.GradeBtn.ReadOnly = true;
            this.GradeBtn.Text = "Grade";
            this.GradeBtn.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // TurnIn
            // 
            this.TurnIn.HeaderText = "Turn In";
            this.TurnIn.Name = "TurnIn";
            this.TurnIn.ReadOnly = true;
            this.TurnIn.Text = "Turn In";
            this.TurnIn.UseColumnTextForButtonValue = true;
            // 
            // Class_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlAddAssignment);
            this.Controls.Add(this.txtCourseDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvAssignments);
            this.Name = "Class_UserControl";
            this.Size = new System.Drawing.Size(900, 551);
            this.Load += new System.EventHandler(this.Class_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignments)).EndInit();
            this.pnlAddAssignment.ResumeLayout(false);
            this.pnlAddAssignment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAssignments;
        private System.Windows.Forms.TextBox txtTotalPoints;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnAddAssignment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCourseDesc;
        private System.Windows.Forms.Panel pnlAddAssignment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewButtonColumn GradeBtn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn TurnIn;
    }
}
