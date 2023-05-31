using System;
using System.Windows.Forms;


namespace CatchGraphPlan
{
    public partial class FormCaptyrePlanUpdate : Form
    {
        public FormCaptyrePlanUpdate()
        {
            InitializeComponent();
        }

        private void BTNUpdate_Click(object sender, EventArgs e)
        {
            var form = new FormCapturePlan();

            this.Hide();

            form.Show();
        }
    }
}
