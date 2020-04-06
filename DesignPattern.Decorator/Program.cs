using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
	class Program
	{
		static void Main(string[] args)
		{
			BlackCoffee blackCoffee = new BlackCoffee();
			Console.WriteLine(blackCoffee.GetDescription());

			MilkCoffee milkCoffee = new MilkCoffee(blackCoffee);
			Console.WriteLine(milkCoffee.GetDescription());

			MilkShake milkShake = new MilkShake(milkCoffee);
			Console.WriteLine(milkShake.GetDescription());

			Console.ReadLine();
		}
	}
}
