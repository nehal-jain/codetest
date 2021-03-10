using Factory.Interfaces;
using Factory;
using System;
using BusnessDomain.Interfaces;
using BusnessDomain.Models;
using BusnessDomain.Rules;

namespace Factory
{
    public class ProductFacotry : IProductFactory
    {
        public IOrderProcess GetProductRuleInstance(ProductType productType)
        {
            IOrderProcess orderRule;
            switch (productType)
            {
                case ProductType.PhysicalProduct:
                    orderRule = new PhysicalProductRule();
                    break;
                case ProductType.Book:
                    orderRule = new BookRule();
                    break;
                case ProductType.Membership:
                    orderRule = new MembershipRule();
                    break;
                case ProductType.MembershipUpgrade:
                    orderRule = new MembershipUpgradeRule();
                    break;
                case ProductType.Video:
                    orderRule = new VideoRule();
                    break;
                default:
                    orderRule = new PhysicalProductRule();
                    break;
            }
            return orderRule;
        }
    }
}
