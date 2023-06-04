using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchGraphPlan.PM
{
    public class Omsy
    {
        int id;
        string name;
        public Municipality municipality;
        public Omsy (int id, string name, Municipality municipality)
        {
            this.id = id;
            this.name = name;
            this.municipality = municipality;
        }
    }
}
