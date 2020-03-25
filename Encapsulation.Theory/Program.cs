using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Theory
{
	class Program
	{
		static void Main(string[] args)
		{
			Animal animal = new Animal();
			animal.Age = 10;
			animal.Name = "Milou";

			Animal myAnimal = new Animal("Susu", 10);

			// Because _name and _age are Private in Animal class
			// So it can't be accessed from outside the Animal class
			myAnimal._name;
			myAnimal._age;


			// Because Address is Protected in the class Animal
			// So that it can't be accessed from the outside
			animal.Address;
		}
	}
}
