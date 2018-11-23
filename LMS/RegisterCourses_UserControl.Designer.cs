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
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrollCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEnrollCourses
            // 
            this.dgvEnrollCourses.AllowUserToAddRows = false;
            this.dgvEnrollCourses.AllowUserToDeleteRows = false;
            this.dgvEnrollCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnrollCourses.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvEnrollCourses.Location = new System.Drawing.Point(0, 0);
            this.dgvEnrollCourses.Name = "dgvEnrollCourses";
            this.dgvEnrollCourses.Size = new System.Drawing.Size(900, 501);
            this.dgvEnrollCourses.TabIndex = 0;
            this.dgvEnrollCourses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEnrollCourses_CellContentClick);
            // 
            // btnEnroll
            // 
            this.btnEnroll.Location = new System.Drawing.Point(113, 523);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(75, 23);
            this.btnEnroll.TabIndex = 1;
            this.btnEnroll.Text = "Enroll";
            this.btnEnroll.UseVisualStyleBackColor = true;
            this.btnEnroll.Click += new System.EventHandler(this.btnEnroll_Click);
            // 
            // RegisterCourses_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}
