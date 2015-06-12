using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Schema;

namespace Composite
{
    public class NaiveSplitGold
    {
        public void Split(int amountToSplit)
        {
            Console.WriteLine("\n***SPLITTING GOLD***");

            var joe = new Person("Joe");
            var john = new Person("John");
            var jack = new Person("Jack");
            var joanne = new Person("Joanne");
            var jane = new Person("Jane");

            var theGirls = new Group("The girls", new List<Person> {joanne, jane});

            var individuals = new List<Person> {joe, john, jack};
            var groups = new List<Group> {theGirls};

            var totalToSplitBy = individuals.Count + groups.Count;

            var amountForEach = amountToSplit/totalToSplitBy;
            var leftOver = amountToSplit%totalToSplitBy;

            foreach (var individual in individuals)
            {
                individual.GiveGold(amountForEach + leftOver);
                leftOver = 0;
                individual.PrintStats();
            }

            foreach (var group in groups)
            {
                var amountForEachGroupMember = amountForEach/group.Members.Count();
                var leftOverForGroup = amountForEachGroupMember%group.Members.Count();
                foreach (var member in group.Members)
                {
                    member.GiveGold(amountForEachGroupMember + leftOverForGroup);
                    leftOverForGroup = 0;
                    member.PrintStats();
                }
            }
        } 
    }
}