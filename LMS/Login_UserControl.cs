using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class Login_UserControl : UserControl
    {
        private static Login_UserControl _instance;
        
        public static Login_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Login_UserControl();
                }
                return _instance;
            }
        }
        public Login_UserControl()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = (Dashboard)Application.OpenForms["Dashboard"];

            Boolean loginSuccess = false;
            //store user entered data
            var USER = new User() { password = passwordEntry.Text, username = usernameEntry.Text };
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
                errorLabel.Visible = false;
            }
            else
            {
                errorLabel.Visible = true;
                passwordEntry.Text = "";
            }
        }
    }
}
