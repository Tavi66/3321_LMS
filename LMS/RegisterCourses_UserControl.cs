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
    public partial class RegisterCourses_UserControl : UserControl
    {
        Dashboard dashboard = (Dashboard)Application.OpenForms["Dashboard"];
        DataGridViewCheckBoxColumn cbColumn;

        private static RegisterCourses_UserControl _instance;

        public static RegisterCourses_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RegisterCourses_UserControl();
                }
                return _instance;
            }
        }
        public RegisterCourses_UserControl()
        {
            InitializeComponent();
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvEnrollCourses.Rows.Count; i++)
            {
                if (dgvEnrollCourses.Rows[i].Cells[0].Value != null) //If not checked, value will be null, not false
                {
                    LMS_Db_Connection.Instance.Enroll_Course((int)dgvEnrollCourses.Rows[i].Cells[1].Value);
                }
            }
            MessageBox.Show("You are enrolled.");
            dashboard.btnHome.PerformClick();
        }

        private void RegisterCourses_UserControl_Load(object sender, EventArgs e)
        {
            cbColumn = new DataGridViewCheckBoxColumn();
            dgvEnrollCourses.DataSource = LMS_Db_Connection.Instance.getEligibleClasses().Tables[0]; //Set the data source with info from database
            if (dgvEnrollCourses.Columns[0] != cbColumn)
            {
                dgvEnrollCourses.Columns.Insert(0, cbColumn); //new column=check box column
                dgvEnrollCourses.Columns[0].Width = 50; //make checkmark field less wide
            }
            dgvEnrollCourses.Columns[1].Visible = false; //Hide the course ID, will refrence this when enrolling user later
            dgvEnrollCourses.Columns[2].ReadOnly = true;
        }

        private void dgvEnrollCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
