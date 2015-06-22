using System.Collections.Generic;
using System.Linq;

namespace Visitor.RefactoredUsingPolymorphism
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

        //We would have to add a new property for each new operation.
        //The code would be very similar (iterating over all assets) - thus violating the DRY principle.
        public decimal NetWorth
        {
            get
            {
                return Assets.Sum(asset => asset.NetWorth);
            }
        }
    }
}