using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CatchGraphPlan.PM;
using CatchGraphPlan.Capture;
using CatchGraphPlan.Role;

namespace CatchGraphPlan.DataBase
{
    public class DB: DataBase
    {
        private static DataBase _db = null;

        public static DataBase query()
        {
            if(_db == null)
            {
                return _db = new DataBase();
            }
            else { return _db; }
        }
    }
}
