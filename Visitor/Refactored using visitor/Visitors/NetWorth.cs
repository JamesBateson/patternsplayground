namespace Visitor.RefactoredUsingVisitor.Visitors
{
    /// <summary>
    /// This visitor encapsulates all the logic related to calculating net worth of a person
    /// </summary>
    public class NetWorth : IAssetVisitor
    {
        public decimal Worth { get; private set; }

        public void Visit(RealEstate realEstate)
        {
            Worth += realEstate.EstimatedValue;
        }

        public void Visit(BankAccount bankAccount)
        {
            Worth += bankAccount.Balance;
        }

        public void Visit(Loan loan)
        {
            Worth -= loan.AmountOwed;
        }
    }
}