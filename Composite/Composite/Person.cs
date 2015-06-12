using System;
using System.Security.Cryptography.X509Certificates;

namespace Composite
{
    public class Person : IParty
    {
        public Person(string name)
        {
            Name = name;
        }
        public string Name { get; private set; }

        private int _gold = 0;
        public void GiveGold(int amount)
        {
            _gold += amount;
        }

        public void PrintStats()
        {
            Console.WriteLine("{0} has {1} gold coins.", Name, _gold);
        }
    }
}