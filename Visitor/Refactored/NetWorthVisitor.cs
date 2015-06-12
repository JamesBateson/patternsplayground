namespace Visitor.Refactored
{
    /// <summary>
    /// This visitor encapsulates all the logic related to calculating net worth of a person
    /// </summary>
    public class NetWorthVisitor : IAssetVisitor
    {
        public decimal NetWorth { get; private set; }

        public void Visit(RealEstate realEstate)
        {
            NetWorth += realEstate.EstimatedValue;
        }

        public void Visit(BankAccount bankAccount)
        {
            NetWorth += bankAccount.Balance;
        }

        public void Visit(Loan loan)
        {
            NetWorth -= loan.AmountOwed;
        }
    }
}