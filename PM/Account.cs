using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatchGraphPlan.Capture;

namespace CatchGraphPlan.PM
{
    public class Account
    {
        int id;
        string login;
        string password;
        public Role role;
        Omsy omsy;
        public Company company;

        public Account(int id, string login, string password, Role role, Omsy omsy, Company company)
        {
            this.id = id;
            this.login = login;
            this.password = password;
            this.role = role;
            this.omsy = omsy;
            this.company = company;
        }
    }
}
