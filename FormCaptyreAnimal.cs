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
    public partial class FormCaptyreAnimal : Form
    {
        PM.PM pm;
        public FormCaptyreAnimal(PM.PM pm)
        {
            InitializeComponent();
            this.pm = pm;
        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            var form = new FormCaptureAnimalAdd(pm);

            this.Hide();

            form.Show();
        }

        private void реестрПлановГрафиковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormCapturePlan(pm);

            this.Hide();

            form.Show();
            
        }

        private void реестрАктовОтловаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormCaptyreAct(pm);

            this.Hide();

            form.Show();
        }

        private void BTNUpdate_Click(object sender, EventArgs e)
        {
            var form = new FormCaptyreAnimalUpdate(pm);

            this.Hide();

            form.Show();
        }

        private void реестрОрганизацийToolStripMenuItem_Click(object sender, EventArgs e)
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
