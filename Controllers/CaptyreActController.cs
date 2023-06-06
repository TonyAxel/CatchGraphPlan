using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatchGraphPlan.Capture;
using CatchGraphPlan.PM;
using CatchGraphPlan.DataBase;
using CatchGraphPlan.Role;

namespace CatchGraphPlan.Controllers
{
    internal class CaptyreActController
    {
        PermissionsManager pm = PermManFactory.getInstance();

        public List<CaptureAct> getCaptureAct(string filter = null, string sort = null)
        {
            List<CaptureAct> listAct = new List<CaptureAct>();
            var reader = DB.query().getCaptureAct(filter: filter, sort: sort);
            while (reader.Read())
            {
                listAct.Add(DB.query().getCaptureActId(Convert.ToInt32(reader.GetString("number_id"))));
            }
            return listAct;
        }

        public object addCaptureAct(CaptureAct captureAct)
        {
            if (!isValidCaptureAct(captureAct))
            {
                throw new ArgumentException();
            }
            else
            {
                DB.query().addCaptureAct(captureAct);
                return captureAct;
            }


        }

        public object deleteCaptureAct(CaptureAct captureAct)
        {
            DB.query().deleteCaptureAct(captureAct);
            return captureAct;
        }

        public object updateCaptureAct(CaptureAct captureAct)
        {
            if (!isValidCaptureAct(captureAct))
            {
                throw new ArgumentException();
            }
            else
            {
                DB.query().updateCaptureAct(captureAct);
                return captureAct;
            }
        }

        bool isValidCaptureAct(CaptureAct captureAct)
        {
            if (captureAct.dogs_count == -1 || captureAct.cats_count == -1 || captureAct.animals_count == -1 || captureAct.capture_Date == null || captureAct.capture_goal == null)
            {
                return false;
            }
            return true;
        }
        public List<Company> getCompany()
        {
            List<Company> listMunicipality = new List<Company>();
            var reader = DB.query().getCompany();
            while (reader.Read())
            {
                listMunicipality.Add(DB.query().getCompanyId(Convert.ToInt32(reader.GetString("id"))));
            }
            return listMunicipality;
        }
        public List<CaptureMunicipalContract> getContract()
        {
            List<CaptureMunicipalContract> listMunicipality = new List<CaptureMunicipalContract>();
            var reader = DB.query().getCaptureMunicipalContract();
            while (reader.Read())
            {
                listMunicipality.Add(DB.query().getMunicipalContractId(Convert.ToInt32(reader.GetString("id"))));
            }
            return listMunicipality;
        }

        public void setFile(CaptureAct capturePlan)
        {
            DB.query().setFile(capturePlan);
        }

        public void deleteFile(CapturePlan capturePlan)
        {
            DB.query().deleteFile(capturePlan);
        }
    }
}
