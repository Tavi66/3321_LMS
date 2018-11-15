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
    public partial class Assignments : Form
    {
        Dashboard dashboard;

        public Assignments()
        {
            InitializeComponent();
        }

        private int mode = 0;

        public void setMode(int privilege)
        {
            mode = privilege;
            switch (mode)
            {

                case 3: //professor
                    professorPanel_visibleOn();
                    //assignmentsDataTable();
                    break;
                case 4: //student

                    break;
                default: //invalid
                    break;
            }
        }

        private void professorPanel_visibleOn()
        {
            profAssignmentsPanel.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if(dashboard == null)
            {
                dashboard = new Dashboard();
            }
        }
        //private void studentPanel_visibleOn()
        //{
        //    studAssignmentsPanel.Visible = true;
        //}
    }
}
