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
            MySqlCommand command = new MySqlCommand($"INSERT INTO captureplan(date, municipality) VALUES ('{capturePlan.date.Year}-{capturePlan.date.Month}-{capturePlan.date.Day}', '{capturePlan.municipality.id}')", connection());
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
            MySqlCommand command = new MySqlCommand($"UPDATE captureplan SET date = '{capturePlan.date.Year}-{capturePlan.date.Month}-{capturePlan.date.Day}', municipality = '{capturePlan.municipality.id}' WHERE id = {capturePlan.id};", connection());
            connection().Close();
            command.ExecuteNonQuery();
        }

        //CaptureAct

        public MySqlDataReader getCaptureAct(int id = 0, string filter = null, string sort = null)
        {
            if (id == 0)
            {
                if (filter != null)
                {
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM captureact WHERE {filter}", connection());
                    connection().Close();
                    return command.ExecuteReader();
                }
                if (sort != null)
                {
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM captureact ORDER BY {sort}", connection());
                    connection().Close();
                    return command.ExecuteReader();
                }
                if (filter != null && sort != null)
                {
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM captureact WHERE {filter} ORDER BY {sort}", connection());
                    connection().Close();
                    return command.ExecuteReader();
                }
                else
                {
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM captureact", connection());
                    connection().Close();
                    return command.ExecuteReader();
                }
            }
            else
            {
                if (filter != null)
                {
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM captureact WHERE number_id = '{id}' AND WHERE {filter}", connection());
                    connection().Close();
                    return command.ExecuteReader();
                }
                if (sort != null)
                {
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM captureact WHERE number_id = '{id}' ORDER BY {sort}", connection());
                    connection().Close();
                    return command.ExecuteReader();
                }
                if (filter != null && sort != null)
                {
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM captureact WHERE number_id = '{id}' AND WHERE {filter} ORDER BY {sort}", connection());
                    connection().Close();
                    return command.ExecuteReader();
                }
                else
                {
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM captureact WHERE number_id = '{id}'", connection());
                    connection().Close();
                    return command.ExecuteReader();
                }
            }
        }
        public CaptureAct getCaptureActId(int id)
        {
            MySqlDataReader reader;
            MySqlCommand command = new MySqlCommand($"SELECT * FROM captureact WHERE number_id={id}", connection());
            connection().Close();
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    return new CaptureAct(
                            Convert.ToInt32(reader.GetString("number_id")),
                            Convert.ToInt32(reader.GetString("dogs_count")),
                            Convert.ToInt32(reader.GetString("cats_count")),
                            Convert.ToInt32(reader.GetString("animal_count")),
                            Convert.ToDateTime(reader.GetString("capture_date")),
                            reader.GetString("capture_goal"),
                            getCompanyId(Convert.ToInt32(reader.GetString("company"))),
                            getMunicipalContractId(Convert.ToInt32(reader.GetString("municipal_contract"))),
                            getMunicipality(Convert.ToInt32(reader.GetString("municipality")))
                        );
                }
                return new CaptureAct();
            }
            else
            {
                return new CaptureAct();
            }
        }

        public void addCaptureAct(CaptureAct captureAct)
        {
            MySqlCommand command = new MySqlCommand($"INSERT INTO captureact(dogs_count,cats_count,animals_count,capture_date,caprute_goal,company,municipal_contract,municipality) " +
                $"VALUES ({captureAct.dogs_count}, {captureAct.cats_count}, {captureAct.animals_count},{captureAct.capture_Date.Year}-{captureAct.capture_Date.Month}-{captureAct.capture_Date.Day},{captureAct.capture_goal},{captureAct.company.id}, {captureAct.captureMunicipalContract.id}, {captureAct.municipality.id} )", connection());
            connection().Close();
            command.ExecuteNonQuery();
        }

        public void deleteCaptureAct(CaptureAct captureAct)
        {
            MySqlCommand command = new MySqlCommand($"DELETE FROM captureact WHERE number_id = {captureAct.number_id}", connection());
            connection().Close();
            command.ExecuteNonQuery();
        }

        public void updateCaptureAct(CaptureAct captureAct)
        {
            MySqlCommand command = new MySqlCommand($"UPDATE captureact SET dogs_count = {captureAct.dogs_count}," +
                $" cats_count = {captureAct.cats_count}," +
                $" animals_count = {captureAct.animals_count}," +
                $" capture_date ={captureAct.capture_Date.Year}-{captureAct.capture_Date.Month}-{captureAct.capture_Date.Day}," +
                $"caprute_goal={captureAct.capture_goal}," +
                $"company ={captureAct.company.id}," +
                $"municipal_contract = {captureAct.captureMunicipalContract.id}," +
                $"municipality = {captureAct.municipality.id} " +
                $"WHERE number_id = {captureAct.number_id};", connection());
            connection().Close();
            command.ExecuteNonQuery();
        }


        //Муниципальные контракты

        public CaptureMunicipalContract getMunicipalContractId(int id)
        {
            MySqlDataReader reader;
            MySqlCommand command = new MySqlCommand($"SELECT * FROM municipalcontract WHERE id={id}", connection());
            connection().Close();
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    return new CaptureMunicipalContract(
                        Convert.ToInt32(reader.GetString("id")),
                        Convert.ToDateTime(reader.GetString("sign_date")),
                        Convert.ToDateTime(reader.GetString("action_date")),
                        getCompanyId(Convert.ToInt32(reader.GetString("contractor_company"))),
                        getCompanyId(Convert.ToInt32(reader.GetString("customer")))
                        );
                }
                return new CaptureMunicipalContract();
            }
            else
            {
                return new CaptureMunicipalContract();
            }
        }
        public MySqlDataReader getCaptureMunicipalContract(int id = 0, string filter = null, string sort = null)
        {
            if (id == 0)
            {
                if (filter != null)
                {
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM municipalcontract WHERE {filter}", connection());
                    connection().Close();
                    return command.ExecuteReader();
                }
                if (sort != null)
                {
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM municipalcontract ORDER BY {sort}", connection());
                    connection().Close();
                    return command.ExecuteReader();
                }
                if (filter != null && sort != null)
                {
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM municipalcontract WHERE {filter} ORDER BY {sort}", connection());
                    connection().Close();
                    return command.ExecuteReader();
                }
                else
                {
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM municipalcontract", connection());
                    connection().Close();
                    return command.ExecuteReader();
                }
            }
            else
            {
                if (filter != null)
                {
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM municipalcontract WHERE id = '{id}' AND WHERE {filter}", connection());
                    connection().Close();
                    return command.ExecuteReader();
                }
                if (sort != null)
                {
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM municipalcontract WHERE id = '{id}' ORDER BY {sort}", connection());
                    connection().Close();
                    return command.ExecuteReader();
                }
                if (filter != null && sort != null)
                {
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM municipalcontract WHERE id = '{id}' AND WHERE {filter} ORDER BY {sort}", connection());
                    connection().Close();
                    return command.ExecuteReader();
                }
                else
                {
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM municipalcontract WHERE id = '{id}'", connection());
                    connection().Close();
                    return command.ExecuteReader();
                }
            }
        }
        public void addCaptureMunicipalContract(CaptureMunicipalContract captureMunicipalContract)
        {
            MySqlCommand command = new MySqlCommand($"INSERT INTO municipalcontract(sign_date,action_date,contractor_company,customer) " +
                $"VALUES ({captureMunicipalContract.sign_date.Year}-{captureMunicipalContract.sign_date.Month}-{captureMunicipalContract.sign_date.Day},{captureMunicipalContract.action_date.Year}-{captureMunicipalContract.action_date.Month}-{captureMunicipalContract.action_date.Day}, {captureMunicipalContract.contractor_company.id}, {captureMunicipalContract.customer.id})", connection());
            connection().Close();
            command.ExecuteNonQuery();
        }

        public void deleteCaptureMunicipalContract(CaptureMunicipalContract captureMunicipalContract)
        {
            MySqlCommand command = new MySqlCommand($"DELETE FROM municipalcontract WHERE id = {captureMunicipalContract.id}", connection());
            connection().Close();
            command.ExecuteNonQuery();
        }

        public void updateCaptureMunicipalContract(CaptureMunicipalContract captureMunicipalContract)
        {
            MySqlCommand command = new MySqlCommand($"UPDATE municipalcontract SET " +
                $"sign_date = {captureMunicipalContract.sign_date.Year}-{captureMunicipalContract.sign_date.Month}-{captureMunicipalContract.sign_date.Day}," +
                $"action_date = {captureMunicipalContract.action_date.Year}-{captureMunicipalContract.action_date.Month}-{captureMunicipalContract.action_date.Day}," +
                $"contractor_company = {captureMunicipalContract.contractor_company.id}," +
                $"customer ={captureMunicipalContract.customer.id} " +
                $"WHERE id = {captureMunicipalContract.id};", connection());
            connection().Close();
            command.ExecuteNonQuery();
        }

        //animalCard
        public CaptureAnimalCard getAnimalCardId(int id)
        {
            MySqlDataReader reader;
            MySqlCommand command = new MySqlCommand($"SELECT * FROM captureanimalcard WHERE id={id}", connection());
            connection().Close();
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    return new CaptureAnimalCard(
                        Convert.ToInt32(reader.GetString("id")),
                        reader.GetString("anuimal_category"),
                        reader.GetString("gender"),
                        reader.GetString("size"),
                        reader.GetString("hair"),
                        reader.GetString("hair_color"),
                        reader.GetString("ears"),
                        reader.GetString("tail"),
                        reader.GetString("special_signs"),
                        reader.GetString("identification_label"),
                        Convert.ToInt32(reader.GetString("electronic_chip_number")),
                        getMunicipality(Convert.ToInt32(reader.GetString("municipality"))),
                        getCaptureActId(Convert.ToInt32(reader.GetString("capture_act")))
                        );
                }
                return new CaptureAnimalCard();
            }
            else
            {
                return new CaptureAnimalCard(); 
            }
        }
        public MySqlDataReader getCaptureAnimalCard(int id = 0, string filter = null, string sort = null)
        {
            if (id == 0)
            {
                if (filter != null)
                {
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM captureanimalcard WHERE {filter}", connection());
                    connection().Close();
                    return command.ExecuteReader();
                }
                if (sort != null)
                {
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM captureanimalcard ORDER BY {sort}", connection());
                    connection().Close();
                    return command.ExecuteReader();
                }
                if (filter != null && sort != null)
                {
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM captureanimalcard WHERE {filter} ORDER BY {sort}", connection());
                    connection().Close();
                    return command.ExecuteReader();
                }
                else
                {
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM captureanimalcard", connection());
                    connection().Close();
                    return command.ExecuteReader();
                }
            }
            else
            {
                if (filter != null)
                {
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM captureanimalcard WHERE id = '{id}' AND WHERE {filter}", connection());
                    connection().Close();
                    return command.ExecuteReader();
                }
                if (sort != null)
                {
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM captureanimalcard WHERE id = '{id}' ORDER BY {sort}", connection());
                    connection().Close();
                    return command.ExecuteReader();
                }
                if (filter != null && sort != null)
                {
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM captureanimalcard WHERE id = '{id}' AND WHERE {filter} ORDER BY {sort}", connection());
                    connection().Close();
                    return command.ExecuteReader();
                }
                else
                {
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM captureanimalcard WHERE id = '{id}'", connection());
                    connection().Close();
                    return command.ExecuteReader();
                }
            }
        }
        public void addCaptureAnimalCard(CaptureAnimalCard captureAnimalCard)
        {
            MySqlCommand command = new MySqlCommand($"INSERT INTO captureanimalcard(anuimal_category,gender,size,hair,hair_color,ears,tail,special_signs,identification_label,electronic_chip_number,municipality,capture_act) " +
                $"VALUES ({captureAnimalCard.animal_category}, {captureAnimalCard.gender},{captureAnimalCard.size},{captureAnimalCard.hair}, {captureAnimalCard.hair_color}, {captureAnimalCard.ears},{captureAnimalCard.tail}, {captureAnimalCard.special_signs},{captureAnimalCard.identification_label}, {captureAnimalCard.electronic_chip_number}, {captureAnimalCard.municipality.id}, {captureAnimalCard.captureAct.number_id})", connection());
            connection().Close();
            command.ExecuteNonQuery();
        }

        public void deleteCaptureAnimalCard(CaptureAnimalCard captureAnimalCard)
        {
            MySqlCommand command = new MySqlCommand($"DELETE FROM captureanimalcard WHERE id = {captureAnimalCard.id}", connection());
            connection().Close();
            command.ExecuteNonQuery();
        }

        public void updateCaptureAnimalCard(CaptureAnimalCard captureAnimalCard)
        {
            MySqlCommand command = new MySqlCommand($"UPDATE captureanimalcard SET" +
                $"anuimal_category ={captureAnimalCard.animal_category}," +
                $"gender = {captureAnimalCard.gender}," +
                $"size = {captureAnimalCard.size}," +
                $"hair = {captureAnimalCard.hair}," +
                $"hair_color ={captureAnimalCard.hair_color}," +
                $"ears = {captureAnimalCard.ears}," +
                $"tail = {captureAnimalCard.tail}," +
                $"special_signs = {captureAnimalCard.special_signs}," +
                $"identification_label = {captureAnimalCard.identification_label}," +
                $"electronic_chip_number = {captureAnimalCard.electronic_chip_number}," +
                $"municipality = {captureAnimalCard.municipality.id}," +
                $"capture_act = {captureAnimalCard.captureAct.number_id} " +
                $"WHERE id = {captureAnimalCard.id};", connection());
            connection().Close();
            command.ExecuteNonQuery();
        }

    }
}
