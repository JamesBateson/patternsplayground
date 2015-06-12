using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composite.Composite;
using Composite.Using_Root;

/*Definition: Compose objects into tree structures to represent part-whole hierarchies.
 * Compsosite lets clients treat individual objects and compositions of objects uniformly
 * 
 * 
 *
 * 
*/

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            const int amount = 1003;

            Console.WriteLine("OUTPUT OF NAIVE APPROACH");
            var naive = new NaiveSplitGold();
            naive.Split(amount);

            Console.WriteLine("\nOUTPUT OF COMPOSITE PATTERN");
            var composite = new CompositeSplitGold();
            composite.Split(amount);

            Console.WriteLine("\nOUTPUT OF COMPOSITE PATTERN WITH ROOT");
            var compositeUsingRoot = new UsingRoot();
            compositeUsingRoot.Split(amount);

            Console.ReadKey();

        }
    }
}
