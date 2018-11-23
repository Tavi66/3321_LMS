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
            this.logoutButton = new System.Windows.Forms.Button();
            this.DateLabel = new System.Windows.Forms.Label();
            this.navPanel = new System.Windows.Forms.Panel();
            this.usersButton = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.registerCoursesButton = new System.Windows.Forms.Label();
            this.changePasswordButton = new System.Windows.Forms.Label();
            this.lblFamilyName = new System.Windows.Forms.Label();
            this.lblGivenName = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.navPanel.SuspendLayout();
            this.SuspendLayout();
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
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.navPanel.Controls.Add(this.usersButton);
            this.navPanel.Controls.Add(this.label2);
            this.navPanel.Controls.Add(this.btnHome);
            this.navPanel.Controls.Add(this.registerCoursesButton);
            this.navPanel.Controls.Add(this.changePasswordButton);
            this.navPanel.Controls.Add(this.lblFamilyName);
            this.navPanel.Controls.Add(this.lblGivenName);
            this.navPanel.Controls.Add(this.logoutButton);
            this.navPanel.Location = new System.Drawing.Point(-1, 0);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(248, 583);
            this.navPanel.TabIndex = 9;
            // 
            // usersButton
            // 
            this.usersButton.AutoSize = true;
            this.usersButton.BackColor = System.Drawing.Color.Transparent;
            this.usersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersButton.ForeColor = System.Drawing.Color.White;
            this.usersButton.Location = new System.Drawing.Point(0, 197);
            this.usersButton.Name = "usersButton";
            this.usersButton.Padding = new System.Windows.Forms.Padding(5, 0, 125, 0);
            this.usersButton.Size = new System.Drawing.Size(201, 20);
            this.usersButton.TabIndex = 7;
            this.usersButton.Text = "USERS";
            this.usersButton.Click += new System.EventHandler(this.usersButton_Click);
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
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHome.Location = new System.Drawing.Point(44, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // registerCoursesButton
            // 
            this.registerCoursesButton.BackColor = System.Drawing.Color.Transparent;
            this.registerCoursesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerCoursesButton.ForeColor = System.Drawing.Color.White;
            this.registerCoursesButton.Location = new System.Drawing.Point(0, 197);
            this.registerCoursesButton.Name = "registerCoursesButton";
            this.registerCoursesButton.Size = new System.Drawing.Size(100, 23);
            this.registerCoursesButton.TabIndex = 8;
            this.registerCoursesButton.Text = "Register Courses";
            this.registerCoursesButton.Click += new System.EventHandler(this.registerButton_Click);
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
            // lblFamilyName
            // 
            this.lblFamilyName.AutoSize = true;
            this.lblFamilyName.BackColor = System.Drawing.Color.Transparent;
            this.lblFamilyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFamilyName.ForeColor = System.Drawing.Color.White;
            this.lblFamilyName.Location = new System.Drawing.Point(22, 69);
            this.lblFamilyName.Name = "lblFamilyName";
            this.lblFamilyName.Size = new System.Drawing.Size(97, 20);
            this.lblFamilyName.TabIndex = 1;
            this.lblFamilyName.Text = "SURNAME";
            // 
            // lblGivenName
            // 
            this.lblGivenName.AutoSize = true;
            this.lblGivenName.BackColor = System.Drawing.Color.Transparent;
            this.lblGivenName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGivenName.ForeColor = System.Drawing.Color.White;
            this.lblGivenName.Location = new System.Drawing.Point(22, 44);
            this.lblGivenName.Name = "lblGivenName";
            this.lblGivenName.Size = new System.Drawing.Size(120, 20);
            this.lblGivenName.TabIndex = 0;
            this.lblGivenName.Text = "GIVEN NAME";
            // 
            // contentPanel
            // 
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.contentPanel.Location = new System.Drawing.Point(247, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(900, 581);
            this.contentPanel.TabIndex = 11;
            // 
            // Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1147, 581);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.navPanel);
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.Text = "LMS";
            this.navPanel.ResumeLayout(false);
            this.navPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Label lblFamilyName;
        private System.Windows.Forms.Label lblGivenName;
        private System.Windows.Forms.Label changePasswordButton;
        private System.Windows.Forms.Label registerCoursesButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Label usersButton;
        public System.Windows.Forms.Button btnHome;
    }
}