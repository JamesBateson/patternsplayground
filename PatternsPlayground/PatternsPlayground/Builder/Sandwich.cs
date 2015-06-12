using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Builder
{
    public class Sandwich
    {
        //Inject non-optional stuff here.
        public Sandwich(string name)
        {
            _name = name;
        }

        private string _name;
        public string Name { get { return _name; } }
        public BreadType BreadType { get; set; }
        public bool IsToasted { get; set; }
        public CheeseType CheeseType { get; set; }
        public MeatType MeatType { get; set; }
        public bool HasMustard { get; set; }
        public bool HasMayo { get; set; }
        public List<string> Vegetables { get; set; }

        public void Display()
        {
            Console.WriteLine("**** {0} ****", Name);
            Console.WriteLine("Sandwich on {0} bread", BreadType);
            if (IsToasted)
                Console.WriteLine("Toasted");
            if (HasMayo)
                Console.WriteLine("With Mayo");
            if (HasMustard)
                Console.WriteLine("With Mustard");
            Console.WriteLine("Meat: {0}", MeatType);
            Console.WriteLine("Cheese: {0}", CheeseType);
            Console.WriteLine("Veggies:");
            foreach (var vegetable in Vegetables)
                Console.WriteLine("   {0}", vegetable);
            Console.WriteLine();
        }
    }

    public enum MeatType
    {
        None,
        Turkey,
        Ham,
        Chicken,
        Salami
    }

    public enum CheeseType
    {
        American,
        Swiss,
        Cheddar,
        Provolone
    }

    public enum BreadType
    {
        White,
        Wheat
    }
}