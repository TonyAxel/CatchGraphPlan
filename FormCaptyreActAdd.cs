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
    public partial class FormCaptyreActAdd : Form
    {
        public FormCaptyreActAdd()
        {
            InitializeComponent();
        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            var form = new FormCaptyreAct();

            this.Hide();

            form.Show();
        }
    }
}
