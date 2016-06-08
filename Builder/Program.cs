using System;

/*
//BUILDER PATTERN
 * 
 * Definition: Separate the construction of a complex object from its representation so that the same construction 
 * process can create different representations.
 * 
 * ConcreteBuilder (MySandwichBuilder, ClubSandwichBuilder) - these classes will create the complex Product (Sandwich)
 * Builder (SandwichBuilder) - this is the interace for creating the actual products
 * Director - Specifies how the parts are put together to create the concrete product
 * Product - The object that will be created.
 * 
 * USE WHEN
 * - The logic for creating a complex object should be independent of the parts that make up the object
 * - The construction process must allow different 

*/

namespace Builder
{
    using Builder.SkeetsBuilder;

    class Program
    {
        static void Main(string[] args)
        {
            var sandwichMaker = new RegularSandwichMaker(new MySandwichBuilder());
            sandwichMaker.MakeMeASandwich();
            var sandwich1 = sandwichMaker.GetSandwich();
            sandwich1.Display();

            var sandwichMaker2 = new RegularSandwichMaker(new ClubSandwichBuilder());
            sandwichMaker2.MakeMeASandwich();
            var sandwich2 = sandwichMaker2.GetSandwich();
            sandwich2.Display();

            var veganSandwichmaker = new VeganSandwichMaker(new ClubSandwichBuilder());
            veganSandwichmaker.MakeMeASandwich();
            var veganSandwich = veganSandwichmaker.GetSandwich();
            veganSandwich.Display();

            Console.WriteLine("\nSkeet's builder:");
            //ShyClass's state is private and can only be created via it's builder
            //var shyClass = new ShyClass(); //CAN'T CONSTRUCT
            
            var shyClass = new ShyClass.Builder { Name = "Test name" }.Build();
            Console.WriteLine(shyClass);

            Console.ReadKey();
        }
    }
}
