namespace Visitor.RefactoredUsingPolymorphism
{
    //It might be better to take this approach if the assets are more likely to change than the operations
    //that will be applied to them
    //In this case, adding new assets does not violate the open-closed prinicple.

    //If the operations are more likely to be changed, then this approach is probably not ideal:
    //1. You would need to go into each asset and add another operation (e.g. monthly income) - violates the OC principle
    //and would be laborious if there are lots of assets
    //2. There will be code repetition (see Person.cs class) so may violate the DRY principle.
    //3. Assets will know how to calculate all sorts of things.  This violates the Single Responsibility Principle.

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