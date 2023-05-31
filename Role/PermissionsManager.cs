using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatchGraphPlan.Capture;
using CatchGraphPlan.PM;

namespace CatchGraphPlan.Role
{
    public abstract class PermissionsManager
    {
        public Account Account;

        public abstract bool canEditRegister(object obj);

        public PermissionsManager(Account account) {

            this.Account = account;
        }
        
    }
}
