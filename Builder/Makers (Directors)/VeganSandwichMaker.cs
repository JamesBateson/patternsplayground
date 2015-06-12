namespace Builder
{
    //This is a bit contrived but represents a different way to make a sandwich
    public class VeganSandwichMaker : SandwichMaker
    {
        public VeganSandwichMaker(SandwichBuilder builder)
        {
            _builder = builder;
        }

        public override void MakeMeASandwich()
        {
            _builder.CreateNewSandwich();
            _builder.PrepareBread();
            _builder.ApplyVegetables();
            _builder.AddCondiments();
        }
    }
}