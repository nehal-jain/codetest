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
    public class MembershipRuleTest
    {
        private readonly Mock<IMembership> mockMembership;
        private readonly MembershipRule _membershipRule;

        public MembershipRuleTest()
        {
            mockMembership = new Mock<IMembership>();
            _membershipRule = new MembershipRule();
        }

        [Fact]
        public void ProcessOrder_Membership()
        {
            //Arrange
            mockMembership.Setup(x => x.ActivateMembership()).Returns(true);
            mockMembership.Setup(x => x.SendActivationMembershipEmail()).Returns(true);

            //Act
            var result = _membershipRule.ProcessOrder(ProductType.Membership.ToString());

            //Assert
            Assert.True(result);
        }
    }
}
