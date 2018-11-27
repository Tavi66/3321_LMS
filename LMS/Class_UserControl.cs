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
    public partial class Class_UserControl : UserControl
    {
        Dashboard dashboard = (Dashboard)Application.OpenForms["Dashboard"];
        private static Class_UserControl _instance;
        private int courseId;
        private string courseDesc;

        public int CourseId
        {
            get
            {
                return courseId;
            }
            set
            {
                courseId = value;
            }
        }
        public string CourseDesc
        {
            get
            {
                return CourseDesc;
            }
            set
            {
                courseDesc = value;
                txtCourseDesc.Text = value;
            }
        }
        public static Class_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Class_UserControl();
                }
                return _instance;
            }
        }
        public Class_UserControl()
        {
            InitializeComponent();
        }

        public void refreshAssignmentsDataTable()
        {
            dgvAssignments.Rows.Clear();
            dgvAssignments.Refresh();
            DataTable assignmentTable = LMS_Db_Connection.Instance.getAssignmentsForClass(courseId).Tables[0];
            for (int x = 0; x < assignmentTable.Rows.Count; x++)
            {
                if (LMS_Db_Connection.Instance.UserRole == 4)
                {
                    if (LMS_Db_Connection.Instance.AssignmentGraded(assignmentTable.Rows[x].Field<Int32>(0)))
                    {
                        dgvAssignments.Rows.Add(
                            assignmentTable.Rows[x].Field<Int32>(0),
                            assignmentTable.Rows[x].Field<Int32>(1),
                            assignmentTable.Rows[x].Field<String>(2),
                            LMS_Db_Connection.Instance.GetAssignmentGrade(assignmentTable.Rows[x].Field<Int32>(0))
                         );
                    }
                    else
                    {
                        dgvAssignments.Rows.Add(
                            assignmentTable.Rows[x].Field<Int32>(0),
                            assignmentTable.Rows[x].Field<Int32>(1),
                            assignmentTable.Rows[x].Field<String>(2),
                            ""
                         );
                    }
                }
                else if (LMS_Db_Connection.Instance.UserRole == 3)
                {
                    dgvAssignments.Rows.Add(
                        assignmentTable.Rows[x].Field<Int32>(0),
                        assignmentTable.Rows[x].Field<Int32>(1),
                        assignmentTable.Rows[x].Field<String>(2),
                        ""
                    );
                }
            }
            if (LMS_Db_Connection.Instance.UserRole == 3)
            {
                dgvAssignments.Columns["Grade"].Visible = false;
                dgvAssignments.Columns["GradeBtn"].Visible = true;
                dgvAssignments.Columns["Delete"].Visible = true;
                dgvAssignments.Columns["TurnIn"].Visible = false;
                pnlAddAssignment.Visible = true;
            }
            else if (LMS_Db_Connection.Instance.UserRole == 4)
            {
                dgvAssignments.Columns["Grade"].Visible = true;
                dgvAssignments.Columns["GradeBtn"].Visible = false;
                dgvAssignments.Columns["Delete"].Visible = false;
                dgvAssignments.Columns["TurnIn"].Visible = true;
                pnlAddAssignment.Visible = false;
            }
        }

        private void Class_UserControl_Load(object sender, EventArgs e)
        {
            refreshAssignmentsDataTable();
        }

        private void btnAddAssignment_Click(object sender, EventArgs e)
        {
            int totalPoints;
            if (int.TryParse(txtTotalPoints.Text, out totalPoints) && txtDesc.Text != String.Empty)
            {
                LMS_Db_Connection.Instance.CreateAssignment(this.courseId, totalPoints, txtDesc.Text);
            }
            txtTotalPoints.Text = String.Empty;
            txtDesc.Text = String.Empty;
            refreshAssignmentsDataTable();
        }

        private void dgvAssignments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 4) //Grade assignment column
            {
                Grades_UserControl.Instance.CourseId = this.courseId;
                Grades_UserControl.Instance.AssignmentId = (int)dgvAssignments.Rows[e.RowIndex].Cells[0].Value;
                Grades_UserControl.Instance.AssignmentDesc = dgvAssignments.Rows[e.RowIndex].Cells[0].Value.ToString();
                dashboard.Grades_BringToFront();   
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == 5) //Delete assignments column
            {
                LMS_Db_Connection.Instance.DeleteAssignment((int)dgvAssignments.Rows[e.RowIndex].Cells[0].Value);
                MessageBox.Show("Assignment deleted.");
                refreshAssignmentsDataTable();
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == 6) //Turn in column
            {
                LMS_Db_Connection.Instance.TurnInAssignment((int)dgvAssignments.Rows[e.RowIndex].Cells[0].Value);
                MessageBox.Show("Assignment turned in.");
            }
        }
    }
}
