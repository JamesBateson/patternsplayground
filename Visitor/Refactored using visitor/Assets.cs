using Visitor.RefactoredUsingVisitor.Visitors;

namespace Visitor.RefactoredUsingVisitor
{
    public class BankAccount : IAsset
    {
        public void Accept(IAssetVisitor assetVisitor)
        {
            assetVisitor.Visit(this);
        }

        public decimal Balance { get; set; }
        public decimal MonthlyInterest { get; set; }
        //etc
    }

    public class RealEstate : IAsset
    {
        public void Accept(IAssetVisitor assetVisitor)
        {
            assetVisitor.Visit(this);
        }

        public decimal EstimatedValue { get; set; }
        public decimal MonthlyRent { get; set; }
        //etc
    }

    public class Loan : IAsset
    {
        public void Accept(IAssetVisitor assetVisitor)
        {
            assetVisitor.Visit(this);
        }

        public decimal AmountOwed { get; set; }
        public decimal MonthlyPayment { get; set; }
        //etc
    }
}