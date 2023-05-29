using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CatchGraphPlan.PM;


namespace CatchGraphPlan
{
    public partial class FormCaptyrePlanAdd : Form
    {
        PM.PM pm;
        public FormCaptyrePlanAdd(PM.PM pm)
        {
            InitializeComponent();
            this.pm = pm;
        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            var form = new FormCapturePlan(pm);

            this.Hide();

            form.Show();
        }
    }
}
