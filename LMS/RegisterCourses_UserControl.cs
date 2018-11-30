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
        List<int> userIDs = new List<int>();

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

        public void UpdateUsers()
        {
            userIDs.Clear();
            cboUsers.Items.Clear();
            if (LMS_Db_Connection.Instance.UserRole == 2)
            {
                DataTable userTable = LMS_Db_Connection.Instance.getUsers().Tables[0];
                for (int x = 0; x < userTable.Rows.Count; x++)
                {
                    if (userTable.Rows[x].Field<bool>(1))
                    {
                        cboUsers.Items.Add(userTable.Rows[x].Field<String>(2));
                        userIDs.Add(userTable.Rows[x].Field<int>(0));
                    }
                }
                cboUsers.Visible = true;
            }
            else
            {
                cboUsers.Visible = false;
            }
            cboUsers.Text = String.Empty;
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvEnrollCourses.Rows.Count; i++)
            {
                if ((bool)dgvEnrollCourses.Rows[i].Cells[0].Value == true) //
                {
                    if (cboUsers.Text != String.Empty)
                    {
                        if (!LMS_Db_Connection.Instance.IsEnrolled((int)dgvEnrollCourses.Rows[i].Cells[1].Value, userIDs[cboUsers.SelectedIndex]))
                        {
                            LMS_Db_Connection.Instance.Enroll_Course((int)dgvEnrollCourses.Rows[i].Cells[1].Value, userIDs[cboUsers.SelectedIndex]);
                        }
                    }
                    else
                    {
                        if (!LMS_Db_Connection.Instance.IsEnrolled((int)dgvEnrollCourses.Rows[i].Cells[1].Value))
                        {
                            LMS_Db_Connection.Instance.Enroll_Course((int)dgvEnrollCourses.Rows[i].Cells[1].Value);
                        }
                    }
                }
                else
                {
                    if (cboUsers.Text != String.Empty)
                    {
                        LMS_Db_Connection.Instance.Unenroll_Course((int)dgvEnrollCourses.Rows[i].Cells[1].Value, userIDs[cboUsers.SelectedIndex]);
                    }
                    else
                    {
                        LMS_Db_Connection.Instance.Unenroll_Course((int)dgvEnrollCourses.Rows[i].Cells[1].Value);
                    }
                }
            }
            MessageBox.Show("Enrollments Updated.");
            dashboard.btnHome.PerformClick();
        }

        public void refreshCourseRegistrationDataTable()
        {
            DataTable dashboardTable;
            dgvEnrollCourses.Rows.Clear();
            dgvEnrollCourses.Refresh();
            if (cboUsers.Text != String.Empty)
            {
                dashboardTable = LMS_Db_Connection.Instance.getEligibleClasses(userIDs[cboUsers.SelectedIndex]).Tables[0];
            }
            else
            {
                dashboardTable = LMS_Db_Connection.Instance.getEligibleClasses().Tables[0];
            }
            if (LMS_Db_Connection.Instance.UserRole == 2 && cboUsers.Text != String.Empty)
            {
                for (int x = 0; x < dashboardTable.Rows.Count; x++)
                {
                    if (cboUsers.Text != String.Empty)
                    {
                        dgvEnrollCourses.Rows.Add(
                            LMS_Db_Connection.Instance.IsEnrolled(dashboardTable.Rows[x].Field<Int32>(0), userIDs[cboUsers.SelectedIndex]),
                            dashboardTable.Rows[x].Field<Int32>(0),
                            dashboardTable.Rows[x].Field<String>(1)
                        );
                    }
                    else
                    {
                        dgvEnrollCourses.Rows.Add(
                            LMS_Db_Connection.Instance.IsEnrolled(dashboardTable.Rows[x].Field<Int32>(0)),
                            dashboardTable.Rows[x].Field<Int32>(0),
                            dashboardTable.Rows[x].Field<String>(1)
                        );
                    }
                }
            }
            else if (LMS_Db_Connection.Instance.UserRole == 4)
            {
                for (int x = 0; x < dashboardTable.Rows.Count; x++)
                {
                    dgvEnrollCourses.Rows.Add(
                        LMS_Db_Connection.Instance.IsEnrolled(dashboardTable.Rows[x].Field<Int32>(0)),
                        dashboardTable.Rows[x].Field<Int32>(0),
                        dashboardTable.Rows[x].Field<String>(1)
                    );
                }
            }
        }
        private void RegisterCourses_UserControl_Load(object sender, EventArgs e)
        {
            
        }

        private void dgvEnrollCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshCourseRegistrationDataTable();
        }
    }
}
