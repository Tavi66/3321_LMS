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
    public partial class Grades_UserControl : UserControl
    {
        private static Grades_UserControl _instance;
        private int assignmentId;
        private int courseId;
        private string assignmentDesc;
        public static Grades_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Grades_UserControl();
                }
                return _instance;
            }
        }

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
        public int AssignmentId
        {
            get
            {
                return assignmentId;
            }
            set
            {
                assignmentId = value;
            }
        }
        public string AssignmentDesc
        {
            get
            {
                return assignmentDesc;
            }
            set
            {
                assignmentDesc = value;
                txtAssignmentDesc.Text = assignmentDesc;
            }
        }

        public void refreshGradesDataTable()
        {
            dgvGrades.Rows.Clear();
            dgvGrades.Refresh();
            DataTable studentsTable = LMS_Db_Connection.Instance.getStudentsEnrrolledInClass(courseId).Tables[0];
            if (LMS_Db_Connection.Instance.UserRole == 3)
            {
                for (int x = 0; x < studentsTable.Rows.Count; x++)
                {
                    string turnedIn = "No";
                    if (LMS_Db_Connection.Instance.AssignmentTurnedIn(this.assignmentId, studentsTable.Rows[x].Field<Int32>(0)))
                    {
                        turnedIn = "Yes";
                    }
                    dgvGrades.Rows.Add(
                        studentsTable.Rows[x].Field<Int32>(0),
                        studentsTable.Rows[x].Field<String>(1) + " " + studentsTable.Rows[x].Field<String>(2),
                        turnedIn
                    );
                }
            }
        }
        public Grades_UserControl()
        {
            InitializeComponent();
        }

        private void dgvGrades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
