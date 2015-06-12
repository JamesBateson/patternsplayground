using System;

namespace Visitor
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            RunBadCode();

            Console.WriteLine();

            RunRefactoredCode();

            Console.ReadKey();
        }

        private static void RunBadCode()
        {
            Console.WriteLine("*** Bad code ***");
            var person = new Bad.Person();
            person.AddAsset(new Bad.BankAccount { Balance = 1000.00m });
            person.AddAsset(new Bad.RealEstate() { EstimatedValue = 250000.00m });
            person.AddAsset(new Bad.Loan { AmountOwed = 1000.00m });
            Console.WriteLine("Net worth calculated with the bad version: {0}", person.NetWorth);
        }

        private static void RunRefactoredCode()
        {
            Console.WriteLine("*** Refactored code ***");
            var person = new Refactored.Person();
            person.AddAsset(new Refactored.BankAccount {Balance = 1000.00m, MonthlyInterest = 0.03m});
            person.AddAsset(new Refactored.RealEstate() {EstimatedValue = 250000.00m, MonthlyRent = 10000m});
            person.AddAsset(new Refactored.Loan {AmountOwed = 1000.00m, MonthlyPayment = 20m});

            Console.WriteLine("Net worth calculated with the refactored version: {0}", person.NetWorth);
            Console.WriteLine("Monthly income: {0}", person.MonthlyIncome);
        }
    }
}