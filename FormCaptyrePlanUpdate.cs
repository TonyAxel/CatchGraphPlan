using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
