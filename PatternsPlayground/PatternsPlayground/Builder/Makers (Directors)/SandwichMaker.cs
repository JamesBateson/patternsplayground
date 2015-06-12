namespace Builder
{
    public abstract class SandwichMaker
    {
        protected SandwichBuilder _builder;
        public abstract void MakeMeASandwich();
        public Sandwich GetSandwich()
        {
            return _builder.GetSandwich();
        }
    }
}