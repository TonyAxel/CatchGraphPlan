using CatchGraphPlan.Capture;
using CatchGraphPlan.Controllers;
using CatchGraphPlan.DataBase;
using CatchGraphPlan.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CatchGraphPlan
{
    public partial class FormMunicipalContractUpdate : Form
    {
        PermissionsManager pm = PermManFactory.getInstance();
        CompanyController companyController = new CompanyController();
        CaptureMunicipalContractController captureMunicipalContractController = new CaptureMunicipalContractController();
        int id;
        public FormMunicipalContractUpdate(int id)
        {
            InitializeComponent();
            this.id = id;
            CaptureMunicipalContract municipalityContract = DB.query().getMunicipalContractId(id);
            contractor_company.DisplayMember = "Text";
            contractor_company.ValueMember = "Value";

            customer.DisplayMember = "Text";
            customer.ValueMember = "Value";
            if (pm.canEditRegister(new CaptureMunicipalContract()))
            {
                BTNBack.Hide();

                var list1 = new[]
                {
                    new {Text = "s", Value = 0}
                };

                var list2 = new[]
                {
                    new {Text = "s", Value = 0}
                };

                List<Company> companies = companyController.getCompany();

                foreach (Company company in companies)
                {
                    list1 = list1.Concat(new[]
                    {
                        new { Text = company.name, Value = Convert.ToInt32(company.id) }
                    }).ToArray();

                    list2 = list2.Concat(new[]
                    {
                        new { Text = company.name, Value = Convert.ToInt32(company.id) }
                    }).ToArray();

                }

                list1 = list1.Where((item, index) => index != 0).ToArray();
                list2 = list2.Where((item, index) => index != 0).ToArray();

                contractor_company.DataSource = list1;
                customer.DataSource = list2;

                if (municipalityContract.file == "None")
                {
                    label1.Text = "Нет файла";
                    BTNDeleteFile.Hide();
                }
                else
                {
                    label1.Text = "Файл: " + municipalityContract.file;
                    BTNAddFile.Hide();
                }
            }
            else
            {
                BTNUpdate.Hide();

                var list1 = new[]
                {
                    new {Text = "s", Value = 0}
                };

                var list2 = new[]
                {
                    new {Text = "s", Value = 0}
                };

                List<Company> companies = companyController.getCompany();

                foreach (Company company in companies)
                {
                    list1 = list1.Concat(new[]
                    {
                        new { Text = company.name, Value = Convert.ToInt32(company.id) }
                    }).ToArray();

                    list2 = list2.Concat(new[]
                    {
                        new { Text = company.name, Value = Convert.ToInt32(company.id) }
                    }).ToArray();

                }

                list1 = list1.Where((item, index) => index != 0).ToArray();
                list2 = list2.Where((item, index) => index != 0).ToArray();

                contractor_company.DataSource = list1;
                customer.DataSource = list2;
                sign_date.Enabled = false;
                action_date.Enabled = false;
                contractor_company.Enabled = false;
                customer.Enabled = false;

                label1.Hide();
                BTNAddFile.Hide();
                BTNDeleteFile.Hide();
            }
            sign_date.Value = municipalityContract.sign_date;
            action_date.Value = municipalityContract.action_date;
            contractor_company.SelectedValue = municipalityContract.contractor_company.id;
            customer.SelectedValue = municipalityContract.customer.id;
        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Company contractor_compan = new Company(Convert.ToInt32(contractor_company.SelectedValue), contractor_company.SelectedText, 1, 1, "s", new CompanyType(1, "s"), new CompanySign(1, "s"));
                Company customer_compan = new Company(Convert.ToInt32(customer.SelectedValue), customer.SelectedText, 1, 1, "s", new CompanyType(1, "s"), new CompanySign(1, "s"));
                CaptureMunicipalContract municipalContract = new CaptureMunicipalContract(id, sign_date.Value, action_date.Value, contractor_compan, customer_compan, new PM.Municipality(1, "s"));
                captureMunicipalContractController.updateMunicipalContract(municipalContract);
                var form = new FormMunicipalContract();

                this.Hide();

                form.Show();
            }
            catch 
            {
                MessageBox.Show("Не удалось обновить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNBack_Click(object sender, EventArgs e)
        {
            var form = new FormMunicipalContract();

            this.Hide();

            form.Show();
        }

        private void BTNAddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files | *.pdf"; // file types, that will be allowed to upload
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                String path = dialog.FileName; // get name of file

                string pathName = path.Split('\\').Last();

                try
                {
                    captureMunicipalContractController.setFile(new CaptureMunicipalContract(id, pathName));

                    label1.Text = pathName;
                    BTNDeleteFile.Show();
                    BTNAddFile.Hide();

                }
                catch
                {
                    MessageBox.Show("Не удалось добавить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void BTNDeleteFile_Click(object sender, EventArgs e)
        {
            try
            {
                captureMunicipalContractController.deleteFile(new CaptureMunicipalContract(id));

                label1.Text = "Нет файла";
                BTNDeleteFile.Hide();
                BTNAddFile.Show();
            }
            catch
            {
                MessageBox.Show("Не удалось удалить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
