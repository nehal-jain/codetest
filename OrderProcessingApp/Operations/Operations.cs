
using Operations.Interfaces;
using System;

namespace Operations
{
    public class Operations : IPackingSlip, IMembership, ICommission
    {
        public bool GeneratePackingSlip()
        {
            Console.WriteLine("Generated packing slip...");
            return true;
        }
        public bool GenerateDuplicatePackingSlip()
        {
            Console.WriteLine("Generated duplicate packing slip...");
            return true;
        }

        public bool GenerateCommission()
        {
            Console.WriteLine("Commission generated for the agent...");
            return true;
        }

        public bool ActivateMembership()
        {
            Console.WriteLine("Membership Activated...");
            return true;
        }
        public bool UpgradeMembership()
        {
            Console.WriteLine("Membership has been activated...");
            return true;
        }

        public bool SendActivationMembershipEmail()
        {
            Console.WriteLine("Email sent to inform the owner about the activatation of the membership...");
            return true;
        }

        public bool SendUpgradeMembershipEmail()
        {
            Console.WriteLine("Email sent to inform the owner about the upgrade in membership...");
            return true;
        }

        
    }
}
