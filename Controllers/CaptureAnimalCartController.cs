using CatchGraphPlan.Capture;
using CatchGraphPlan.DataBase;
using Microsoft.Office.Interop.Excel;
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
    class CaptureAnimalCartController
    {
        public List<CaptureAnimalCard> GetCaptureAnimals()
        {
            List<CaptureAnimalCard> listAnimalCard = new List<CaptureAnimalCard>();
            var reader = DB.query().getCaptureAnimalCard();

            while (reader.Read())
            {
                listAnimalCard.Add(DB.query().getAnimalCardId(Convert.ToInt32(reader.GetString("id"))));
            }

            return listAnimalCard;
        }
        public List<CaptureAnimalCard> GetCaptureAnimalsAct(int id)
        {
            List<CaptureAnimalCard> listAnimalCard = new List<CaptureAnimalCard>();
            var reader = DB.query().getCaptureAnimalCardAct(id);

            while (reader.Read())
            {
                listAnimalCard.Add(DB.query().getAnimalCardId(Convert.ToInt32(reader.GetString("id"))));
            }

            return listAnimalCard;
        }
        public object addCaptureAnimalCard(CaptureAnimalCard captureAnimalCard)
        {
            if (!isValid(captureAnimalCard))
            {
                throw new ArgumentException();
            }
            else
            {
                DB.query().addCaptureAnimalCard(captureAnimalCard);
                return captureAnimalCard;
            }
        }
        private bool isValid(CaptureAnimalCard captureAnimalCard)
        {
            if (captureAnimalCard == null) return false;
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
        public List<CaptureAct> getCaptureAct()
        {
            List<CaptureAct> listMunicipality = new List<CaptureAct>();
            var reader = DB.query().getCaptureAct();
            while (reader.Read())
            {
                listMunicipality.Add(DB.query().getCaptureActId(Convert.ToInt32(reader.GetString("id"))));
            }
            return listMunicipality;
        }

    }
}
