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
        Account account;
        public Account autorization(string login, string password)
        {
            var reader = DB.query().getUser(login, password);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    reader.GetString("id");
                    account = new Account(Convert.ToInt32(reader.GetString("id")),
                        reader.GetString("login"),
                        reader.GetString("password"),
                        DB.query().getRole(Convert.ToInt32(reader.GetString("role_id"))),
                        DB.query().getOmsy(Convert.ToInt32(reader.GetString("omsy"))),
                        DB.query().getCompanyId(Convert.ToInt32(reader.GetString("company")))
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
