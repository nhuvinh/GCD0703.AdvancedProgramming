using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Theory
{
	public class Dog : Animal
	{
		public int Legs;

		public Dog(string name, int age, string species, int legs)
			: base(name, age, species)
		{
			Legs = legs;
		}

		public override void Run()
		{
			Console.WriteLine("The dog is running with " + Legs + " legs");
		}

		public override string Print()
		{
			return base.Print() + ", " + Legs;
		}
	}
}
