using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CatchGraphPlan
{
    public partial class FormCaptyreAnimalUpdate : Form
    {
        public FormCaptyreAnimalUpdate()
        {
            InitializeComponent();
        }

        private void BTNUpdate_Click(object sender, EventArgs e)
        {
            var form = new FormCaptyreAnimal();

            this.Hide();

            form.Show();
        }
    }
}
