using BusnessDomain.Interfaces;
using Operations.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusnessDomain.Rules
{
    public class MembershipRule : IOrderProcess
    {
        private readonly IMembership _membership;
        public MembershipRule()
        {
            _membership = new Operations.Operations();
        }
        
        public bool ProcessOrder(string productType)
        {
            //Activate Membership
            bool res1 = _membership.ActivateMembership();

            //Email the owner and inform them about activation
            bool res2 = _membership.SendActivationMembershipEmail();

            return res1 && res2;
        }
    }
}
