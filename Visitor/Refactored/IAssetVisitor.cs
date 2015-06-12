using Visitor.Bad;

namespace Visitor.Refactored
{
    public interface IAssetVisitor
    {
        void Visit(RealEstate realEstate);
        void Visit(BankAccount bankAccount);
        void Visit(Loan loan);
    }
}