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
using CatchGraphPlan.Controllers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CatchGraphPlan
{
    public partial class FormCompanyAdd : Form
    {
        PM.PM pm;
        CompanyController companyController = new CompanyController();
        public FormCompanyAdd(PM.PM pm)
        {
            InitializeComponent();
            this.pm = pm;
            if(pm.canEditRegister(new Company()) == "Оператор ВетСлужбы")
            {
                Type.DisplayMember = "Text";
                Type.ValueMember = "Value";

                Sign.DisplayMember = "Text";
                Sign.ValueMember = "Value";

                var itemsType = new[] {
                    new {Text = "Исполнительный орган гос. власти", Value = 1},
                    new {Text = "Орган местного самоуправления", Value = 2},
                    new {Text = "Ветеринарная клиника: государственная", Value = 3},
                };

                var itemsSign = new[] {
                    new {Text = "Физ. лицо", Value = 2},
                    new {Text = "Юр. лицо", Value = 3},

                };

                Type.DataSource = itemsType;
                Sign.DataSource = itemsSign;
            }
            if (pm.canEditRegister(new Company()) == "Оператор ОМСУ")
            {
                Type.DisplayMember = "Text";
                Type.ValueMember = "Value";

                Sign.DisplayMember = "Text";
                Sign.ValueMember = "Value";

                var itemsType = new[] {
                    new {Text = "Приют", Value = 2},
                };

                var itemsSign = new[] {
                    new {Text = "Физ. лицо", Value = 2},
                    new {Text = "Юр. лицо", Value = 3},

                };

                Type.DataSource = itemsType;
                Sign.DataSource = itemsSign;


                //Type.Items.Add(new {Text = "Приют", Value = 1});
                /*Type.Items.Add("Организация по отлову");
                Type.Items.Add("Организация по отлову и приют");
                Type.Items.Add("Организация по транспортировке");
                Type.Items.Add("Ветеринарная клиника: государственная");
                Type.Items.Add("Ветеринарная клиника: частная");
                Type.Items.Add("Благотворительный фонд");
                Type.Items.Add("Огранизация по продаже товаров и предоставлению \n услуг для животных");*/
            }

        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Company company = new Company(0, NameOrg.Text, Convert.ToInt32(Inn.Text), Convert.ToInt32(Kpp.Text), AdressRegistration.Text, new CompanyType(Convert.ToInt32(Type.SelectedValue), Type.Text), new CompanySign(Convert.ToInt32(Sign.SelectedValue), Sign.Text));
                companyController.addCompany(company);

                var form = new FormCompany(pm);

                this.Hide();

                form.Show();
            }
            catch
            {
                MessageBox.Show("Проверьте данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
