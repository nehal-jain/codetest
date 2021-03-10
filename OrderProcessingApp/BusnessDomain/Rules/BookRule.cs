using BusnessDomain.Interfaces;
using Operations.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusnessDomain.Rules
{
    public class BookRule : IOrderProcess
    {
        private readonly IPackingSlip _packingSlip;
        private readonly ICommission _commision;
        public BookRule()
        {

            _packingSlip = new Operations.Operations();
            _commision = new Operations.Operations();
        }
        public bool ProcessOrder(string productType)
        {
            // Create Duplicate Packing Slip
            bool res1 = _packingSlip.GenerateDuplicatePackingSlip();

            // Generate Commission For Agent
            bool res2 = _commision.GenerateCommission();

            return res1 && res2;

        }
    }
}
