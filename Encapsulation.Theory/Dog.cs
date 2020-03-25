using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Theory
{
	class Dog : Animal
	{
		public Dog()
		{
			// Because Name and Age properties in Animal class are public
			// So Dog class can access to these properties
			Name = "DogName";
			Age = 1;

			// Beause _name and _age are Private in class Animal
			// So even the child class can't accessed these properties
			_name = "N/A";
			_age = 0;


			// Because Address is Protected in the class Animal
			// And class Dog inherits class Animal
			// So that Address can be accessed from the class Dog
			Address = "1 Le Dinh Ly";
		}
	}
}
