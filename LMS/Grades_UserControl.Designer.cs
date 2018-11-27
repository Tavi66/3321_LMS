namespace LMS
{
    partial class Grades_UserControl
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
            this.dgvGrades = new System.Windows.Forms.DataGridView();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurnedIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAssignmentDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaveGrades = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGrades
            // 
            this.dgvGrades.AllowUserToAddRows = false;
            this.dgvGrades.AllowUserToDeleteRows = false;
            this.dgvGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.UserName,
            this.TurnedIn,
            this.Grade});
            this.dgvGrades.Location = new System.Drawing.Point(0, 33);
            this.dgvGrades.Name = "dgvGrades";
            this.dgvGrades.Size = new System.Drawing.Size(900, 482);
            this.dgvGrades.TabIndex = 0;
            this.dgvGrades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrades_CellContentClick);
            // 
            // UserID
            // 
            this.UserID.HeaderText = "UserID";
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            this.UserID.Visible = false;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "User Name";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // TurnedIn
            // 
            this.TurnedIn.HeaderText = "TurnedIn";
            this.TurnedIn.Name = "TurnedIn";
            this.TurnedIn.ReadOnly = true;
            // 
            // Grade
            // 
            this.Grade.HeaderText = "Grade";
            this.Grade.Name = "Grade";
            // 
            // txtAssignmentDesc
            // 
            this.txtAssignmentDesc.Enabled = false;
            this.txtAssignmentDesc.Location = new System.Drawing.Point(100, 7);
            this.txtAssignmentDesc.Name = "txtAssignmentDesc";
            this.txtAssignmentDesc.Size = new System.Drawing.Size(577, 20);
            this.txtAssignmentDesc.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Grading:";
            // 
            // btnSaveGrades
            // 
            this.btnSaveGrades.Location = new System.Drawing.Point(69, 521);
            this.btnSaveGrades.Name = "btnSaveGrades";
            this.btnSaveGrades.Size = new System.Drawing.Size(96, 23);
            this.btnSaveGrades.TabIndex = 10;
            this.btnSaveGrades.Text = "Save Grades";
            this.btnSaveGrades.UseVisualStyleBackColor = true;
            this.btnSaveGrades.Click += new System.EventHandler(this.btnSaveGrades_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(196, 521);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Grades_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveGrades);
            this.Controls.Add(this.txtAssignmentDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvGrades);
            this.Name = "Grades_UserControl";
            this.Size = new System.Drawing.Size(900, 551);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrades;
        private System.Windows.Forms.TextBox txtAssignmentDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSaveGrades;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TurnedIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.Button btnCancel;
    }
}
