using System.Collections.Generic;

namespace Visitor.Bad
{
    public class Person
    {
        public Person()
        {
            Assets = new List<IAsset>();
        }

        public IList<IAsset> Assets { get; private set; }

        public void AddAsset(IAsset asset)
        {
            Assets.Add(asset);
        }

        public decimal NetWorth
        {
            get
            {
                decimal netWorth = 0;

                //Type sniffing is definitely a code smell and you should consider the Visitor pattern when you see code like this
                foreach (IAsset asset in Assets)
                {
                    var bankAccount = asset as BankAccount;
                    if (bankAccount != null)
                    {
                        //We have to know the specific details of each asset
                        netWorth += bankAccount.Balance;
                    }

                    var property = asset as RealEstate;
                    if (property != null)
                    {
                        netWorth += property.EstimatedValue;
                    }

                    var loan = asset as Loan;
                    if (loan != null)
                    {
                        netWorth -= loan.AmountOwed;
                    }

                    //If another type of asset is added, we have to come in here and add some more logic
                    //This is a breach of the open-closed principle and the DRY principle
                    //This actually isn't fixed with the visitor pattern, but would be by a polymorphic approach (See Refactored using polymorphism)
                }

                return netWorth;
            }
        }
    }
}