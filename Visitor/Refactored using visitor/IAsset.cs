namespace Visitor.RefactoredUsingVisitor
{
    public interface IAsset
    {
        void Accept(IAssetVisitor visitor);
    }
}