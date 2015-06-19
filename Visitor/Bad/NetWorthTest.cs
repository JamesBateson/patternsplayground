using System;
using NUnit.Framework;

namespace Visitor.Bad
{
    [TestFixture]
    public class NetWorthTest
    {
        [Test]
        public void NetWorthIsCorrect ()
        {
            //Arrange
            var bankAccount = new BankAccount()
            {
                Balance = 10000m
            };

            var realEstate = new RealEstate()
            {
                EstimatedValue = 250000m
            };

            var loan = new Loan()
            {
                AmountOwed = 5000m
            };

            var person = new Person();
            person.AddAsset(bankAccount);
            person.AddAsset(realEstate);
            person.AddAsset(loan);

            //Act
            var netWorth = person.NetWorth;

            //Assert
            var expectedNetWorth = bankAccount.Balance + realEstate.EstimatedValue - loan.AmountOwed;
            Assert.That(netWorth, Is.EqualTo(expectedNetWorth));
        }
    }
}