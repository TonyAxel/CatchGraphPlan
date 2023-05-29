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
    public partial class FormCaptyreAct : Form
    {
        PM.PM pm;
        public FormCaptyreAct(PM.PM pm)
        {
            InitializeComponent();
            this.pm = pm;
        }

        private void реестрПлановГрафиковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormCapturePlan(pm);

            this.Hide();

            form.Show();
        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            var form = new FormCaptyreActAdd(pm);

            this.Hide();

            form.Show();
        }

        private void BTNUpdate_Click(object sender, EventArgs e)
        {
            var form = new FormCaptyreActUpdate(pm);

            this.Hide();

            form.Show();
        }

        private void карточкиОтловленныхЖивотныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormCaptyreAnimal(pm);

            this.Hide();

            form.Show();
        }

        private void реестрОрганизацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormCompany(pm);

            this.Hide();

            form.Show();
        }

        private void реестрМуниципальныхКонтрактовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormMunicipalContract(pm);

            this.Hide();

            form.Show();
        }
    }
}
