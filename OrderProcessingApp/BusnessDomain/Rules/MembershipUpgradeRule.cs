using BusnessDomain.Interfaces;
using Operations.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusnessDomain.Rules
{
    public class MembershipUpgradeRule : IOrderProcess
    {
        private readonly IMembership _membership;

        public MembershipUpgradeRule()
        {
            _membership = new Operations.Operations();
        }

        public bool ProcessOrder(string productType)
        {
            // Apply the upgrade
            bool res1 = _membership.UpgradeMembership();

            // Email the owner and inform them of activation/upgrade
            bool res2 = _membership.SendUpgradeMembershipEmail();

            return res1 && res2;
        }
    }
}
