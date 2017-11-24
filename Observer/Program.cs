using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
	class Program
	{
		static void Main(string[] args)
		{
		    BaggageHandler provider = new BaggageHandler();
		    ArrivalsMonitor observer1 = new ArrivalsMonitor("BaggageClaimMonitor1");
		    ArrivalsMonitor observer2 = new ArrivalsMonitor("SecurityExit");

		    provider.BaggageStatus(712, "Detroit", 3);
		    observer1.SubscribeTo(provider);
		    provider.BaggageStatus(712, "Kalamazoo", 3);
		    provider.BaggageStatus(400, "New York-Kennedy", 1);
		    provider.BaggageStatus(712, "Detroit", 3);
		    observer2.SubscribeTo(provider);
		    provider.BaggageStatus(511, "San Francisco", 2);
		    provider.BaggageStatus(712);
		    observer2.Unsubscribe();
		    provider.BaggageStatus(400);
		    provider.LastBaggageClaimed();

		    Console.ReadKey();
		}
	}
}
