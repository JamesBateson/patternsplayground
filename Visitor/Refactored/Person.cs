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
                var netWorthVisitor = new NetWorthVisitor();
                VisitAssets(netWorthVisitor);
                return netWorthVisitor.NetWorth;
            }
        }

        public decimal MonthlyIncome
        {
            get
            {
                var monthlyIncomeVisitor = new MonthlyIncomeVisitor();
                VisitAssets(monthlyIncomeVisitor);
                return monthlyIncomeVisitor.Income;
            }
        }

        private void VisitAssets(IAssetVisitor visitor)
        {
            foreach (var asset in _assets)
            {
                asset.Accept(visitor);
            }
        }
    }
}