﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatchGraphPlan.Capture;
using CatchGraphPlan.PM;

namespace CatchGraphPlan.Role
{
    internal class OperatorOMSUPermissionsManager: PermissionsManager
    {
        public OperatorOMSUPermissionsManager(Account account): base(account) { }

        public override bool canEditRegister(object obj)
        {
            if(obj is CapturePlan)
            {
                return false;
            }
            if(obj is CaptureAct)
            {
                return false;
            }
            if(obj is CaptureAnimalCard)
            {
                return false;
            }
            if(obj is Company)
            {
                return true;
            }
            if(obj is CaptureMunicipalContract)
            {
                return true;
            }

            return false;
        }
    }
}
