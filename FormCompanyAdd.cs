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
using CatchGraphPlan.Capture;

namespace CatchGraphPlan
{
    public partial class FormCompanyAdd : Form
    {
        PM.PM pm;
        public FormCompanyAdd(PM.PM pm)
        {
            InitializeComponent();
            this.pm = pm;
            if(pm.canEditRegister(new Company()) == "Оператор ВетСлужбы")
            {

            }
            if (pm.canEditRegister(new Company()) == "Оператор ОМСУ")
            {

            }

        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            var form = new FormCompany(pm);

            this.Hide();

            form.Show();
        }
    }
}
