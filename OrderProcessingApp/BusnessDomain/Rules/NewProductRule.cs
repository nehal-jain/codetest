using BusnessDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusnessDomain.Rules
{
    public class NewProductRule : IOrderProcess
    {
        public bool ProcessOrder(string productType)
        {
            
            return false;
        }
    }
}
