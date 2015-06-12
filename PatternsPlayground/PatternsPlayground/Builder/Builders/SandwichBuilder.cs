namespace Builder
{
    public abstract class SandwichBuilder
    {
        public Sandwich GetSandwich()
        {
            return _sandwich;
        }

        public abstract void CreateNewSandwich();
        public abstract void PrepareBread();
        public abstract void ApplyMeatAndCheese();
        public abstract void ApplyVegetables();
        public abstract void AddCondiments();

        protected Sandwich _sandwich;



    }
}