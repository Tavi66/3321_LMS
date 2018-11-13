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
    public partial class Login : Form
    {
        private Boolean loginSuccess = false;

        Dashboard dashboard = new Dashboard();

        public Login()
        {
            InitializeComponent();
            this.AcceptButton = loginButton;
           //var USER = new User();
        }

        private object USER { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            //store user entered data
            var USER = new User() { password = passwordEntry.Text, username = usernameEntry.Text};
            LMS_Db_Connection lmsConn = LMS_Db_Connection.Instance;
            loginSuccess = lmsConn.authenticateUser(USER.username, USER.password);
            //if login is sucessful show dashboard form and hide login form
            if (loginSuccess)
            {
                int role = lmsConn.UserRole;
                if (role <= 2) USER.adminPrivilege = true;
                else if (role == 3) USER.profPrivilege = true;
                else if (role == 4) USER.studPrivilege = true;

                dashboard.setMode(role);
                usernameEntry.Text = "";
                passwordEntry.Text = "";
                dashboard.Show();
                this.Hide();
            } else
            {
                errorLabel.Visible = true;
                passwordEntry.Text = "";
            }
        }

        public void ClearUserInfo()
        {
            loginSuccess = false;
            //clear current user login
        }
    }
}
