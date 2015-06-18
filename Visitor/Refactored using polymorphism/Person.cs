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

        public decimal NetWorth
        {
            get
            {
                return Assets.Sum(asset => asset.NetWorth);
            }
        }
    }
}