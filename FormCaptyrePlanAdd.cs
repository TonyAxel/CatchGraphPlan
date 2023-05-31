using System;
using System.Linq;
using System.Windows.Forms;
using CatchGraphPlan.PM;
using CatchGraphPlan.Role;
using CatchGraphPlan.Controllers;
using CatchGraphPlan.Capture;



namespace CatchGraphPlan
{
    public partial class FormCaptyrePlanAdd : Form
    {
        PermissionsManager pm = PermManFactory.getInstance();

        CapturePlanController capturePlanController = new CapturePlanController();
        public FormCaptyrePlanAdd()
        {
            InitializeComponent();
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
            }
        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            try
            {
                CapturePlan capturePlan = new CapturePlan(0, dateTimePicker1.Value, new Municipality(Convert.ToInt32(mynicipality.SelectedValue), mynicipality.Text));
                capturePlanController.addCapturePlan(capturePlan);

                var form = new FormCapturePlan();

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
