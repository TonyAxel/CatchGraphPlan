﻿using CatchGraphPlan.Capture;
using CatchGraphPlan.PM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchGraphPlan.Role
{
    internal class OperatorAnimalControlPermissionManager: PermissionsManager
    {
        public OperatorAnimalControlPermissionManager(Account account) : base(account) { }

        public override bool canEditRegister(object obj)
        {
            if (obj is CapturePlan)
            {
                return true;
            }
            if (obj is CaptureAnimalControl)
            {
                return true;
            }
            if (obj is CaptureAnimalCard)
            {
                return true;
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
