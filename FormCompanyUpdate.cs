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
using CatchGraphPlan.DataBase;
using CatchGraphPlan.PM;
using CatchGraphPlan.Role;

namespace CatchGraphPlan
{
    public partial class FormCompanyUpdate : Form
    {
        PermissionsManager pm = PermManFactory.getInstance();
        DB db = new DB();
        int id;
        CompanyController companyController = new CompanyController();
        public FormCompanyUpdate()
        {
            InitializeComponent();
        }

        public FormCompanyUpdate(int id)
        {
            InitializeComponent();
            this.id = id;
            Company company = db.getCompanyId(id);

            if (pm.canEditRegister(new Company()))
            {
                Type.DisplayMember = "Text";
                Type.ValueMember = "Value";

                Sign.DisplayMember = "Text";
                Sign.ValueMember = "Value";

                var itemsSign = new[] {
                    new {Text = "Физ. лица", Value = 1},
                    new {Text = "Юр. лица", Value = 2},

                };
                if (pm.Account.role.name == "Куратор ОМСУ" || pm.Account.role.name == "Подписант ОМСУ")
                {
                    var itemsType = new[] {
                    new {Text = "Исполнительный орган гос. власти", Value = 1},
                    new {Text = "Орган местного самоуправления", Value = 2},
                    new {Text = "Ветеринарная клиника: государственная", Value = 7},
                    };
                    Type.DataSource = itemsType;
                }
                if (pm.Account.role.name == "Оператор ОМСУ" || pm.Account.role.name == "Оператор ВетСлужбы")
                {
                    var itemsType = new[] {
                    new {Text = "Приют", Value = 3},
                    new {Text = "Организация по отлову", Value = 4},
                    new {Text = "Организация по отлову и приют", Value = 5},
                    new {Text = "Организация по транспортировке", Value = 6},
                    new {Text = "Ветеринарная клиника: государственная", Value = 7},
                    new {Text = "Ветеринарная клиника: частная", Value = 9},
                    new {Text = "Благотворительный фонд", Value = 10},
                    new {Text = "Организация по продаже товаров и предоставлению услуг для животных", Value = 11},
                    };
                    Type.DataSource = itemsType;
                }
                Sign.DataSource = itemsSign;
                BTNBack.Hide();
            }
            else
            {
                Type.DisplayMember = "Text";
                Type.ValueMember = "Value";

                Sign.DisplayMember = "Text";
                Sign.ValueMember = "Value";

                var itemsType = new[] {
                    new {Text = company.companyType.name, Value = company.companyType.id},
                };

                var itemsSign = new[] {
                    new {Text = company.companySign.name, Value = company.companySign.id},

                };
                NameOrg.Enabled = false;
                Inn.Enabled = false;
                Kpp.Enabled = false;
                AdressRegistration.Enabled = false;
                Type.Enabled = false;
                Sign.Enabled = false;
                BTNUpdate.Hide();
                Type.DataSource = itemsType;
                Sign.DataSource = itemsSign;

            }
            NameOrg.Text = company.name;
            Inn.Text = company.inn.ToString();
            Kpp.Text = company.kpp.ToString();
            AdressRegistration.Text = company.registrationAdress;
            Type.SelectedValue = company.companyType.id;
            Sign.SelectedValue = company.companySign.id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Company company = new Company(this.id, NameOrg.Text, Convert.ToInt32(Inn.Text), Convert.ToInt32(Kpp.Text), AdressRegistration.Text, new CompanyType(Convert.ToInt32(Type.SelectedValue), Type.Text), new CompanySign(Convert.ToInt32(Sign.SelectedValue), Sign.Text));
                companyController.updateCompany(company);

                var form = new FormCompany();

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
            var form = new FormCompany();

            this.Hide();

            form.Show();
        }
    }
}
