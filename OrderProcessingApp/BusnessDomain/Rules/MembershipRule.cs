using BusnessDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusnessDomain.Rules
{
    public class MembershipRule : IOrderProcess
    {
        ////Activate Membership
        //Email the owner and inform them about activation/upgrade
        public bool ProcessOrder(string productType)
        {
            throw new NotImplementedException();
        }
    }
}
