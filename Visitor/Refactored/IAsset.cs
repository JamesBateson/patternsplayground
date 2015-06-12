namespace Visitor.Refactored
{
    public interface IAsset
    {
        void Accept(IPersonVisitor personVisitor);
    }
}