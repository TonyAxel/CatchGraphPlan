using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CatchGraphPlan.PM;
using CatchGraphPlan.Role;

namespace CatchGraphPlan
{
    public partial class FormCaptureAnimalAdd : Form
    {
        public FormCaptureAnimalAdd()
        {
            InitializeComponent();
        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            var form = new FormCaptyreAnimal();

            this.Hide();

            form.Show();
        }
    }
}
