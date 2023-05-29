using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatchGraphPlan.Capture;

namespace CatchGraphPlan.PM
{
    public abstract class PermissionsManager
    {
        public Account Account;

        public string canEditRegister(object obj)
        {
            if (obj is Company)
            {
                if (Account.role.name == "Оператор ВетСлужбы")
                {
                    return "Оператор ВетСлужбы";
                }
                if (Account.role.name == "Оператор ОМСУ")
                {
                    return "Оператор ОМСУ";
                }
                if(Account.role.name == "Куратор ОМСУ" || Account.role.name == "Подписант ОМСУ")
                {
                    return "Куратор ОМСУ";
                }
                else
                {
                    return "Просмотр";
                }
            }
            else
            {
                return null;
            }
        }
    }
}
