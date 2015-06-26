using Visitor.Bad;

namespace Visitor.DoubleDispatch
{
    public interface IAssetOperation
    {
        decimal Calculate(BankAccount bankAccount);
        decimal Calculate(RealEstate realEstate);
        decimal Calculate(Loan loan);
    }

    public class NetWorth : IAssetOperation
    {
        public decimal Calculate(BankAccount bankAccount)
        {
            return bankAccount.Balance;
        }

        public decimal Calculate(RealEstate realEstate)
        {
            return realEstate.EstimatedValue;
        }

        public decimal Calculate(Loan loan)
        {
            return -loan.AmountOwed;
        }
    }
}