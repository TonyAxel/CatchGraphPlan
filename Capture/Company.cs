using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchGraphPlan.Capture
{
    public class Company
    {
        public int id;
        public string name;
        public int inn;
        public int kpp;
        public string registrationAdress;
        public CompanyType companyType;
        public CompanySign companySign;
        public Company()
        {

        }
        public Company(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public Company(int id, string name, int inn, int kpp, string registrationAdress, CompanyType companyType, CompanySign companySign)
        {
            this.id = id;
            this.name = name;
            this.inn = inn;
            this.kpp = kpp;
            this.registrationAdress = registrationAdress;
            this.companyType = companyType;
            this.companySign = companySign;
        }
    }
}
