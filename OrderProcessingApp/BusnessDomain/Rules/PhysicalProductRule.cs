using BusnessDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusnessDomain.Rules
{
    public class PhysicalProductRule : IOrderProcess
    {
        public bool ProcessOrder(string productType)
        {
            // Generate Packing Slip
            // Generate Commission For Agent
            throw new NotImplementedException();
        }
    }
}
