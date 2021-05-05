using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsertCreatorApp.Ui
{
    public partial class AutogenPane : Form
    {
        public ControllerGUI controllerGUI;
        public AutogenPane()
        {
            controllerGUI = new ControllerGUI();
            InitializeComponent();
        }

        private void bt_generateAction_Click(object sender, EventArgs e)
        {
            int nd = int.Parse(nud_departments.Value.ToString()); 
            int ne = int.Parse(nud_employee.Value.ToString()); 
            int np = int.Parse(nud_project.Value.ToString()); 
            int nw = int.Parse(nud_works.Value.ToString());

            controllerGUI.generate(nd, ne, np, nw);

            nud_departments.Value = 0;
            nud_employee.Value = 0;
            nud_project.Value = 0;
            nud_works.Value = 0;
        }
        private void check()
        {
            int nd = int.Parse(nud_departments.Value.ToString());
            int ne = int.Parse(nud_employee.Value.ToString());
            int np = int.Parse(nud_project.Value.ToString());
            if (nd > 12)
            {
                nud_departments.Value = 12;
                nd = 12;
            }
            if (nd == 0)
            {
                bt_generateAction.Enabled = false;
                nud_employee.Value = 0;
                nud_project.Value = 0;
                nud_works.Value = 0;
            }else if (ne < nd)
            {
                ne = nd;
                nud_employee.Value = nd;
            }
            if (ne == 0)
            {
                nud_project.Value = 0;
                nud_works.Value = 0;
            }
            if (np == 0)
            {
                nud_works.Value = 0;
            }
            if (nd != 0)
            {
                bt_generateAction.Enabled = true;
            }
        }
        private void nud_departments_ValueChanged(object sender, EventArgs e)
        {
            check();
        }

        private void nud_employee_ValueChanged(object sender, EventArgs e)
        {
            check();
        }

        private void nud_project_ValueChanged(object sender, EventArgs e)
        {
            check();
        }

        private void nud_works_ValueChanged(object sender, EventArgs e)
        {
            check();
        }
    }
}
