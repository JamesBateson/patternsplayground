namespace Visitor.Bad
{
    //Imagine that these assets are stable and unlikely to change

    public class BankAccount : IAsset
    {
        public decimal Balance { get; set; }
        public decimal MonthlyInterest { get; set; }
        //etc
    }

    public class RealEstate : IAsset
    {
        public decimal EstimatedValue { get; set; }
        public decimal MonthlyRent { get; set; }
        //etc
    }

    public class Loan : IAsset
    {
        public decimal AmountOwed { get; set; }
        public decimal MonthlyPayment { get; set; }
        //etc
    }
}