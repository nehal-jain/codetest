using BusnessDomain.Models;
using Operations.Interfaces;
using System;

namespace Operations
{
    public class Operations : IPackingSlip, IMembership, ICommission
    {
        public bool ActivateMembership(Product product)
        {
            throw new NotImplementedException();
        }

        public bool GenerateCommission(Product product)
        {
            throw new NotImplementedException();
        }

        public bool GenerateDuplicatePackingSlip(Product product)
        {
            throw new NotImplementedException();
        }

        public bool GeneratePackingSlip(Product product)
        {
            throw new NotImplementedException();
        }

        public bool SendActivationMembershipEmail(Product product)
        {
            throw new NotImplementedException();
        }

        public bool SendUpgradeMembershipEmail(Product product)
        {
            throw new NotImplementedException();
        }

        public bool UpgradeMembership(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
