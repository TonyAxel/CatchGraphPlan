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
    public partial class FormMunicipalContractAdd : Form
    {
        PermissionsManager pm = PermManFactory.getInstance();
        CompanyController companyController = new CompanyController();
        CaptureMunicipalContractController captureMunicipalContractController = new CaptureMunicipalContractController();

        public FormMunicipalContractAdd()
        {
            InitializeComponent();

            contractor_company.DisplayMember = "Text";
            contractor_company.ValueMember = "Value";

            customer.DisplayMember = "Text";
            customer.ValueMember = "Value";
            if (pm.canEditRegister(new CaptureMunicipalContract()))
            {

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
            }
            else
            {

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
            }
        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Company contractor_compan = new Company(Convert.ToInt32(contractor_company.SelectedValue), contractor_company.SelectedText, 1, 1, "s", new CompanyType(1, "s"), new CompanySign(1, "s"));
                Company customer_compan = new Company(Convert.ToInt32(customer.SelectedValue), customer.SelectedText, 1, 1, "s", new CompanyType(1, "s"), new CompanySign(1, "s"));
                CaptureMunicipalContract municipalContract = new CaptureMunicipalContract(0, sign_date.Value, action_date.Value, contractor_compan, customer_compan, new PM.Municipality(1, "s"));
                captureMunicipalContractController.addMunicipalContract(municipalContract);
                
                var form = new FormMunicipalContract();

                this.Hide();

                form.Show();
            }
            catch
            {
                MessageBox.Show("Не удалось добавить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
