using System;
using System.Collections.Generic;
using System.Text;
using BusnessDomain;
using BusnessDomain.Models;

namespace Operations.Interfaces
{
    public interface ICommission
    {
        public bool GenerateCommission(Product product);

    }
}
