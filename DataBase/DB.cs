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
            MySqlCommand command = new MySqlCommand($"SELECT * FROM useraccount WHERE useraccount.login = '{login}' AND useraccount.password = '{password}'", connection());
            connection().Close();
            return command.ExecuteReader();
        }
        public PM.Role getRole(int id)
        {
            MySqlDataReader reader;
            MySqlCommand command = new MySqlCommand($"SELECT * FROM role WHERE id={id}", connection());
            connection().Close();
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read()) { 
                    return new PM.Role(Convert.ToInt32(reader.GetString("id")), reader.GetString("role_name"));
                }
                return new PM.Role('0', null);
            }
            else
            {
                return new PM.Role('0', null);
            }
        }
        public Municipality getMunicipality(int id)
        {
            MySqlDataReader reader;
            MySqlCommand command = new MySqlCommand($"SELECT * FROM municipality WHERE id={id}", connection());
            connection().Close();
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
        public MySqlDataReader getAllMunicipality()
        {
            MySqlDataReader reader;
            MySqlCommand command = new MySqlCommand($"SELECT * FROM municipality", connection());
            connection().Close();
            reader = command.ExecuteReader();
            return reader;
        }
        public CompanySign getCompSign(int id)
        {
            MySqlDataReader reader;
            MySqlCommand command = new MySqlCommand($"SELECT * FROM company_sign WHERE id={id}", connection());
            connection().Close();
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
            connection().Close();
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
            connection().Close();
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
            connection().Close();
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

        public MySqlDataReader getCompany(int id = 0, string filter = null, string sort = null)
        {
            if (id == 0)
            {
                if (filter != null)
                {
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM company WHERE {filter}", connection());
                    connection().Close();
                    return command.ExecuteReader();
                }
                if (sort != null)
                {
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM company ORDER BY {sort}", connection());
                    connection().Close();
                    return command.ExecuteReader();
                }
                if(filter != null && sort != null)
                {
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM company WHERE {filter} ORDER BY {sort}", connection());
                    connection().Close();
                    return command.ExecuteReader();
                }
                else
                {
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM company", connection());
                    connection().Close();
                    return command.ExecuteReader();
                }
            }
            else {
                if (filter != null)
                {
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM company WHERE id = '{id}' AND WHERE {filter}", connection());
                    connection().Close();
                    return command.ExecuteReader();
                }
                if (sort != null)
                {
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM company WHERE id = '{id}' ORDER BY {sort}", connection());
                    connection().Close();
                    return command.ExecuteReader();
                }
                if (filter != null && sort != null)
                {
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM company WHERE id = '{id}' AND WHERE {filter} ORDER BY {sort}", connection());
                    connection().Close();
                    return command.ExecuteReader();
                }
                else
                {
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM company WHERE id = '{id}'", connection());
                    connection().Close();
                    return command.ExecuteReader();
                }
            }

        }
           

        //company
        public void addCompany(Company company)
        {
            MySqlCommand command = new MySqlCommand($"INSERT INTO company(name, inn, kpp, registation_adress, company_type, company_sign) VALUES ('{company.name}', '{company.inn}', '{company.kpp}', '{company.registrationAdress}', {company.companyType.id}, {company.companySign.id})", connection());
            connection().Close();
            command.ExecuteNonQuery();
        }

        public void deleteCompany(Company company)
        {
            MySqlCommand command = new MySqlCommand($"DELETE FROM company WHERE id = {company.id}" , connection());
            connection().Close();
            command.ExecuteNonQuery();
        }

        public void updateCompany(Company company)
        {
            MySqlCommand command = new MySqlCommand($"UPDATE company SET name = '{company.name}', inn = '{company.inn}', kpp = '{company.kpp}', registation_adress = '{company.registrationAdress}', company_type = {company.companyType.id}, company_sign = {company.companySign.id} WHERE id = {company.id};", connection());
            connection().Close();
            command.ExecuteNonQuery();
        }

        //CapturePlan

        public MySqlDataReader getCapturePlan(int id = 0, string filter = null, string sort = null)
        {
            if (id == 0)
            {
                if (filter != null)
                {
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM captureplan WHERE {filter}", connection());
                    connection().Close();
                    return command.ExecuteReader();
                }
                if (sort != null)
                {
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM captureplan ORDER BY {sort}", connection());
                    connection().Close();
                    return command.ExecuteReader();
                }
                if (filter != null && sort != null)
                {
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM captureplan WHERE {filter} ORDER BY {sort}", connection());
                    connection().Close();
                    return command.ExecuteReader();
                }
                else
                {
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM captureplan", connection());
                    connection().Close();
                    return command.ExecuteReader();
                }
            }
            else
            {
                if (filter != null)
                {
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM captureplan WHERE id = '{id}' AND WHERE {filter}", connection());
                    connection().Close();
                    return command.ExecuteReader();
                }
                if (sort != null)
                {
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM captureplan WHERE id = '{id}' ORDER BY {sort}", connection());
                    connection().Close();
                    return command.ExecuteReader();
                }
                if (filter != null && sort != null)
                {
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM captureplan WHERE id = '{id}' AND WHERE {filter} ORDER BY {sort}", connection());
                    connection().Close();
                    return command.ExecuteReader();
                }
                else
                {
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM captureplan WHERE id = '{id}'", connection());
                    connection().Close();
                    return command.ExecuteReader();
                }
            }
        }
        public CapturePlan getCapturePlanId(int id)
        {
            MySqlDataReader reader;
            MySqlCommand command = new MySqlCommand($"SELECT * FROM captureplan WHERE id={id}", connection());
            connection().Close();
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    return new CapturePlan(Convert.ToInt32(reader.GetString("id")),
                        Convert.ToDateTime(reader.GetString("date")),
                        getMunicipality(Convert.ToInt32(reader.GetString("municipality"))),
                        reader.GetString("file"));
                }
                return new CapturePlan(0, new DateTime(), null, null);
            }
            else
            {
                return new CapturePlan(0, new DateTime(), null, null);
            }
        }

        public void addCapturePlan(CapturePlan capturePlan)
        {
            MySqlCommand command = new MySqlCommand($"INSERT INTO captureplan(date, mynicipality) VALUES ('{capturePlan.date.Year}-{capturePlan.date.Month}-{capturePlan.date.Day}', {capturePlan.municipality.id})", connection());
            connection().Close();
            command.ExecuteNonQuery();
        }

        public void deleteCapturePlan(CapturePlan capturePlan)
        {
            MySqlCommand command = new MySqlCommand($"DELETE FROM captureplan WHERE id = {capturePlan.id}", connection());
            connection().Close();
            command.ExecuteNonQuery();
        }

        public void updateCapturePlan(CapturePlan capturePlan)
        {
            MySqlCommand command = new MySqlCommand($"UPDATE captureplan SET date = '{capturePlan.date}', municipality = '{capturePlan.municipality}', file = '{capturePlan.file}' WHERE id = {capturePlan.id};", connection());
            connection().Close();
            command.ExecuteNonQuery();
        }
    }
}
