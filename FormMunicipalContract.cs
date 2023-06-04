using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CatchGraphPlan.Capture;
using CatchGraphPlan.Controllers;
using CatchGraphPlan.PM;
using CatchGraphPlan.Role;

namespace CatchGraphPlan
{
    public partial class FormMunicipalContract : Form
    {
        PermissionsManager pm = PermManFactory.getInstance();
        CaptureMunicipalContractController controller = new CaptureMunicipalContractController();

        public FormMunicipalContract()
        {
            InitializeComponent();

            if (pm.canEditRegister(new CaptureMunicipalContract()))
            {
                List<CaptureMunicipalContract> mynicipalities = controller.getMunicipalContract();
                
                foreach(CaptureMunicipalContract value in mynicipalities)
                {
                    dataGridView1.Rows.Add(value.id, value.id, value.sign_date.ToUniversalTime().AddDays(1).ToString("dd.MM.yyyy"), value.action_date.ToUniversalTime().AddDays(1).ToString("dd.MM.yyyy"), value.contractor_company.name, value.customer.name);
                }
            }
            else
            {
                BTNAdd.Enabled = false;
                BTNDelete.Enabled = false;
                List<CaptureMunicipalContract> mynicipalities = controller.getMunicipalContract();

                foreach (CaptureMunicipalContract value in mynicipalities)
                {
                    dataGridView1.Rows.Add(value.id, value.id, value.sign_date.ToUniversalTime().AddDays(1).ToString("dd.MM.yyyy"), value.action_date.ToUniversalTime().AddDays(1).ToString("dd.MM.yyyy"), value.contractor_company.name, value.customer.name);
                }
            }

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
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
            var form = new FormMunicipalContractUpdate(id);

            this.Hide();

            form.Show();
        }
    }
}
