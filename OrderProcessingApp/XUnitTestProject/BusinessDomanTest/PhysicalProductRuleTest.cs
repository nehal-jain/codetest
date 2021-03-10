using System;
using Xunit;
using BusnessDomain;
using BusnessDomain.Interfaces;
using BusnessDomain.Rules;
using Moq;
using Operations.Interfaces;
using BusnessDomain.Models;

namespace XUnitTestProject.BusinessDomanTest
{
    public class PhysicalProductRuleTest
    {
        private readonly Mock<IPackingSlip> mockPackingSlip;
        private readonly Mock<ICommission> mockCommission;
        private readonly PhysicalProductRule physicalProductRule;
        

        public PhysicalProductRuleTest()
        {
            mockPackingSlip = new Mock<IPackingSlip>();
            mockCommission = new Mock<ICommission>();
            physicalProductRule = new PhysicalProductRule();
        }

        [Fact]
        public void ProcessOrder_PhysicalProduct()
        {
            //Arrange
            mockPackingSlip.Setup(x => x.GeneratePackingSlip()).Returns(true);
            mockCommission.Setup(x => x.GenerateCommission()).Returns(true);

            //Act
            var result = physicalProductRule.ProcessOrder(ProductType.PhysicalProduct.ToString());

            //Assert
            Assert.True(result);
        }
    }
}
