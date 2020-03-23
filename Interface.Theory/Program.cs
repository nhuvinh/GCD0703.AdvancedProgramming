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

			Car car = new Car();
			Bus bus = new Bus();
			Bicycle bicycle = new Bicycle();

			myPerson.Drive(car);
			myPerson.Drive(bus);
			myPerson.Drive(bicycle);

			Console.ReadLine();

			myPerson.Run(10);

			Console.ReadLine();

			myPerson.Run(10, car);

			Console.ReadLine();


		}
	}
}
