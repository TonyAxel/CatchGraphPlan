using CatchGraphPlan.Capture;
using CatchGraphPlan.DataBase;
using CatchGraphPlan.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchGraphPlan.Controllers
{
    class CaptureMunicipalContractController
    {
        public List<CaptureMunicipalContract> getMunicipalContract(string filter = null, string sort = null)
        {
            List<CaptureMunicipalContract> listCompany = new List<CaptureMunicipalContract>();
            
            var reader = DB.query().getCaptureMunicipalContract(filter: filter, sort: sort);
            while (reader.Read())
            {
                listCompany.Add(DB.query().getMunicipalContractId(Convert.ToInt32(reader.GetString("id"))));
            }  
            
            return listCompany;
        }

        public object addMunicipalContract(CaptureMunicipalContract municipalContract)
        {
            if (!isValid(municipalContract))
            {
                throw new ArgumentException();
            }
            else
            {
                DB.query().addCaptureMunicipalContract(municipalContract);
                return municipalContract;
            }
        }

        public object updateMunicipalContract(CaptureMunicipalContract municipalContract)
        {
            if (!isValid(municipalContract))
            {
                throw new ArgumentException();
            }
            else
            {
                DB.query().updateCaptureMunicipalContract(municipalContract);
                return municipalContract;
            }
        }

        private bool isValid(CaptureMunicipalContract municipalContract)
        {
            if (municipalContract == null) return false;
            return true;
        }
    }
}
