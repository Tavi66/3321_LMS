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
                case 1: //super
                    break;
                case 2: //admin
                    adminPanel_visibleOn();
                    ModifyPanel_visibleOn();
                    //test data studentInfoTable
                    stdInfoDataTable();
                    break;
                case 3: //professor
                    professorPanel_visibleOn();
                    ModifyPanel_visibleOn();
                    //assignmentsDataTable();
                    break;
                case 4: //student
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
        private void professorPanel_visibleOn()
        {
            assignmentsButton.Visible = true;
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
                    StudentInfoGrid.ReadOnly = false;
                    StudentInfoGrid.AllowUserToAddRows = true;
                    StudentInfoGrid.AllowUserToDeleteRows = true;
                    break;
                case 3: //professor
                    break;
                case 4: //student
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
                case 1: //super
                    break;
                case 2: //admin
                    //edit student info
                    StudentInfoGrid.ReadOnly = true;
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
            doneButton.Visible = false;
            deleteButton.Visible = false;
        }

        private void registerCoursesButton_Click(object sender, EventArgs e)
        {
            //go to register courses form
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            //go to change password form/ or open modal
        }
        //test data source
        DataTable studentInfoTable = new DataTable();
        DataTable createAssignmentsTable = new DataTable();

        private void stdInfoDataTable()
        {
            //STUDENT INFO TABLE
            //add columns
            studentInfoTable.Columns.Add("Student", typeof(string));
            studentInfoTable.Columns.Add("ID", typeof(int));
            studentInfoTable.Columns.Add("Registered Courses", typeof(string));
            //string or int
            studentInfoTable.Columns.Add("Exam Scores", typeof(string));
            studentInfoTable.Columns.Add("GPA", typeof(double));
            //Student, ID, reg. courses, Exam Scores, GPA
            //read in data here (if by file)
            studentInfoTable.Rows.Add("Fred" + " " + "Weasley", 90043, "Charms" + Environment.NewLine + "Potions" + Environment.NewLine + "Herbology", "B+",3.0);
            studentInfoTable.Rows.Add("George" + " " + "Weasley", 90044, "Divination" + Environment.NewLine + "Herbology", "B-", 2.75);

            StudentInfoGrid.DataSource = studentInfoTable;
        }
        //private void assignmentsDataTable()
        //{
        //    ComboBox coursesList = new System.Windows.Forms.ComboBox();
        //    string[] courses = new string[] { "Charms", "Divination", "Potions" };
        //    coursesList.Items.AddRange(courses);
        //    coursesList.DropDownStyle = ComboBoxStyle.DropDownList;
        //    //CREATE ASSIGNMENTS TABLE
        //    //Left panel (add assignments)
        //    //select item to move to right panel
        //    createAssignmentsTable.Columns.Add("Assignment", typeof(string));
        //    createAssignmentsTable.Columns.Add("Description", typeof(string));
        //    //createAssignmentsTable.Columns.Add("Due Date", typeof(DateTimePicker));
        //    //... supposedly a dropbox... 
        //    createAssignmentsTable.Columns.Add("Course", typeof(ComboBox));
        //    //
        //    createAssignmentsTable.Rows.Add("x", "x", coursesList);
        //    //right panel (delete assigned assignments)
        //    //can modify assignments?
        //    //
        //    createAssignmentsGrid.DataSource = createAssignmentsTable;
        //}

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //currently delete one entry at time
            int rowIndex = 0;
            switch (mode)
            {
                case 2: //admin
             rowIndex = StudentInfoGrid.CurrentCell.RowIndex;
            StudentInfoGrid.Rows.RemoveAt(rowIndex);
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

        //Add click event handler to assignments button
        private void assignmentsButton_Click(object sender, EventArgs e)
        {
            Assignments assignments = new Assignments();
            assignments.setMode(mode);
            this.Hide();
            assignments.Show();
        }
        // > button click to move new assignment to assigned assignments
    }
}
