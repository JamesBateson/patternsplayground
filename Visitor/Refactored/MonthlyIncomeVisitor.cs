namespace Visitor.Refactored
{
    /// <summary>
    /// We could add all this logic without touching any other classes i.e. we are adhering to the open-closed principle
    /// </summary>
    public class MonthlyIncomeVisitor : IPersonVisitor
    {
        public decimal Income { get; private set; }

        public void Visit(RealEstate realEstate)
        {
            Income += realEstate.MonthlyRent;
        }

        public void Visit(BankAccount bankAccount)
        {
            Income += bankAccount.Balance * bankAccount.MonthlyInterest;
        }

        public void Visit(Loan loan)
        {
            Income -= loan.MonthlyPayment;
        }
    }
}