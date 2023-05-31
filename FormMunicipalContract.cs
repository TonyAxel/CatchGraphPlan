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
    public partial class FormMunicipalContract : Form
    {
        public FormMunicipalContract()
        {
            InitializeComponent();
        }

        private void реестрПлановГрафиковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormCapturePlan();

            this.Hide();

            form.Show();
        }

        private void реестрАктовОтловаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormCaptyreAct();

            this.Hide();

            form.Show();
        }

        private void карточкаОтловленногоЖивотногоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormCaptyreAnimal();

            this.Hide();

            form.Show();
        }

        private void реестрОрганизацийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormCompany();

            this.Hide();

            form.Show();
        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            var form = new FormMunicipalContractAdd();

            this.Hide();

            form.Show();
        }

        private void BTNUpdate_Click(object sender, EventArgs e)
        {
            var form = new FormMunicipalContractUpdate();

            this.Hide();

            form.Show();
        }
    }
}
