using BusnessDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusnessDomain.Rules
{
    public class MembershipUpgradeRule : IOrderProcess
    {
        // Apply the upgrade
        // Email the owner and inform them of activation/upgrade
        public bool ProcessOrder(string productType)
        {
            throw new NotImplementedException();
        }
    }
}
