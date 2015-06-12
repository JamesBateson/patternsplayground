﻿namespace Visitor.Refactored
{
    public class BankAccount : IAsset
    {
        public void Accept(IPersonVisitor personVisitor)
        {
            personVisitor.Visit(this);
        }

        public decimal Balance { get; set; }
        public decimal MonthlyInterest { get; set; }
        //etc
    }

    public class RealEstate : IAsset
    {
        public void Accept(IPersonVisitor personVisitor)
        {
            personVisitor.Visit(this);
        }

        public decimal EstimatedValue { get; set; }
        public decimal MonthlyRent { get; set; }
        //etc
    }

    public class Loan : IAsset
    {
        public void Accept(IPersonVisitor personVisitor)
        {
            personVisitor.Visit(this);
        }

        public decimal AmountOwed { get; set; }
        public decimal MonthlyPayment { get; set; }
        //etc
    }
}