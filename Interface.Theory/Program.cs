using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Theory
{
	class Program
	{
		static void Main(string[] args)
		{
			Dog myDog = new Dog();
			myDog.Run();

			Person myPerson = new Person();
			myPerson.Run();

			Console.ReadLine();

			myDog.HappyBirthday();
			Console.WriteLine("My Dog Age: " + myDog.Age);

			myPerson.HappyBirthday();
			Console.WriteLine("myPerson Age: " + myPerson.Age);

			Console.ReadLine();

		}
	}
}
