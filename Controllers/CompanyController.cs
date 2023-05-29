using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatchGraphPlan.DataBase;
using CatchGraphPlan.PM;
using CatchGraphPlan.Capture;

namespace CatchGraphPlan.Controllers
{
    class CompanyController
    {
        DB db = new DB();
        public List<Company> getCompany(PM.PM pm = null)
        {
            List < Company > listCompany = new List<Company>();
            if (pm == null)
            {
                var reader = db.getCompany();
                while (reader.Read())
                {
                    listCompany.Add(db.getCompanyId(Convert.ToInt32(reader.GetString("id"))));
                }
            }
            else
            {
                var reader = db.getCompany(pm.Account.company.id);
                while (reader.Read())
                {
                    listCompany.Add(db.getCompanyId(Convert.ToInt32(reader.GetString("id"))));
                }
            }
            return listCompany;
        }
       
    }
}
