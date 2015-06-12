using System.Collections.Generic;

namespace Composite.Composite
{
    public class CompositeSplitGold
    {
        public void Split(int amountToSplit)
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

            var parties = new List<IParty> {joe, john, jack, theGibbons};

            var totalToSplitBy = parties.Count;

            var amountForEach = amountToSplit / totalToSplitBy;
            var leftOver = amountToSplit % totalToSplitBy;

            foreach (var partyMember in parties)
            {
                partyMember.GiveGold(amountForEach + leftOver);
                leftOver = 0;
                partyMember.PrintStats();
            }
        }
        
        

    }
}