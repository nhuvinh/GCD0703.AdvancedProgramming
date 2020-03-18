using GCD0703.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Theory
{
	class Program
	{
		static void Main(string[] args)
		{
			Vehicle myVehicule = new Vehicle();
			myVehicule.Print();
			myVehicule.Run();
			Console.WriteLine("==========");
			Bus myBus = new Bus();
			myBus.Print();
			Console.WriteLine("Company of myBus: " + myBus.Company);
			Console.WriteLine("Seats of myBus: " + myBus.Seats);
			myBus.Run();
			Console.WriteLine("==========");
			Bus thacoBus = new Bus("Thaco", "version 1", 1000000, 1000, "ABCStar", 100);
			thacoBus.Print();

			Console.WriteLine("==========");
			Car myCar = new Car("Tesla", "T-model", 1000000, 500, 4, 4);
			myCar.Print();
			myCar.Run();
			Console.WriteLine("==========");
			myCar.Print();
		}
	}
}
