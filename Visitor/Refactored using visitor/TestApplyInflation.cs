using NUnit.Framework;
using Visitor.RefactoredUsingVisitor.Visitors;

namespace Visitor.RefactoredUsingVisitor
{
    [TestFixture]
    public class TestApplyInflation
    {
        [Test]
        public void ApplyInflationCorrectlyInflatesRealEstateValue()
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
            var applyInflation = new ApplyInflation(12m);
            person.Accept(applyInflation);

            //Assert
            Assert.That(realEstate.EstimatedValue, Is.EqualTo(280000));
            Assert.That(bankAccount.Balance, Is.EqualTo(10000));
            Assert.That(loan.AmountOwed, Is.EqualTo(5000));
        }
    }
}