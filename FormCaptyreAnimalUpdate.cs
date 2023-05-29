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


namespace CatchGraphPlan
{
    public partial class FormCaptyreAnimalUpdate : Form
    {
        PM.PM pm;
        public FormCaptyreAnimalUpdate(PM.PM pm)
        {
            InitializeComponent();
            this.pm = pm;
        }

        private void BTNUpdate_Click(object sender, EventArgs e)
        {
            var form = new FormCaptyreAnimal(pm);

            this.Hide();

            form.Show();
        }
    }
}
