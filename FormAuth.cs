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
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void BTNauth_Click(object sender, EventArgs e)
        {
            //если авторизовался => 
            this.Hide();
            // => 
            var form = new FormCapturePlan();
            form.Show();
        }
    }
}
