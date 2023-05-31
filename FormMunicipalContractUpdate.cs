using System;
using System.Windows.Forms;

namespace CatchGraphPlan
{
    public partial class FormMunicipalContractUpdate : Form
    {
        public FormMunicipalContractUpdate()
        {
            InitializeComponent();
        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            var form = new FormMunicipalContract();

            this.Hide();

            form.Show();
        }
    }
}
