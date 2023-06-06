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
        PermissionsManager pm = PermManFactory.getInstance();

        public List<CapturePlan> getCapturePlan(string filter = null, string sort = null)
        {
            List<CapturePlan> listCompany = new List<CapturePlan>();
            var reader = DB.query().getCapturePlan(filter: filter, sort: sort);
            while (reader.Read())
            {
                listCompany.Add(DB.query().getCapturePlanId(Convert.ToInt32(reader.GetString("id"))));
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
                DB.query().addCapturePlan(capturePlan);
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
                DB.query().deleteCapturePlan(capturePlan);
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
                DB.query().updateCapturePlan(capturePlan);
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
            var reader = DB.query().getAllMunicipality();
            while (reader.Read())
            {
                listMunicipality.Add(DB.query().getMunicipality(Convert.ToInt32(reader.GetString("id"))));
            }          
            return listMunicipality;
        }
        public void setFile(CapturePlan capturePlan)
        {
            DB.query().setFile(capturePlan);
        }

        public void deleteFile(CapturePlan capturePlan)
        {
            DB.query().deleteFile(capturePlan);
        }
    }
}
