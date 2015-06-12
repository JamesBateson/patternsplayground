using System;

namespace Visitor
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var person1 = new Bad.Person();
            person1.AddAsset(new Bad.BankAccount {Balance = 1000.00m});
            person1.AddAsset(new Bad.RealEstate() {EstimatedValue = 250000.00m});
            person1.AddAsset(new Bad.Loan {AmountOwed = 1000.00m});
            Console.WriteLine("Net worth calculated with the bad version: {0}", person1.NetWorth);
            Console.WriteLine("\n");

            var person2 = new Refactored.Person();
            person2.AddAsset(new Refactored.BankAccount { Balance = 1000.00m, MonthlyInterest = 0.03m});
            person2.AddAsset(new Refactored.RealEstate() { EstimatedValue = 250000.00m, MonthlyRent = 10000m});
            person2.AddAsset(new Refactored.Loan { AmountOwed = 1000.00m, MonthlyPayment = 20m});
            Console.WriteLine("Net worth calculated with the refactored version: {0}", person2.NetWorth);
            Console.WriteLine("Monthly income: {0}", person2.MonthlyIncome);

            Console.ReadKey();
        }
    }
}