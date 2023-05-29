using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CatchGraphPlan.DataBase;
using CatchGraphPlan.Controllers;
using CatchGraphPlan.PM;

namespace CatchGraphPlan
{
    public partial class AuthForm : Form
    {
        DB db;
        AuthorizeController AuthContoller = new AuthorizeController();
        PermManFactory pmfact = new PermManFactory();

        public AuthForm()
        {
            InitializeComponent();
        }

        private void BTNauth_Click(object sender, EventArgs e)
        {
            string Login = login.Text;
            string Password = password.Text;
            Account acc = AuthContoller.autorization(Login, Password); //проверить на пустоту
            var PM = pmfact.getUserPermissions(acc);

            this.Hide();
            var form = new FormCapturePlan(PM);
            form.Show();
        }
    }
}
