using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Theory
{
	class Human : Animal
	{
		public string Address;
		public string Job;
		public string EmailAddress;

		public Human(string name, int age, string species,
			string address, string job, string EmailAddress)
			: base(name, age, species)
		{
			Address = address;
			Job = job;
			Species = species;
		}

		public override void Run()
		{
			Console.WriteLine("The human is running with 2 legs");
		}

		public override string Print()
		{
			return base.Print() + ", " + Address + ", " + Job + ", " + EmailAddress;
		}
	}
}
