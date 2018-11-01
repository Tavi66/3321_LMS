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
        //Login login = new Login();
        //private object LOGIN { get; set; }
        public Dashboard()
        {
            InitializeComponent();
        }
        //sample PUBLIC to modify visibility of edit panel
        public void ModifyPanel_visibleOn()
        { ModifyPanel.Visible = true;  }
        //off
        public void ModifyPanel_visibleOff()
        { ModifyPanel.Visible = false; StudentInfoGrid.ReadOnly = true;}

        private void logoutButton_Click(object sender, EventArgs e)
        {
            //close dashboard form
            this.Close();
            //this.Hide();
            Login login = new Login();
            //clear user login info.
            login.ClearUserInfo();
            //show login form            
            login.Show();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            StudentInfoGrid.ReadOnly = false;
            StudentInfoGrid.AllowUserToAddRows = true;
            StudentInfoGrid.AllowUserToDeleteRows = true;
        }
    }
}
