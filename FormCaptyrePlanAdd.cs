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
using CatchGraphPlan.Controllers;
using CatchGraphPlan.Capture;



namespace CatchGraphPlan
{
    public partial class FormCaptyrePlanAdd : Form
    {
        PM.PM pm;
        CapturePlanController capturePlanController = new CapturePlanController();
        public FormCaptyrePlanAdd(PM.PM pm)
        {
            InitializeComponent();
            this.pm = pm;
            if (pm.canEditRegister(new CapturePlan()) == "Оператор по отлову")
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

                var form = new FormCapturePlan(pm);

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
