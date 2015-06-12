using System.Collections.Generic;

namespace Builder
{
    public class MySandwichBuilder : SandwichBuilder
    {
        public override void CreateNewSandwich()
        {
            _sandwich = new Sandwich("My lovely sandwich");
        }

        public override void PrepareBread()
        {
            _sandwich.BreadType = BreadType.White;
            _sandwich.IsToasted = true;
        }

        public override void ApplyMeatAndCheese()
        {
            _sandwich.CheeseType = CheeseType.Cheddar;
            _sandwich.MeatType = MeatType.Turkey;
        }

        public override void ApplyVegetables()
        {
            _sandwich.Vegetables = new List<string>() {"Tomato", "Onion"};
        }

        public override void AddCondiments()
        {
            _sandwich.HasMayo = false;
            _sandwich.HasMustard = true;
        }
    }
}