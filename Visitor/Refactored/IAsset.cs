namespace Visitor.Refactored
{
    public interface IAsset
    {
        void Accept(IAssetVisitor visitor);
    }
}