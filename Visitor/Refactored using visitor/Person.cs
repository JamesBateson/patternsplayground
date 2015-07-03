using System.Collections.Generic;
using Visitor.RefactoredUsingVisitor.Visitors;

namespace Visitor.RefactoredUsingVisitor
{
    public class Person : IAsset
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
        
        public void Accept(IAssetVisitor visitor)
        {
            foreach (var asset in _assets)
            {
                asset.Accept(visitor);
            }
        }
    }
}