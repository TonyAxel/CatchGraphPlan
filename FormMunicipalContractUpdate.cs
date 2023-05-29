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
    public partial class FormMunicipalContractUpdate : Form
    {
        PM.PM pm;
        public FormMunicipalContractUpdate(PM.PM pm)
        {
            InitializeComponent();
            this.pm = pm;
        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            var form = new FormMunicipalContract(pm);

            this.Hide();

            form.Show();
        }
    }
}
