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
    public class MembershipUpgradeRuleTest
    {
        private readonly Mock<IMembership> mockMembership;
        private readonly MembershipUpgradeRule _membershipUpgradeRule;

        public MembershipUpgradeRuleTest()
        {
            mockMembership = new Mock<IMembership>();
            _membershipUpgradeRule = new MembershipUpgradeRule();
        }

        [Fact]
        public void ProcessOrder_Membership()
        {
            //Arrange
            mockMembership.Setup(x => x.UpgradeMembership()).Returns(true);
            mockMembership.Setup(x => x.SendUpgradeMembershipEmail()).Returns(true);

            //Act
            var result = _membershipUpgradeRule.ProcessOrder(ProductType.MembershipUpgrade.ToString());

            //Assert
            Assert.True(result);
        }
    }
}
