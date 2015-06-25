using System;

namespace Visitor
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            RunBadSolution();

            Console.WriteLine();

            RunVisitorSolution();

            Console.WriteLine();

            RunPolymorphicSolution();

            Console.WriteLine();

            DoubleDispatch.DoubleDispatch.RunDoubleDispatchCode();

            Console.ReadKey();
        }

        private static void RunBadSolution()
        {
            Console.WriteLine("*** Bad code ***");
            var person = new Bad.Person();
            person.AddAsset(new Bad.BankAccount { Balance = 1000.00m });
            person.AddAsset(new Bad.RealEstate() { EstimatedValue = 250000.00m });
            person.AddAsset(new Bad.Loan { AmountOwed = 1000.00m });
            Console.WriteLine("Net worth calculated with the bad version: {0}", person.NetWorth);
        }

        private static void RunVisitorSolution()
        {
            Console.WriteLine("*** Refactored using visitor ***");
            var person = new RefactoredUsingVisitor.Person();
            person.AddAsset(new RefactoredUsingVisitor.BankAccount {Balance = 1000.00m, MonthlyInterest = 0.03m});
            person.AddAsset(new RefactoredUsingVisitor.RealEstate() {EstimatedValue = 250000.00m, MonthlyRent = 10000m});
            person.AddAsset(new RefactoredUsingVisitor.Loan {AmountOwed = 1000.00m, MonthlyPayment = 20m});

            var netWorthVisitor = new RefactoredUsingVisitor.NetWorthVisitor();
            person.Accept(netWorthVisitor);
            var monthlyIncomeVisitor = new RefactoredUsingVisitor.MonthlyIncomeVisitor();
            person.Accept(monthlyIncomeVisitor);
            Console.WriteLine("Net worth calculated with the visitor solution: {0}", netWorthVisitor.NetWorth);
            Console.WriteLine("Monthly income: {0}", monthlyIncomeVisitor.Income);
        }

        private static void RunPolymorphicSolution()
        {
            Console.WriteLine("*** Refactored using polymorphism");

            var person = new RefactoredUsingPolymorphism.Person();
            person.AddAsset(new RefactoredUsingPolymorphism.BankAccount { Balance = 1000.00m, MonthlyInterest = 0.03m });
            person.AddAsset(new RefactoredUsingPolymorphism.RealEstate() { EstimatedValue = 250000.00m, MonthlyRent = 10000m });
            person.AddAsset(new RefactoredUsingPolymorphism.Loan { AmountOwed = 1000.00m, MonthlyPayment = 20m });

            Console.WriteLine("Net worth calculated with the polymorphic solution: {0}", person.NetWorth);
        }
    }
}