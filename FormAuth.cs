﻿using System;
using System.Windows.Forms;
using CatchGraphPlan.Controllers;
using CatchGraphPlan.PM;
using CatchGraphPlan.Role;


namespace CatchGraphPlan
{
    public partial class AuthForm : Form
    {
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
            pmfact.getUserPermissions(acc);

            this.Hide();
            var form = new FormCapturePlan();
            form.Show();
        }
    }
}
