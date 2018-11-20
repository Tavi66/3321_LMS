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
            assignmentsButton.MouseEnter += OnMouseEnterAssignmentsButton;
            assignmentsButton.MouseLeave += OnMouseLeaveAssignmentsButton;
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
        private void OnMouseEnterAssignmentsButton(object sender, EventArgs e)
        {
            assignmentsButton.BackColor = Color.Gold;
            assignmentsButton.ForeColor = Color.Black;
        }
        private void OnMouseLeaveAssignmentsButton(object sender, EventArgs e)
        {
            assignmentsButton.BackColor = Color.Transparent;
            assignmentsButton.ForeColor = Color.White;
        }
        //Login login = new Login();
        //private object LOGIN { get; set; }
        private int mode = 0;

        public void setMode(int privilege)
        {
            mode = privilege;
            switch(mode)
            {
                case 1: //admin
                    adminPanel_visibleOn();
                    ModifyPanel_visibleOn();
                    //test data table
                    dataTable();
                    break;
                case 2: //professor
                    ModifyPanel_visibleOn();
                    break;
                case 3: //student
                    studentPanel_visibleOn();
                    ModifyPanel_visibleOff();
                    break;
                default: //invalid
                    break;
            }
        }
        private void studentPanel_visibleOn()
        {
            registerCoursesButton.Visible = true;
            assignmentsButton.Visible = true;
            StudentDashInfo.Visible = true;
        }
        private void adminPanel_visibleOn()
        {
            StudentInfoGrid.Visible = true;
        }
        //sample PUBLIC to modify visibility of edit panel
        private void ModifyPanel_visibleOn()
        { ModifyPanel.Visible = true;  }
        //off
        private void ModifyPanel_visibleOff()
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
            switch (mode)
            {
                case 1: //admin
                    //edit student info
                    StudentInfoGrid.ReadOnly = false;
                    StudentInfoGrid.AllowUserToAddRows = true;
                    StudentInfoGrid.AllowUserToDeleteRows = true;
                    break;
                case 2: //professor
                    break;
                case 3: //student
                    //view registered courses
                    break;
                default: //invalid
                    break;
            }

            doneButton.Visible = true;
            deleteButton.Visible = true;
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case 1: //admin
                    //edit student info
                    StudentInfoGrid.ReadOnly = true;
                    break;
                case 2: //professor
                    break;
                case 3: //student
                    //view registered courses
                    break;
                default: //invalid
                    break;
            }
            //save record to database?
            doneButton.Visible = false;
            deleteButton.Visible = false;
        }

        private void registerCoursesButton_Click(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn dbColumn = new DataGridViewCheckBoxColumn();
            //go to register courses form
            StudentInfoGrid.DataSource = LMS_Db_Connection.Instance.getEligibleClasses().Tables[0]; //Set the data source with info from database
            StudentInfoGrid.Columns.Add(dbColumn); //new column=check box column
            StudentInfoGrid.Columns[0].Visible = false; //Hide the course ID, will refrence this when enrolling user later
            StudentInfoGrid.Columns[1].DisplayIndex = 2; //Class names listed last
            StudentInfoGrid.Columns[2].DisplayIndex = 1; //Checkmark listed first
            StudentInfoGrid.Columns[2].Width = 50; //make checkmark field less wide
            StudentInfoGrid.Visible = true;
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            //go to change password form/ or open modal
        }
        //test data source
        DataTable table = new DataTable();
        private void dataTable()
        {
            //add columns
            table.Columns.Add("Student", typeof(string));
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Registered Courses", typeof(string));
            //string or int
            table.Columns.Add("Exam Scores", typeof(string));
            table.Columns.Add("GPA", typeof(double));
            //Student, ID, reg. courses, Exam Scores, GPA
            //read in data here (if by file)
            table.Rows.Add("Fred" + " " + "Weasley", 90043, "Charms" + Environment.NewLine + "Potions" + Environment.NewLine + "Herbology", "B+",3.0);
            table.Rows.Add("George" + " " + "Weasley", 90044, "Divination" + Environment.NewLine + "Herbology", "B-", 2.75);
            //
            StudentInfoGrid.DataSource = table;
        }
  
        private void deleteButton_Click(object sender, EventArgs e)
        {
            //currently delete one entry at time
            int rowIndex = StudentInfoGrid.CurrentCell.RowIndex;
            StudentInfoGrid.Rows.RemoveAt(rowIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < StudentInfoGrid.Rows.Count; i++)
            {
                if (StudentInfoGrid.Rows[i].Cells[0].Value != null) //If not checked, value will be null, not false
                {
                    //MessageBox.Show(StudentInfoGrid.Rows[i].Cells[0].Value.ToString()); //this should be true since it wasn't null
                    //To do: call database method to enroll user in class
                }
            }
        }
    }
}
