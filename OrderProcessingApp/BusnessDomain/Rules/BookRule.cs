using BusnessDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusnessDomain.Rules
{
    public class BookRule : IOrderProcess
    {
        public bool ProcessOrder(string productType)
        {
            // Create Duplicate Packing Slip
            // Generate Commission For Agent
            throw new NotImplementedException();
        }
    }
}
