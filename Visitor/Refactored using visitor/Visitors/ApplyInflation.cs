using System;

namespace Visitor.RefactoredUsingVisitor.Visitors
{
    public class ApplyInflation : IAssetVisitor
    {
        private readonly decimal _inflationPercentage;

        public ApplyInflation(decimal inflationPercentage)
        {
            if (inflationPercentage < 0 || inflationPercentage > 100)
            {
                throw new ArgumentException("Inflation percentage must be between 0 and 100");
            }

            _inflationPercentage = inflationPercentage/100;
        }

        public void Visit(RealEstate realEstate)
        {
            realEstate.EstimatedValue *= 1+_inflationPercentage;
        }

        public void Visit(BankAccount bankAccount)
        {
        }

        public void Visit(Loan loan)
        {
        }
    }
}