namespace Visitor.RefactoredUsingVisitor
{
    public interface IAssetVisitor
    {
        void Visit(RealEstate realEstate);
        void Visit(BankAccount bankAccount);
        void Visit(Loan loan);
    }
}