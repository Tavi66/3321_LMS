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
    public partial class TeacherDashboard_UserControl : UserControl
    {
        Dashboard dashboard = (Dashboard)Application.OpenForms["Dashboard"];
        private static TeacherDashboard_UserControl _instance;
        DataGridViewButtonColumn btnCol = null;

        public static TeacherDashboard_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TeacherDashboard_UserControl();
                }
                return _instance;
            }
        }
        public TeacherDashboard_UserControl()
        {
            InitializeComponent();
        }

        public void Update_Dashboard()
        {
            if (LMS_Db_Connection.Instance.getEnrolledCourses() != null)
            {
                
                TeacherDashInfo.DataSource = LMS_Db_Connection.Instance.getEnrolledCourses().Tables[0]; //Set the data source with info from database
                TeacherDashInfo.Columns[0].Visible = false;
                TeacherDashInfo.Columns[1].HeaderText = "Enrolled Courses";
                if (btnCol == null)
                {
                    btnCol = new DataGridViewButtonColumn();
                    btnCol.Name = "Go To Class";
                    btnCol.Text = "Go To Class";
                    btnCol.UseColumnTextForButtonValue = true;
                    TeacherDashInfo.Columns.Add(btnCol);
                }
                TeacherDashInfo.Visible = true;
            }
            //to do: else say not enrolled in anything
        }
        private void TeacherDashboard_UserControl_Load(object sender, EventArgs e)
        {

        }

        private void TeacherDashInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                Class_UserControl.Instance.CourseDesc = TeacherDashInfo.Rows[e.RowIndex].Cells[1].Value.ToString();
                Class_UserControl.Instance.CourseId = int.Parse(TeacherDashInfo.Rows[e.RowIndex].Cells[0].Value.ToString());
                dashboard.Class_BringToFront();
            }
        }
    }
}
