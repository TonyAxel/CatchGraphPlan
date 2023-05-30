using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CatchGraphPlan.PM;
using CatchGraphPlan.Capture;
using CatchGraphPlan.DataBase;
using CatchGraphPlan.Controllers;
using Excel = Microsoft.Office.Interop.Excel;

namespace CatchGraphPlan
{
    public partial class FormCompany : Form
    {
        PM.PM pm;
        CompanyController companyController = new CompanyController();
        string role;

        public FormCompany(PM.PM pm)
        {
            InitializeComponent();
            this.pm = pm;

            Filter.DisplayMember = "Text";
            Filter.ValueMember = "Value";

            Sort.DisplayMember = "Text";
            Sort.ValueMember = "Value";

            var itemsFilter = new[] {
                    new {Text = "Нет", Value = ""},
                    new {Text = "Физ. лица", Value = "company_sign = 2"},
                    new {Text = "Юр. лица", Value = "company_sign = 3"},
                };

            var itemsSort = new[] {
                    new {Text = "Нет", Value = ""},
                    new {Text = "По названию", Value = "name ASC"},
                };

            Filter.DataSource = itemsFilter;
            Sort.DataSource = itemsSort;

            if (pm.canEditRegister(new Company()) == "Просмотр")
            {
                this.role = "Просмотр";
                BTNAdd.Enabled = false;
                BTNDelete.Enabled = false;
                BTNUpdate.Enabled = false;
                string filter = Filter.SelectedValue.ToString() == "" ? null : Filter.SelectedValue.ToString();
                string sort = Sort.SelectedValue.ToString() == "" ? null : Sort.SelectedValue.ToString();
                List <Company> listCompany = companyController.getCompany(filter: filter, sort: sort);
                foreach(Company company in listCompany)
                {
                    dataGridView1.Rows.Add(company.id,company.name, company.inn, company.kpp, company.registrationAdress, company.companyType.name, company.companySign.name);
                }

            }
            if(pm.canEditRegister(new Company()) == "Куратор ОМСУ")
            {
                this.role = "Куратор ОМСУ";

                BTNAdd.Enabled = false;
                BTNDelete.Enabled = false;
                BTNUpdate.Enabled = false;
                string filter = Filter.SelectedValue.ToString() == "" ? null : Filter.SelectedValue.ToString();
                string sort = Sort.SelectedValue.ToString() == "" ? null : Sort.SelectedValue.ToString();
                List<Company> listCompany = companyController.getCompany(pm, filter, sort);
                foreach (Company company in listCompany)
                {
                    dataGridView1.Rows.Add(company.id, company.name, company.inn, company.kpp, company.registrationAdress, company.companyType.name, company.companySign.name);
                }
            }
            else
            {
                this.role = "all";
                string filter = Filter.SelectedValue.ToString() == "" ? null : Filter.SelectedValue.ToString();
                string sort = Sort.SelectedValue.ToString() == "" ? null : Sort.SelectedValue.ToString();
                List<Company> listCompany = companyController.getCompany(filter: filter, sort: sort);
                foreach (Company company in listCompany)
                {
                    dataGridView1.Rows.Add(company.id, company.name, company.inn, company.kpp, company.registrationAdress, company.companyType.name, company.companySign.name);
                }
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
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);

            var form = new FormCompanyUpdate(pm, id);

            this.Hide();

            form.Show();
        }

        private void BTNDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
            string name = dataGridView1.CurrentRow.Cells["name"].Value.ToString();
            int inn = Convert.ToInt32(dataGridView1.CurrentRow.Cells["inn"].Value);
            int kpp = Convert.ToInt32(dataGridView1.CurrentRow.Cells["kpp"].Value);
            string registrationAdress = dataGridView1.CurrentRow.Cells["registration_adress"].Value.ToString();
            CompanySign sign = new CompanySign(0, dataGridView1.CurrentRow.Cells["sign"].Value.ToString());
            CompanyType type = new CompanyType(0, dataGridView1.CurrentRow.Cells["type"].Value.ToString());

            try
            {
                Company company = new Company(id, name, inn, kpp, registrationAdress, type, sign);
                companyController.deleteCompany(company);
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
            catch 
            {
                MessageBox.Show("Не удалось удалить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNExportExcel_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();

            exApp.Workbooks.Add();

            Excel.Worksheet worksheet = (Excel.Worksheet)exApp.ActiveSheet;

            int i, j;

            for(i = 2; i <= dataGridView1.RowCount + 1; i++)
            {
                for(j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                {
                    worksheet.Cells[1, j + 1] = dataGridView1.Columns[j].HeaderText.ToString();
                    worksheet.Cells[i, j + 1] = dataGridView1[j, i - 2].Value.ToString();
                }
            }

            exApp.Visible = true;
        }

        private void BTNAccept_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (role == "Просмотр")
            {
                string filter = Filter.SelectedValue.ToString() == "" ? null : Filter.SelectedValue.ToString();
                string sort = Sort.SelectedValue.ToString() == "" ? null : Sort.SelectedValue.ToString();
                List<Company> listCompany = companyController.getCompany(filter: filter, sort: sort);
                foreach (Company company in listCompany)
                {
                    dataGridView1.Rows.Add(company.id, company.name, company.inn, company.kpp, company.registrationAdress, company.companyType.name, company.companySign.name);

                }

            }
            if (role == "Куратор ОМСУ")
            {

                string filter = Filter.SelectedValue.ToString() == "" ? null : Filter.SelectedValue.ToString();
                string sort = Sort.SelectedValue.ToString() == "" ? null : Sort.SelectedValue.ToString();
                List<Company> listCompany = companyController.getCompany(pm, filter, sort);
                foreach (Company company in listCompany)
                {
                    dataGridView1.Rows.Add(company.id, company.name, company.inn, company.kpp, company.registrationAdress, company.companyType.name, company.companySign.name);
                }
            }
            else
            {
                string filter = Filter.SelectedValue.ToString() == "" ? null : Filter.SelectedValue.ToString();
                string sort = Sort.SelectedValue.ToString() == "" ? null : Sort.SelectedValue.ToString();
                List<Company> listCompany = companyController.getCompany(filter: filter, sort: sort);
                foreach (Company company in listCompany)
                {
                    dataGridView1.Rows.Add(company.id, company.name, company.inn, company.kpp, company.registrationAdress, company.companyType.name, company.companySign.name);
                }
            }
        }
    }
}
