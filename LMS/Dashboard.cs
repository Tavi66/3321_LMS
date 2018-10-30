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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }



        //sample PUBLIC to modify visibility of edit panel
        public void ModifyPanel_visibleOn()
        { ModifyPanel.Visible = true; }
        //off
        public void ModifyPanel_visibleOff()
        { ModifyPanel.Visible = false; }
    }
}
