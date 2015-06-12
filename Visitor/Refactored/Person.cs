using System.Collections.Generic;

namespace Visitor.Refactored
{
    public class Person
    {
        private readonly IList<IAsset> _assets;

        public Person()
        {
            _assets = new List<IAsset>();
        }

        public void AddAsset(IAsset asset)
        {
            _assets.Add(asset);
        }

        public decimal NetWorth
        {
            get
            {
                var visitor = new NetWorthVisitor();
                foreach (var asset in _assets)
                {
                    asset.Accept(visitor);
                }
                return visitor.NetWorth;
            }
        }

        public decimal MonthlyIncome
        {
            get
            {
                var visitor = new MonthlyIncomeVisitor();
                foreach (var asset in _assets)
                {
                    asset.Accept(visitor);
                }
                return visitor.Income;    
            }
        }
    }
}