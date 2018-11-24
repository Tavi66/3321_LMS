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

        private void TeacherDashboard_UserControl_Load(object sender, EventArgs e)
        {

        }

        public void refreshTeacherDashboardDataTable()
        {
            TeacherDashInfo.Rows.Clear();
            TeacherDashInfo.Refresh();
            DataTable dashboardTable = LMS_Db_Connection.Instance.getEnrolledCourses().Tables[0];
            if (LMS_Db_Connection.Instance.UserRole == 3)
            {
                for (int x = 0; x < dashboardTable.Rows.Count; x++)
                {
                    TeacherDashInfo.Rows.Add(
                        dashboardTable.Rows[x].Field<Int32>(0),
                        dashboardTable.Rows[x].Field<String>(1)
                    );
                }
            }
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
