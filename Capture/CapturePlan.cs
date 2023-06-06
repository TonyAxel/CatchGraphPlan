using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatchGraphPlan.PM;

namespace CatchGraphPlan.Capture
{
    public class CapturePlan
    {
        public int id;
        public DateTime date;
        public Municipality municipality;
        public string file;

        public CapturePlan()
        {
        }

        public CapturePlan(int id, string file)
        {
            this.id = id;
            this.file = file;
        }

        public CapturePlan(int id)
        {
            this.id = id;
        }

        public CapturePlan(int id, DateTime date, Municipality municipality, string file=null)
        {
            this.id = id;
            this.date = date;
            this.municipality = municipality;
            this.file = file;
        }
    }
}
