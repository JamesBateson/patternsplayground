using System;

namespace Builder
{
    public class RegularSandwichMaker : SandwichMaker
    {
        public RegularSandwichMaker(SandwichBuilder builder)
        {
            _builder = builder;
        }

        public override void MakeMeASandwich()
        {
            _builder.CreateNewSandwich();
            _builder.PrepareBread();
            _builder.ApplyMeatAndCheese();
            _builder.ApplyVegetables();
            _builder.AddCondiments();
        }

        
    }
}