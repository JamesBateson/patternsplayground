using NUnit.Framework;
using Visitor.RefactoredUsingVisitor.Visitors;

namespace Visitor.RefactoredUsingVisitor
{
    [TestFixture]
    public class TestMonthlyIncome
    {
        [Test]
        public void NetWorthCalculatesCorrectValue()
        {
            //Arrange
            var bankAccount = new BankAccount()
            {
                Balance = 10000m,
                MonthlyInterest = 0.05m
            };

            var realEstate = new RealEstate()
            {
                MonthlyRent = 5000m
            };

            var loan = new Loan()
            {
                MonthlyPayment = 200m
            };

            var person = new Person();
            person.AddAsset(bankAccount);
            person.AddAsset(realEstate);
            person.AddAsset(loan);

            //Act
            var monthlyIncome = new MonthlyIncome();
            person.Accept(monthlyIncome);

            //Assert
            Assert.That(monthlyIncome.Income, Is.EqualTo(5300));
        }
    }
}