namespace Visitor.RefactoredUsingPolymorphism
{
    //It might be better to take this approach if the assets are more likely to change than the operations
    //that will be applied to them
    //In this case, adding new assets does not violate the open-closed prinicple.

    public class BankAccount : IAsset
    {
        public decimal Balance { get; set; }
        public decimal MonthlyInterest { get; set; }
        //etc

        public decimal NetWorth
        {
            get { return Balance; }
        }
    }

    public class RealEstate : IAsset
    {
        public decimal EstimatedValue { get; set; }
        public decimal MonthlyRent { get; set; }
        //etc

        public decimal NetWorth
        {
            get { return EstimatedValue; }
        }
    }

    public class Loan : IAsset
    {
        public decimal AmountOwed { get; set; }
        public decimal MonthlyPayment { get; set; }
        //etc
        
        public decimal NetWorth
        {
            get { return -AmountOwed; }
        }
    }
}