using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchGraphPlan.PM
{
    public class PM:PermissionsManager
    {
        public PM(Account account)
        {
            this.Account = account;
        }
    }
}
