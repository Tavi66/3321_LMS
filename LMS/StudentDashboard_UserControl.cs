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
    public partial class StudentDashboard_UserControl : UserControl
    {
        DataGridViewButtonColumn btnCol = null;
        Dashboard dashboard = (Dashboard)Application.OpenForms["Dashboard"];

        private static StudentDashboard_UserControl _instance;

        public static StudentDashboard_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new StudentDashboard_UserControl();
                }
                return _instance;
            }
        }
        public StudentDashboard_UserControl()
        {
            InitializeComponent();
        }

        public void Update_Dashboard()
        {
            if (LMS_Db_Connection.Instance.getEnrolledCourses() != null)
            {
                StudentDashInfo.DataSource = LMS_Db_Connection.Instance.getEnrolledCourses().Tables[0]; //Set the data source with info from database
                StudentDashInfo.Columns[0].Visible = false;
                StudentDashInfo.Columns[1].HeaderText = "Enrolled Courses";
                if (btnCol == null)
                {
                    btnCol = new DataGridViewButtonColumn();
                    btnCol.Name = "Go To Class";
                    btnCol.Text = "Go To Class";
                    btnCol.UseColumnTextForButtonValue = true;
                    StudentDashInfo.Columns.Add(btnCol);
                }
                StudentDashInfo.Visible = true;
            }
            //to do: else say not enrolled in anything
        }
        private void StudentDashboard_UserControl_Load(object sender, EventArgs e)
        {
            
        }

        private void StudentDashInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                Class_UserControl.Instance.CourseDesc = StudentDashInfo.Rows[e.RowIndex].Cells[1].Value.ToString();
                Class_UserControl.Instance.CourseId = int.Parse(StudentDashInfo.Rows[e.RowIndex].Cells[0].Value.ToString());
                dashboard.Class_BringToFront();
            }
        }
    }
}
