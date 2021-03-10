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
    public class VideoRuleTest
    {
        private readonly Mock<IFreebie> mockFreebie;
        private readonly VideoRule videoRule;

        public VideoRuleTest()
        {
            mockFreebie = new Mock<IFreebie>();
            videoRule = new VideoRule();
        }

        [Fact]
        public void ProcessOrder_Book()
        {
            //Arrange
            mockFreebie.Setup(x => x.AddFreeVideo()).Returns(true);

            //Act
            var result = videoRule.ProcessOrder(ProductType.Video.ToString());

            //Assert
            Assert.True(result);
        }
    }
}
