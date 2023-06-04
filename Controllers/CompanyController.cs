using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatchGraphPlan.DataBase;
using CatchGraphPlan.PM;
using CatchGraphPlan.Capture;
using System.Windows.Forms;
using CatchGraphPlan.Role;

namespace CatchGraphPlan.Controllers
{
    class CompanyController
    {
        public List<Company> getCompany(PermissionsManager pm = null, string filter = null, string sort = null)
        {
            List < Company > listCompany = new List<Company>();
            if (pm == null)
            {
                var reader = DB.query().getCompany(filter:filter, sort:sort);
                while (reader.Read())
                {
                    listCompany.Add(DB.query().getCompanyId(Convert.ToInt32(reader.GetString("id"))));
                }
            }
            else
            {
                var reader = DB.query().getCompany(pm.Account.company.id, filter, sort);
                while (reader.Read())
                {
                    listCompany.Add(DB.query().getCompanyId(Convert.ToInt32(reader.GetString("id"))));
                }
            }
            return listCompany;
        }

        public object addCompany(Company company)
        {
            if (!isValidCompany(company))
            {
                throw new ArgumentException();
            }
            else
            {
                DB.query().addCompany(company);
                return company;
            }

          
        }

        public object deleteCompany(Company company)
        {
            if (!isValidCompany(company))
            {
                throw new ArgumentException();
            }
            else
            {
                DB.query().deleteCompany(company);
                return company;
            }
        }

        public object updateCompany(Company company)
        {
            if (!isValidCompany(company))
            {
                throw new ArgumentException();
            }
            else
            {
                DB.query().updateCompany(company);
                return company;
            }
        }

        bool isValidCompany(Company company)
        {
            if(company.name == "" || company.registrationAdress == "" || company.companyType.name == "" || company.companySign.name == "")
            {
                return false;
            }
            return true;
        }
    }
}
