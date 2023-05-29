using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatchGraphPlan.DataBase;
using CatchGraphPlan.PM;

namespace CatchGraphPlan.Controllers
{
    class AuthorizeController
    {
        DB db = new DB();
        Account account;
        public Account autorization(string login, string password)
        {
            var reader = db.getUser(login, password);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    reader.GetString("id");
                    account = new Account(Convert.ToInt32(reader.GetString("id")),
                        reader.GetString("login"),
                        reader.GetString("password"),
                        db.getRole(Convert.ToInt32(reader.GetString("role_id"))),
                        db.getOmsy(Convert.ToInt32(reader.GetString("omsy"))),
                        db.getCompanyId(Convert.ToInt32(reader.GetString("company")))
                        );                   
                }
                return account;
            }
            else
            {
                return account;
            }
        }
    }
}
