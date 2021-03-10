using BusnessDomain.Interfaces;
using BusnessDomain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Interfaces
{
    public interface IProductFactory
    {
        public IOrderProcess GetProductRuleInstance(ProductType productType);
    }
}
