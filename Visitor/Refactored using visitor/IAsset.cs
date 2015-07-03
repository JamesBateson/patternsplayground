using Visitor.RefactoredUsingVisitor.Visitors;

namespace Visitor.RefactoredUsingVisitor
{
    public interface IAsset
    {
        void Accept(IAssetVisitor visitor);
    }
}