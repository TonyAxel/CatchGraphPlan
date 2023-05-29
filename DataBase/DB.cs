using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CatchGraphPlan.PM;
using CatchGraphPlan.Capture;

namespace CatchGraphPlan.DataBase
{
    public class DB
    {

        private static MySqlConnection connection()
        {
            MySqlConnection connect = new MySqlConnection("Server=localhost; database=projectrtippo; uID=root; pwd=;");

            connect.Open();

            return connect;
        }

        public MySqlDataReader getUser(string login, string password)
        {
            MySqlDataReader reader;
            MySqlCommand command = new MySqlCommand($"SELECT * FROM useraccount WHERE useraccount.login = '{login}' AND useraccount.password = '{password}'", connection());
            return reader = command.ExecuteReader();
        }
        public Role getRole(int id)
        {
            MySqlDataReader reader;
            MySqlCommand command = new MySqlCommand($"SELECT * FROM role WHERE id={id}", connection());
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read()) { 
                    return new Role(Convert.ToInt32(reader.GetString("id")), reader.GetString("role_name"));
                }
                return new Role('0', null);
            }
            else
            {
                return new Role('0', null);
            }
        }
        public Municipality getMunicipality(int id)
        {
            MySqlDataReader reader;
            MySqlCommand command = new MySqlCommand($"SELECT * FROM municipality WHERE id={id}", connection());
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    return new Municipality(Convert.ToInt32(reader.GetString("id")), reader.GetString("name"));
                }
                return new Municipality('0', null);
            }
            else
            {
                return new Municipality('0', null);
            }
        }
        public CompanySign getCompSign(int id)
        {
            MySqlDataReader reader;
            MySqlCommand command = new MySqlCommand($"SELECT * FROM company_sign WHERE id={id}", connection());
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    return new CompanySign(Convert.ToInt32(reader.GetString("id")), reader.GetString("name"));
                }
                return new CompanySign('0', null);
            }
            else
            {
                return new CompanySign('0', null);
            }
        }
        public CompanyType getCompType(int id)
        {
            MySqlDataReader reader;
            MySqlCommand command = new MySqlCommand($"SELECT * FROM company_type WHERE id={id}", connection());
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    return new CompanyType(Convert.ToInt32(reader.GetString("id")), reader.GetString("name"));
                }
                return new CompanyType('0', null);
            }
            else
            {
                return new CompanyType('0', null);
            }
        }
        public Omsy getOmsy(int id)
        {
            MySqlDataReader reader;
            MySqlCommand command = new MySqlCommand($"SELECT * FROM omsy WHERE id={id}", connection());
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    return new Omsy(Convert.ToInt32(reader.GetString("id")), reader.GetString("name"), getMunicipality(Convert.ToInt32(reader.GetString("municipality"))));
                }
                return new Omsy('0', null, null);  
            }
            else
            {
                return new Omsy('0', null, null);
            }
        }
        public Company getCompanyId(int id)
        {
            MySqlDataReader reader;
            MySqlCommand command = new MySqlCommand($"SELECT * FROM company WHERE id={id}", connection());
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    return new Company(Convert.ToInt32(reader.GetString("id")),
                        reader.GetString("name"),
                        Convert.ToInt32(reader.GetString("inn")),
                        Convert.ToInt32(reader.GetString("kpp")),
                        reader.GetString("registation_adress"),
                        getCompType(Convert.ToInt32(reader.GetString("company_type"))),
                        getCompSign(Convert.ToInt32(reader.GetString("company_sign"))));
                }
                return new Company(0, null, 0, 0, null, null, null);
            }
            else
            {
                return new Company(0, null, 0,0,null,null,null);
            }
        }
        public MySqlDataReader getCompany(int id = 0)
        {
            MySqlDataReader reader;
            if (id == 0)
            {
                MySqlCommand command = new MySqlCommand($"SELECT * FROM company", connection());
                return reader = command.ExecuteReader();
            }
            else {
                MySqlCommand command = new MySqlCommand($"SELECT * FROM company WHERE id = '{id}'", connection());
                return reader = command.ExecuteReader();
            }
        }
        

    }
}
