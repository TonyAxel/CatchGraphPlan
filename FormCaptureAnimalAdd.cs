using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class FormCaptureAnimalAdd : Form
    {
        PermissionsManager pm = PermManFactory.getInstance();
        CaptureAnimalCartController controller = new CaptureAnimalCartController();
        int id;
        public FormCaptureAnimalAdd(int id)
        {
            InitializeComponent();
            this.id = id;
            if (pm.canEditRegister(new CaptureAnimalCard()))
            {
                CategoryAnimal.DisplayMember = "Text";
                CategoryAnimal.ValueMember = "Value";
                Gender.DisplayMember = "Text";
                Gender.ValueMember = "Value";
                Municipality.DisplayMember = "Text";
                Municipality.ValueMember = "Value";

                var itemsCategory = new[] {
                    new {Text = "Выберите категорию", Value = 0},
                    new {Text = "Кошка", Value = 1},
                    new {Text = "Собака", Value = 2},
                };
                var itemsGender = new[] {
                    new {Text = "Выберите гендер", Value = 0},
                    new {Text = "Кабель", Value = 1},
                    new {Text = "Сучка", Value = 2},
                };
                var itemsMunicipality = new[] {
                    new {Text = "Выберите населенный пункт", Value = 0},
                };
                foreach (var item in controller.getMunicipality())
                {
                    var val = new[] { new { Text = item.name.ToString(), Value = Convert.ToInt32(item.id) } };

                    itemsMunicipality = itemsMunicipality.Concat(val).ToArray();
                }
                CategoryAnimal.DataSource = itemsCategory;
                Gender.DataSource = itemsGender;
                Municipality.DataSource = itemsMunicipality;


            }
        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            try
            {
                CaptureAnimalCard captureAct = new CaptureAnimalCard(0, CategoryAnimal.Text, Gender.Text, Breed.Text, SizeAnimal.Text, hair.Text, color.Text, ears.Text, tail.Text, richTextBox1.Text, IdentificationLabel.Text, Convert.ToInt32(ElectronicChipNumber.Text), new Municipality(Convert.ToInt32(Municipality.SelectedValue), Municipality.Text), new CaptureAct(id));
                controller.addCaptureAnimalCard(captureAct);

                var form = new FormCaptyreActUpdate(id);

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
