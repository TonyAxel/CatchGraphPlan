using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CatchGraphPlan.DataBase
{
    public class DB
    {
        private static MySqlConnection connection()
        {
            MySqlConnection connect = new MySqlConnection("Server=localhost; database=test; uID=root; pwd=;");

            connect.Open();

            return connect;
        }

        public MySqlDataReader query(string query)
        {
            MySqlDataReader reader;
            MySqlCommand command = new MySqlCommand("SELECT * FROM users", connection());

            List<object> values = new List<object>();

            return reader = command.ExecuteReader();

        }

    }
}
