using BusnessDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusnessDomain.Rules
{
    public class VideoRule : IOrderProcess
    {
        //Add free video to the packing slip
        public bool ProcessOrder(string productType)
        {
            throw new NotImplementedException();
        }
    }
}
