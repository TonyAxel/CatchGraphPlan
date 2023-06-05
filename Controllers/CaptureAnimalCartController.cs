using CatchGraphPlan.Capture;
using CatchGraphPlan.DataBase;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
