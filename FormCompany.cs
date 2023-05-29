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
using CatchGraphPlan.Capture;
using CatchGraphPlan.DataBase;
using CatchGraphPlan.Controllers;

namespace CatchGraphPlan
{
    public partial class FormCompany : Form
    {
        PM.PM pm;
        DB db;
        CompanyController companyController = new CompanyController();

        public FormCompany(PM.PM pm)
        {
            InitializeComponent();
            this.pm = pm;
            if (pm.canEditRegister(new Company()) == "Просмотр")
            {
                BTNAdd.Enabled = false;
                BTNDelete.Enabled = false;
                BTNUpdate.Enabled = false;
                List<Company> listCompany = companyController.getCompany();
                dataGridView1.Rows.Add(listCompany);
                
            }
            if(pm.canEditRegister(new Company()) == "Куратор ОМСУ")
            {
                BTNAdd.Enabled = false;
                BTNDelete.Enabled = false;
                BTNUpdate.Enabled = false;
                List<Company> listCompany = companyController.getCompany(pm);
            }


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

        private void карточкаОтловленногоЖивотногоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormCaptyreAnimal(pm);

            this.Hide();

            form.Show();
        }

        private void реестрМуниципальныхКонтрактовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormMunicipalContract(pm);

            this.Hide();

            form.Show();
        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            var form = new FormCompanyAdd(pm);

            this.Hide();

            form.Show();
        }

        private void BTNUpdate_Click(object sender, EventArgs e)
        {
            var form = new FormCompanyUpdate(pm);

            this.Hide();

            form.Show();
        }
    }
}
