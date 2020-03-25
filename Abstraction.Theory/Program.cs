using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Theory
{
	class Program
	{
		static void Main(string[] args)
		{
			// Can't create an Object from an Abstract class
			//Animal myAnimal = new Animal("ABC", 123, "ABCtest");

			Dog myDog = new Dog("Milou", 3, "Husky", 4);
			Console.WriteLine(myDog.Print());

			Console.ReadLine();

			myDog.Run();

			Console.ReadLine();

			Human myHuman = new Human("Vinh Hoang", 30, "Homo sapiens", "1 Ly Dinh Ly",
				"Lecturer", "Vinh.Hoang@fe.edu.vn");
			Console.WriteLine(myHuman.Print());

			Console.ReadLine();

			myHuman.Run();

			Console.ReadLine();

		}
	}
}
