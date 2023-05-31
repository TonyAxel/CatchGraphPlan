using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatchGraphPlan.DataBase;
using CatchGraphPlan.PM;
using CatchGraphPlan.Role;
using CatchGraphPlan.Capture;

namespace CatchGraphPlan.Controllers
{
    class CapturePlanController
    {
        DB db = new DB();
        PermissionsManager pm = PermManFactory.getInstance();

        public List<CapturePlan> getCapturePlan(string filter = null, string sort = null)
        {
            List<CapturePlan> listCompany = new List<CapturePlan>();
            if (pm == null)
            {
                var reader = db.getCapturePlan(filter: filter, sort: sort);
                while (reader.Read())
                {
                    listCompany.Add(db.getCapturePlanId(Convert.ToInt32(reader.GetString("id"))));
                }
            }
            else
            {
                var reader = db.getCapturePlan(pm.Account.company.id, filter, sort);
                while (reader.Read())
                {
                    listCompany.Add(db.getCapturePlanId(Convert.ToInt32(reader.GetString("id"))));
                }
            }
            return listCompany;
        }

        public object addCapturePlan(CapturePlan capturePlan)
        {
            if (!isValidCapturePlan(capturePlan))
            {
                throw new ArgumentException();
            }
            else
            {
                db.addCapturePlan(capturePlan);
                return capturePlan;
            }


        }

        public object deleteCapturePlan(CapturePlan capturePlan)
        {
            if (!isValidCapturePlan(capturePlan))
            {
                throw new ArgumentException();
            }
            else
            {
                db.deleteCapturePlan(capturePlan);
                return capturePlan;
            }
        }

        public object updateCapturePlan(CapturePlan capturePlan)
        {
            if (!isValidCapturePlan(capturePlan))
            {
                throw new ArgumentException();
            }
            else
            {
                db.updateCapturePlan(capturePlan);
                return capturePlan;
            }
        }

        bool isValidCapturePlan(CapturePlan capturePlan)
        {
            if (capturePlan.date == null || capturePlan.municipality == null)
            {
                return false;
            }
            return true;
        }
        public List<Municipality> getMunicipality()
        {
            List<Municipality> listMunicipality = new List<Municipality>();
            var reader = db.getAllMunicipality();
            while (reader.Read())
            {
                listMunicipality.Add(db.getMunicipality(Convert.ToInt32(reader.GetString("id"))));
            }          
            return listMunicipality;
        }
    }
}
