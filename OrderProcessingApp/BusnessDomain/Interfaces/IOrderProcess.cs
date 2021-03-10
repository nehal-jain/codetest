using System;
using System.Collections.Generic;
using System.Text;

namespace BusnessDomain.Interfaces
{
    public interface IOrderProcess
    {
        public bool ProcessOrder(string productType);
    }
}
