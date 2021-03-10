using System;
using System.Collections.Generic;
using System.Text;
using BusnessDomain;
using BusnessDomain.Models;

namespace Operations.Interfaces
{
    public interface IPackingSlip
    {
        public bool GeneratePackingSlip(Product product);
        public bool GenerateDuplicatePackingSlip(Product product);

    }
}
