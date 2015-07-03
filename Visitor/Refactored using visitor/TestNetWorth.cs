using NUnit.Framework;
using Visitor.RefactoredUsingVisitor.Visitors;

namespace Visitor.RefactoredUsingVisitor
{
    [TestFixture]
    public class TestNetWorth
    {
        [Test]
        public void NetWorthCalculatesCorrectValue()
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
            var netWorth = new NetWorth();
            person.Accept(netWorth);

            //Assert
            Assert.That(netWorth.Worth, Is.EqualTo(255000));
        }
    }
}