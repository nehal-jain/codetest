
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Interfaces
{
    public interface IMembership
    {
        bool ActivateMembership();
        bool UpgradeMembership();
        bool SendActivationMembershipEmail();
        bool SendUpgradeMembershipEmail();
    }
}
