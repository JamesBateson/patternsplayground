using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Composite
{
    public class Group : IParty
    {
        public Group(string name, IEnumerable<IParty> members)
        {
            Name = name;
            Members = members;
        }

        public string Name { get; private set; }
        public IEnumerable<IParty> Members { get; private set; }
        
        public void GiveGold(int amount)
        {
            var amountForEachMember = amount/Members.Count();
            var leftOver = amount%Members.Count();
            foreach (var member in Members)
            {
                member.GiveGold(amountForEachMember + leftOver);
                leftOver = 0;
            }
        }

        public void PrintStats()
        {
            foreach (var member in Members)
            {
                member.PrintStats();
            }
        }
    }
}