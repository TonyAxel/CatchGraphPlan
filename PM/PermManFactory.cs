using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchGraphPlan.PM
{
    class PermManFactory
    {
        public PM getUserPermissions(Account account)
        {
            return new PM(account);
        }
    }
}
