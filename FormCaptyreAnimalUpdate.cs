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
    public partial class FormCaptyreAnimalUpdate : Form
    {
        int id;
        int idAct;
        PermissionsManager pm = PermManFactory.getInstance();
        CaptureAnimalCartController controllerAnimal = new CaptureAnimalCartController();
        public FormCaptyreAnimalUpdate(int id, int idAct)
        {
            InitializeComponent();
            this.id = id;
            this.idAct = idAct;
            CaptureAnimalCard captureAnimalCard = DB.query().getAnimalCardId(id);
            Category.Text = captureAnimalCard.animal_category;
            Gender.Text = captureAnimalCard.gender;
            Breed.Text = captureAnimalCard.breed;
            SizeAnimal.Text = captureAnimalCard.size;
            hair.Text = captureAnimalCard.hair;
            color.Text = captureAnimalCard.hair_color;
            ears.Text = captureAnimalCard.ears;
            tail.Text = captureAnimalCard.tail;
            richTextBox1.Text = captureAnimalCard.special_signs;
            IdentificationLabel.Text = captureAnimalCard.identification_label;
            ElectronicChipNumber.Text = captureAnimalCard.electronic_chip_number.ToString();
            Municipality.Text = captureAnimalCard.municipality.name;

        }

        private void BTNBack_Click(object sender, EventArgs e)
        {
            var form = new FormCaptyreActUpdate(idAct);

            this.Hide();

            form.Show();
        }
    }
}
