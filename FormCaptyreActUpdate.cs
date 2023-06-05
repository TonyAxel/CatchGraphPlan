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
    public partial class FormCaptyreActUpdate : Form
    {
        PermissionsManager pm = PermManFactory.getInstance();
        CaptyreActController controller = new CaptyreActController();
        int id;
        public FormCaptyreActUpdate(int id)
        {
            this.id = id;
            InitializeComponent();
            CaptureAct captureAct = DB.query().getCaptureActId(id);
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";
            comboBox2.DisplayMember = "Text";
            comboBox2.ValueMember = "Value";
            if (pm.canEditRegister(new CaptureAct()))
            {
                
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

                BTNBack.Hide();
            }
            else
            {
                CountDogs.Enabled = false;
                CountCats.Enabled = false;
                CountAnimals.Enabled = false;
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                dateTimePicker1.Enabled = false;
                CaptyreGoal.Enabled = false;
                var itemsType = new[] {
                    new {Text = captureAct.company.name, Value = captureAct.company.id},
                };
                var itemsType1 = new[] {
                    new {Text = captureAct.captureMunicipalContract.id, Value = captureAct.captureMunicipalContract.id},
                };
                comboBox1.DataSource = itemsType;
                comboBox2.DataSource = itemsType1;
            }

            comboBox1.SelectedValue = captureAct.company.id;
            comboBox2.SelectedValue = captureAct.captureMunicipalContract.id;
            CountDogs.Value = captureAct.dogs_count;
            CountCats.Value = captureAct.cats_count;
            CountAnimals.Text = captureAct.animals_count.ToString();
            dateTimePicker1.Value = captureAct.capture_Date;
            CaptyreGoal.Text = captureAct.capture_goal;

        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            try
            {
                CaptureAct captureAct = new CaptureAct(this.id, Convert.ToInt32(CountDogs.Text), Convert.ToInt32(CountCats.Text), Convert.ToInt32(CountAnimals.Text), dateTimePicker1.Value, CaptyreGoal.Text, new Company(Convert.ToInt32(comboBox1.SelectedValue), comboBox1.Text), new CaptureMunicipalContract(Convert.ToInt32(comboBox2.SelectedValue)));
                controller.updateCaptureAct(captureAct);

                var form = new FormCaptyreAct();

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
            var form = new FormCaptyreAct();

            this.Hide();

            form.Show();
        }


    }
}
