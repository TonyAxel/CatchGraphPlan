using CatchGraphPlan.Capture;
using CatchGraphPlan.PM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchGraphPlan.Role
{
    internal class TutorAnimalControlPermissionManager: PermissionsManager
    {
        public TutorAnimalControlPermissionManager(Account account) : base(account) { }

        public override bool canEditRegister(object obj)
        {
            if (obj is CapturePlan)
            {
                return false;
            }
            if (obj is CaptureAct)
            {
                return false;
            }
            if (obj is CaptureAnimalCard)
            {
                return false;
            }
            if (obj is Company)
            {
                return false;
            }
            if (obj is CaptureMunicipalContract)
            {
                return false;
            }

            return false;
        }
    }
}
