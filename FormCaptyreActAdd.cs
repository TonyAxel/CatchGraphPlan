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
using CatchGraphPlan.Role;
using CatchGraphPlan.Controllers;
using CatchGraphPlan.Capture;

namespace CatchGraphPlan
{
    public partial class FormCaptyreActAdd : Form
    {
        PermissionsManager pm = PermManFactory.getInstance();
        CaptyreActController controller = new CaptyreActController();

        public FormCaptyreActAdd()
        {
            InitializeComponent();
            if (pm.canEditRegister(new CaptureAct()))
            {
                comboBox1.DisplayMember = "Text";
                comboBox1.ValueMember = "Value";
                comboBox2.DisplayMember = "Text";
                comboBox2.ValueMember = "Value";

                var itemsType = new[] {
                    new {Text = "Выберите значение", Value = 0},
                };
                foreach (var item in controller.getCompany())
                {
                    var val = new[] { new { Text = item.name.ToString(), Value = Convert.ToInt32(item.id) } };

                    itemsType = itemsType.Concat(val).ToArray();
                }
                var itemsType1 = new[] {
                    new {Text = "Выберите значение", Value = 0},
                };
                foreach (var item in controller.getContract())
                {
                    var val = new[] { new { Text = item.id.ToString(), Value = Convert.ToInt32(item.id) } };

                    itemsType1 = itemsType1.Concat(val).ToArray();
                }
                comboBox1.DataSource = itemsType;
                comboBox2.DataSource = itemsType1;


            }
        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            try
            {
                CaptureAct captureAct = new CaptureAct(0, Convert.ToInt32(CountDogs.Text), Convert.ToInt32(CountCats.Text), Convert.ToInt32(CountAnimals.Text), dateTimePicker1.Value, CaptyreGoal.Text, new Company(Convert.ToInt32(comboBox1.SelectedValue),comboBox1.Text), new CaptureMunicipalContract(Convert.ToInt32(comboBox2.SelectedValue)));
                controller.addCaptureAct(captureAct);

                var form = new FormCaptyreAct();

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
