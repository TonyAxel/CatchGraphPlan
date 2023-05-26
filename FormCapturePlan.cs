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
    public partial class FormCapturePlan : Form
    {
        public FormCapturePlan()
        {
            InitializeComponent();

            //реестрПлановГрафиковToolStripMenuItem.Visible = false;
        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            var form = new FormCaptyrePlanAdd();

            this.Hide();

            form.Show();
        }

        private void BTNUpdate_Click(object sender, EventArgs e)
        {
            var form = new FormCaptyrePlanUpdate();

            this.Hide();

            form.Show();
        }

        private void реестрАктовОтловаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormCaptyreAct();

            this.Hide();

            form.Show();
        }
    }
}
