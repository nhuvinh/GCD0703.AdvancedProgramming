using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Theory
{
	// Declare an abstract class with keyword  "abstract"
	public abstract class Animal
	{
		public string Name;
		public int Age;
		public string Species;

		public Animal(string name, int age, string species)
		{
			Name = name;
			Age = age;
			Species = species;
		}

		// Child classes will override this method
		public virtual string Print()
		{
			return Name + ", " + Age + ", " + Species;
		}

		public abstract void Run();
	}
}
