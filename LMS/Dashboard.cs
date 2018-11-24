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
            usersButton.Visible = false;
            setMode(0);
        }

        private void InitializeForm(object sender, EventArgs e)
        {
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
        private int mode = 0;

        public void setMode(int privilege)
        {
            mode = privilege;
            switch(mode)
            {
                case 0:
                    lblGivenName.Text = "Please";
                    lblFamilyName.Text = "Log In";
                    registerCoursesButton.Visible = false;
                    btnHome.Visible = false;
                    changePasswordButton.Visible = false;
                    usersButton.Visible = false;
                    login_BringToFront();
                    break;
                case 1: //super
                    lblGivenName.Text = LMS_Db_Connection.Instance.GivenName;
                    lblFamilyName.Text = LMS_Db_Connection.Instance.FamilyName;
                    registerCoursesButton.Visible = false;
                    usersButton.Visible = true;
                    changePasswordButton.Visible = true;
                    btnHome.Visible = true;
                    Users_BringToFront();
                    break;
                case 2: //admin
                    lblGivenName.Text = LMS_Db_Connection.Instance.GivenName;
                    lblFamilyName.Text = LMS_Db_Connection.Instance.FamilyName;
                    registerCoursesButton.Visible = true;
                    usersButton.Visible = true;
                    changePasswordButton.Visible = true;
                    btnHome.Visible = true;
                    Users_BringToFront();
                    break;
                case 3: //professor
                    lblGivenName.Text = LMS_Db_Connection.Instance.GivenName;
                    lblFamilyName.Text = LMS_Db_Connection.Instance.FamilyName;
                    changePasswordButton.Visible = true;
                    btnHome.Visible = true;
                    btnHome.PerformClick();
                    break;
                case 4: //student
                    lblGivenName.Text = LMS_Db_Connection.Instance.GivenName;
                    lblFamilyName.Text = LMS_Db_Connection.Instance.FamilyName;
                    registerCoursesButton.Visible = true;
                    usersButton.Visible = false;
                    changePasswordButton.Visible = true;
                    btnHome.Visible = true;
                    StudentDashboard_BringToFront();
                    break;
                default: //invalid
                    break;
            }
        }

       
        private void logoutButton_Click(object sender, EventArgs e)
        {
            //clear user login info.
            setMode(0);
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            //go to change password form/ or open modal
        }
        //test data source
        DataTable studentInfoTable = new DataTable();
        DataTable createAssignmentsTable = new DataTable();

        private void login_BringToFront()
        {
            if (!contentPanel.Controls.Contains(Login_UserControl.Instance))
            {
                contentPanel.Controls.Add(Login_UserControl.Instance);
                Login_UserControl.Instance.Dock = DockStyle.Fill;
            }
            Login_UserControl.Instance.BringToFront();
        }
        private void Users_BringToFront()
        {
            if (!contentPanel.Controls.Contains(Users_UserControl.Instance))
            {
                contentPanel.Controls.Add(Users_UserControl.Instance);
                Users_UserControl.Instance.Dock = DockStyle.Fill;
            }
            Users_UserControl.Instance.BringToFront();
        }
        private void StudentDashboard_BringToFront()
        {
            if (!contentPanel.Controls.Contains(StudentDashboard_UserControl.Instance))
            {
                contentPanel.Controls.Add(StudentDashboard_UserControl.Instance);
                StudentDashboard_UserControl.Instance.Dock = DockStyle.Fill;
            }
            StudentDashboard_UserControl.Instance.BringToFront();
        }
        private void TeacherDashboard_BringToFront()
        {
            if (!contentPanel.Controls.Contains(TeacherDashboard_UserControl.Instance))
            {
                contentPanel.Controls.Add(TeacherDashboard_UserControl.Instance);
                TeacherDashboard_UserControl.Instance.Dock = DockStyle.Fill;
            }
            TeacherDashboard_UserControl.Instance.BringToFront();
        }
        public void Class_BringToFront()
        {
            if (!contentPanel.Controls.Contains(Class_UserControl.Instance))
            {
                contentPanel.Controls.Add(Class_UserControl.Instance);
                Class_UserControl.Instance.Dock = DockStyle.Fill;
            }
            Class_UserControl.Instance.BringToFront();
            Class_UserControl.Instance.refreshAssignmentsDataTable();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (mode == 3)
            {
                TeacherDashboard_BringToFront();
                TeacherDashboard_UserControl.Instance.Update_Dashboard();
            }
            else if (mode == 4)
            {
                StudentDashboard_BringToFront();
                StudentDashboard_UserControl.Instance.Update_Dashboard();
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (LMS_Db_Connection.Instance.UserRole == 2 || LMS_Db_Connection.Instance.UserRole == 4)
            {
                if (!contentPanel.Controls.Contains(RegisterCourses_UserControl.Instance))
                {
                    contentPanel.Controls.Add(RegisterCourses_UserControl.Instance);
                    RegisterCourses_UserControl.Instance.Dock = DockStyle.Fill;
                }
                RegisterCourses_UserControl.Instance.UpdateUsers();
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

        private void navPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
