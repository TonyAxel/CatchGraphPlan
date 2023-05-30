using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CatchGraphPlan.PM;

namespace CatchGraphPlan
{
    public partial class FormCaptureAnimalAdd : Form
    {
        PM.PM pm;
        public FormCaptureAnimalAdd(PM.PM pm)
        {
            InitializeComponent();
            this.pm = pm;
        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            var form = new FormCaptyreAnimal(pm);

            this.Hide();

            form.Show();
        }
    }
}
