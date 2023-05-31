using System;
using System.Windows.Forms;


namespace CatchGraphPlan
{
    public partial class FormCaptyreActUpdate : Form
    {
        public FormCaptyreActUpdate()
        {
            InitializeComponent();
        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            var form = new FormCaptyreAct();

            this.Hide();

            form.Show();
        }
    }
}
