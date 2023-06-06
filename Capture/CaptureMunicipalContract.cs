using CatchGraphPlan.PM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchGraphPlan.Capture
{
    public class CaptureMunicipalContract
    {
        public int id;
        public DateTime sign_date;
        public DateTime action_date;
        public Company contractor_company;
        public Company customer;
        public Municipality municipality;
        public string file;

        public CaptureMunicipalContract()
        {

        }
        public CaptureMunicipalContract(int id)
        {
            this.id = id;
        }
        public CaptureMunicipalContract(int id, string file)
        {
            this.id = id;
            this.file = file;
        }
        public CaptureMunicipalContract(int id, DateTime sign_date, DateTime action_date, Company contractor_company, Company customer, Municipality municipality, string file = null)
        {
            this.id = id;
            this.sign_date = sign_date;
            this.action_date = action_date;
            this.contractor_company = contractor_company;
            this.customer = customer;
            this.municipality = municipality;
            this.file = file;
        }
    }
}
