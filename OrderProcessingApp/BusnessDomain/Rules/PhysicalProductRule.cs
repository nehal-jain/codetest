using BusnessDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Operations;
using Operations.Interfaces;

namespace BusnessDomain.Rules
{
    public class PhysicalProductRule : IOrderProcess
    {
        private readonly IPackingSlip _packingSlip; 
        private readonly ICommission _commision;
        public PhysicalProductRule()
        {
            _packingSlip = new Operations.Operations();
            _commision = new Operations.Operations();
        }

        public bool ProcessOrder(string productType)
        {
            // Generate Packing Slip
           bool res1 = _packingSlip.GeneratePackingSlip();

            // Generate Commission For Agent
            bool res2 = _commision.GenerateCommission();

            return res1 && res2;
        }
    }
}
