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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StudentDashboard_UserControl_Load(object sender, EventArgs e)
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

        private void StudentDashInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                MessageBox.Show("Going to class: " + StudentDashInfo.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
        }
    }
}
