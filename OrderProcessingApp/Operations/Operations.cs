
using Operations.Interfaces;
using System;

namespace Operations
{
    public class Operations : IPackingSlip, IMembership, ICommission, IFreebie
    {
        public bool GeneratePackingSlip()
        {
            Console.WriteLine("\nGenerated packing slip...");
            return true;
        }
        public bool GenerateDuplicatePackingSlip()
        {
            Console.WriteLine("\nGenerated duplicate packing slip...");
            return true;
        }

        public bool GenerateCommission()
        {
            Console.WriteLine("\nCommission generated for the agent...");
            return true;
        }

        public bool ActivateMembership()
        {
            Console.WriteLine("\nMembership Activated...");
            return true;
        }
        public bool UpgradeMembership()
        {
            Console.WriteLine("\nMembership has been activated...");
            return true;
        }

        public bool SendActivationMembershipEmail()
        {
            Console.WriteLine("\nEmail sent to inform the owner about the activatation of the membership...");
            return true;
        }

        public bool SendUpgradeMembershipEmail()
        {
            Console.WriteLine("\nEmail sent to inform the owner about the upgrade in membership...");
            return true;
        }

        public bool AddFreeVideo()
        {
            Console.WriteLine("\nAdded a free video to the packing slip...");
            return true;
        }
    }
}
