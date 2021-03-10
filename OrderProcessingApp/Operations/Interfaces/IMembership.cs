using BusnessDomain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Interfaces
{
    public interface IMembership
    {
        bool ActivateMembership(Product product);
        bool UpgradeMembership(Product product);
        bool SendActivationMembershipEmail(Product product);
        bool SendUpgradeMembershipEmail(Product product);
    }
}
