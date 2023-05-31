using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatchGraphPlan.PM;

namespace CatchGraphPlan.Role
{
    class PermManFactory
    {
        private static PermissionsManager pm;


        public static PermissionsManager getInstance()
        {
            return pm;
        }

        private static void setInstance(object obj)
        {
            if (pm == null)
                pm = obj as PermissionsManager;
        }


        public PermissionsManager getUserPermissions(Account account)
        {
            
            if (account.role.name == "Оператор ОМСУ")
            {
                setInstance(new OperatorOMSUPermissionsManager(account));
                return new OperatorOMSUPermissionsManager(account);
            }
            if (account.role.name == "Оператор ВетСлужбы")
            {
                setInstance(new OperatorVeterinaryPermissionsManager(account));
                return new OperatorVeterinaryPermissionsManager(account);
            }
            if (account.role.name == "Куратор ОМСУ")
            {
                setInstance(new TutorOMSUPermissionManager(account));
                return new TutorOMSUPermissionManager(account);
            }
            if (account.role.name == "Подписант ОМСУ")
            {
                setInstance(new SignatoryOMSUPermissionManager(account));
                return new SignatoryOMSUPermissionManager(account);
            }
            if(account.role.name == "Подписант приюта")
            {
                setInstance(new SignatoryShelterPermissionManager(account));
                return new SignatoryShelterPermissionManager(account);
            }
            if(account.role.name == "Подписант по отлову")
            {
                setInstance(new SignatoryAnimalControlPermissionManager(account));
                return new SignatoryAnimalControlPermissionManager(account);
            }
            if( account.role.name == "Подписант ВетСлужбы")
            {
                setInstance(new SignatoryVeterinaryPermissionManager(account));
                return new SignatoryVeterinaryPermissionManager(account);
            }
            if (account.role.name == "Куратор приюта")
            {
                setInstance(new TutorShelterPermissionManager(account));
                return new TutorShelterPermissionManager(account);
            }
            if (account.role.name == "Куратор по отлову")
            {
                setInstance(new TutorAnimalControlPermissionManager(account));
                return new TutorAnimalControlPermissionManager(account);
            }
            if(account.role.name == "Оператор по отлову")
            {
                setInstance(new OperatorAnimalControlPermissionManager(account));
                return new OperatorAnimalControlPermissionManager(account);
            }
            else // куратор вет службы
            {
                setInstance(new TutorVeterinaryPermissionManager(account));
                return new TutorVeterinaryPermissionManager(account);
            }
        }
    }
}
