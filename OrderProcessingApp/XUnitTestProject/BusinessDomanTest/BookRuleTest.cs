using BusnessDomain.Models;
using BusnessDomain.Rules;
using Moq;
using Operations.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject.BusinessDomanTest
{
    public class BookRuleTest
    {
        private readonly Mock<IPackingSlip> mockPackingSlip;
        private readonly Mock<ICommission> mockCommission;
        private readonly BookRule bookRule;

        public BookRuleTest()
        {
            mockPackingSlip = new Mock<IPackingSlip>();
            mockCommission = new Mock<ICommission>();
            bookRule = new BookRule();
        }

        [Fact]
        public void ProcessOrder_Book()
        {
            //Arrange
            mockPackingSlip.Setup(x => x.GenerateDuplicatePackingSlip()).Returns(true);
            mockCommission.Setup(x => x.GenerateCommission()).Returns(true);

            //Act
            var result = bookRule.ProcessOrder(ProductType.Book.ToString());

            //Assert
            Assert.True(result);
        }
    }
}
