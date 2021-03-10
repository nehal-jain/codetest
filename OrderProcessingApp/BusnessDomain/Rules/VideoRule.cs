using BusnessDomain.Interfaces;
using Operations.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusnessDomain.Rules
{
    public class VideoRule : IOrderProcess
    {
        private readonly IFreebie _freebie;
        public VideoRule()
        {
            _freebie = new Operations.Operations();
        }
        public bool ProcessOrder(string productType)
        {
            //Add free video to the packing slip
            bool res1 = _freebie.AddFreeVideo();

            return res1;
        }
    }
}
