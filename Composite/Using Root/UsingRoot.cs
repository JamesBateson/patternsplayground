using System.Collections.Generic;
using Composite;

namespace Composite.Using_Root
{
    public class UsingRoot
    {
        public void Split(int amount)
        {
            var joe = new Person("Joe");
            var john = new Person("John");
            var jack = new Person("Jack");
            var joanne = new Person("Joanne");
            var jane = new Person("Jane");
            var jimmy = new Person("Jimmy");
            var james = new Person("James");
            var jims = new Group("Jims", new List<IParty> {jimmy, james});
            var theGibbons = new Group("The girls", new List<IParty> { joanne, jane, jims });

            var parties = new Group("Rootgroup", new List<IParty>{joe, john, jack, theGibbons});

            parties.GiveGold(amount);
            parties.PrintStats();
        } 
    }
}