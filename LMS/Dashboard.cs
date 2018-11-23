using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class Dashboard : Form
    {
        Login login;

        

        public Dashboard()
        {
            InitializeComponent();
            //register button highlight
            registerCoursesButton.MouseEnter += OnMouseEnterRegisterButton;
            registerCoursesButton.MouseLeave += OnMouseLeaveRegisterButton;
            //change password button highlight
            changePasswordButton.MouseEnter += OnMouseEnterChangePasswordButton;
            changePasswordButton.MouseLeave += OnMouseLeaveChangePasswordButton;
            //change password button highlight
            usersButton.MouseEnter += OnMouseEnterUsersButton;
            usersButton.MouseLeave += OnMouseLeaveUsersButton;
            lblGivenName.Text = LMS_Db_Connection.Instance.GivenName;
            lblFamilyName.Text = LMS_Db_Connection.Instance.FamilyName;
        }
        //
        private void OnMouseEnterRegisterButton(object sender, EventArgs e)
        {
            registerCoursesButton.BackColor = Color.Gold;
            registerCoursesButton.ForeColor = Color.Black;
        }
        private void OnMouseLeaveRegisterButton(object sender, EventArgs e)
        {
            registerCoursesButton.BackColor = Color.Transparent;
            registerCoursesButton.ForeColor = Color.White;
        }
        //
        private void OnMouseEnterChangePasswordButton(object sender, EventArgs e)
        {
            changePasswordButton.BackColor = Color.Gold;
            changePasswordButton.ForeColor = Color.Black;
        }
        private void OnMouseLeaveChangePasswordButton(object sender, EventArgs e)
        {
            changePasswordButton.BackColor = Color.Transparent;
            changePasswordButton.ForeColor = Color.White;
        }
        //
        private void OnMouseEnterUsersButton(object sender, EventArgs e)
        {
            usersButton.BackColor = Color.Gold;
            usersButton.ForeColor = Color.Black;
        }
        private void OnMouseLeaveUsersButton(object sender, EventArgs e)
        {
            usersButton.BackColor = Color.Transparent;
            usersButton.ForeColor = Color.White;
        }
        //Login login = new Login();
        //private object LOGIN { get; set; }
        private int mode = 0;

        public void setMode(int privilege)
        {
            mode = privilege;
            switch(mode)
            {
                case 1: //super
                    registerCoursesButton.Visible = false;
                    usersButton.Visible = true;
                    break;
                case 2: //admin
                    registerCoursesButton.Visible = false;
                    usersButton.Visible = true;
                    break;
                case 3: //professor
                    //assignmentsDataTable();
                    break;
                case 4: //student
                    registerCoursesButton.Visible = true;
                    usersButton.Visible = false;
                    break;
                default: //invalid
                    break;
            }
        }

        private void studentPanel_visibleOn()
        {
            registerCoursesButton.Visible = true;
            //StudentDashInfo.Visible = true;
        }
        private void professorPanel_visibleOn()
        {
            
        }
        private void adminPanel_visibleOn()
        {
            
        }
        private void logoutButton_Click(object sender, EventArgs e)
        {
            //need to find way to create only one instance of all forms.
            //maybe w/i program.cs
            //close dashboard form
            login = new Login();
            this.Close();
            //this.Hide();
            //clear user login info.
            login.ClearUserInfo();
            //show login form            
            login.Show();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case 1: //admin
                    break;
                case 2: //admin
                    //edit student info
                    //StudentInfoGrid.ReadOnly = false;
                    //StudentInfoGrid.AllowUserToAddRows = true;
                    //StudentInfoGrid.AllowUserToDeleteRows = true;
                    break;
                case 3: //professor
                    break;
                case 4: //student
                    //view registered courses
                    break;
                default: //invalid
                    break;
            }
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case 1: //super
                    break;
                case 2: //admin
                    //edit student info
                    //StudentInfoGrid.ReadOnly = true;
                    break;
                case 3: //professor
                    break;
                case 4: //student
                    //view registered courses
                    break;
                default: //invalid
                    break;
            }
            //save record to database?
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            //go to change password form/ or open modal
        }
        //test data source
        DataTable studentInfoTable = new DataTable();
        DataTable createAssignmentsTable = new DataTable();

        private void deleteButton_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case 2: //admin
                    break;
                case 3: //professor
                    //need to separate two panels with the delete button
             //rowIndex = createAssignmentsGrid.CurrentCell.RowIndex;
             //       createAssignmentsGrid.Rows.RemoveAt(rowIndex);
                    break;
                case 4: //student
                    break;
                default: //invalid
                    break;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

            if (!contentPanel.Controls.Contains(StudentDashboard_UserControl.Instance))
            {
                contentPanel.Controls.Add(StudentDashboard_UserControl.Instance);
                StudentDashboard_UserControl.Instance.Dock = DockStyle.Fill;
            }
            StudentDashboard_UserControl.Instance.BringToFront();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (LMS_Db_Connection.Instance.UserRole == 4)
            {
                if (!contentPanel.Controls.Contains(RegisterCourses_UserControl.Instance))
                {
                    contentPanel.Controls.Add(RegisterCourses_UserControl.Instance);
                    RegisterCourses_UserControl.Instance.Dock = DockStyle.Fill;
                }
                RegisterCourses_UserControl.Instance.BringToFront();
            }
        }
        private void usersButton_Click(object sender, EventArgs e)
        {
            if (LMS_Db_Connection.Instance.UserRole <= 2)
            {
                if (!contentPanel.Controls.Contains(Users_UserControl.Instance))
                {
                    contentPanel.Controls.Add(Users_UserControl.Instance);
                    Users_UserControl.Instance.Dock = DockStyle.Fill;
                }
                Users_UserControl.Instance.BringToFront();
            }
        }
    }
}
