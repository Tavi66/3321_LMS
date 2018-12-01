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
    public partial class Users_UserControl : UserControl
    {
        private static Users_UserControl _instance;

        public static Users_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Users_UserControl();
                }
                return _instance;
            }
        }
        public Users_UserControl()
        {
            InitializeComponent();
        }

        private void Users_UserControl_Load(object sender, EventArgs e)
        {
            refreshUserDataTable();
        }

        private void refreshUserDataTable()
        {
            dgvUsers.Rows.Clear();
            dgvUsers.Refresh();
            DataTable userTable = LMS_Db_Connection.Instance.getUsers().Tables[0];
            for (int x = 0; x < userTable.Rows.Count; x++)
            {
                dgvUsers.Rows.Add(
                    userTable.Rows[x].Field<Int32>(0),
                    userTable.Rows[x].Field<bool>(1),
                    userTable.Rows[x].Field<String>(2),
                    userTable.Rows[x].Field<String>(3),
                    userTable.Rows[x].Field<String>(4),

                    userTable.Rows[x].Field<Nullable<Int32>>(5),
                    userTable.Rows[x].Field<String>(6)
                );
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < dgvUsers.RowCount; x++)
            {
                int year = -1;
                DataGridViewComboBoxCell cboCell = (DataGridViewComboBoxCell)dgvUsers.Rows[x].Cells[6];
                if (dgvUsers.Rows[x].Cells[5].Value != null)
                {
                    int.TryParse(dgvUsers.Rows[x].Cells[5].Value.ToString(), out year);
                }
                if (dgvUsers.Rows[x].Cells[7].Value != null)
                {
                    year += 1;
                }
                LMS_Db_Connection.Instance.Update_User(
                    int.Parse(dgvUsers.Rows[x].Cells[0].Value.ToString()),
                    (bool)dgvUsers.Rows[x].Cells[1].Value,
                    dgvUsers.Rows[x].Cells[2].Value.ToString(),
                    dgvUsers.Rows[x].Cells[3].Value.ToString(),
                    dgvUsers.Rows[x].Cells[4].Value.ToString(),
                    year,
                    LMS_Db_Connection.Instance.getRoleIdFromDesc(dgvUsers.Rows[x].Cells[6].Value.ToString())
                );
            }
            refreshUserDataTable();
            MessageBox.Show("Users Updated");
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            btnUpdate.PerformClick(); //in case there are outstanding updates to be made before adding user.
            if (cboRole.SelectedText == "Student")
                if (cboYear.SelectedText == "N/A")
                {
                    MessageBox.Show("You must select a year.");
                    return;
                }
            if (txtUserName.Text == String.Empty || txtPassword.Text == String.Empty || txtGivenName.Text == String.Empty || txtFamilyName.Text == String.Empty
                || cboRole.Text == String.Empty)
            {
                MessageBox.Show("Please enter all values.");
                return;
            }
            int Year = 0;
            if (cboRole.Text == "Student")
                Year = cboYear.SelectedIndex;
            int userID = LMS_Db_Connection.Instance.getNextUserId(cboRole.SelectedIndex + 1);
            if (userID != -1)
            {
                LMS_Db_Connection.Instance.Add_User(userID, txtUserName.Text, txtPassword.Text, txtGivenName.Text, txtFamilyName.Text, Year, cboRole.SelectedIndex + 1);
                txtUserName.Text = String.Empty;
                txtPassword.Text = String.Empty;
                txtGivenName.Text = String.Empty;
                txtFamilyName.Text = String.Empty;
                refreshUserDataTable();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
