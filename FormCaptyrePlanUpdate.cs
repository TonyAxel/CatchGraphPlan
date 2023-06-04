using System;
using System.Linq;
using System.Windows.Forms;
using CatchGraphPlan.Capture;
using CatchGraphPlan.Controllers;
using CatchGraphPlan.DataBase;
using CatchGraphPlan.PM;
using CatchGraphPlan.Role;


namespace CatchGraphPlan
{
    public partial class FormCaptyrePlanUpdate : Form
    {
        PermissionsManager pm = PermManFactory.getInstance();
        int id;
        CapturePlanController capturePlanController = new CapturePlanController();
        public FormCaptyrePlanUpdate()
        {
            InitializeComponent();

        }
        public FormCaptyrePlanUpdate(int id)
        {
            InitializeComponent();
            this.id = id;
            CapturePlan capturePlan = DB.query().getCapturePlanId(id);

            if (pm.canEditRegister(new CapturePlan()))
            {
                mynicipality.DisplayMember = "Text";
                mynicipality.ValueMember = "Value";

                var itemsType = new[] {
                    new {Text = "", Value = 0},
                };
                foreach (var item in capturePlanController.getMunicipality())
                {
                    var val = new[] { new { Text = item.name.ToString(), Value = Convert.ToInt32(item.id) } };

                    itemsType = itemsType.Concat(val).ToArray();
                }
                mynicipality.DataSource = itemsType;
                BTNBack.Hide();
            }
            else
            {
                mynicipality.DisplayMember = "Text";
                mynicipality.ValueMember = "Value";
                var itemsType = new[] {
                    new {Text = capturePlan.municipality.name, Value = Convert.ToInt32(capturePlan.municipality.id)},
                };
                date.Enabled = false;
                mynicipality.Enabled = false;
                mynicipality.DataSource = itemsType;

            }
            date.Value = capturePlan.date;
            mynicipality.SelectedValue = capturePlan.municipality.id;
        }
        private void BTNUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                CapturePlan capturePlan = new CapturePlan(this.id, date.Value,new  Municipality(Convert.ToInt32(mynicipality.SelectedValue), mynicipality.Text));
                capturePlanController.updateCapturePlan(capturePlan);

                var form = new FormCapturePlan();

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
            var form = new FormCapturePlan();

            this.Hide();

            form.Show();
        }
    }
}
