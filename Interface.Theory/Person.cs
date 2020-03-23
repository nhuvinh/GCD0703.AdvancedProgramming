using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Theory
{
	// Class Person Inherits / Implement Interface IBehave
	class Person : IBehave
	{
		public string FirstName;
		public string LastName;
		public int Age = 0;
		public string Address;
		public void Eat()
		{
			Console.WriteLine("The person is eating ...");
		}
		public void Run()
		{
			Console.WriteLine("The person is running ...");
		}

		public void Sleep()
		{
			Console.WriteLine("The person is sleeping ...");
		}

		public void Stop()
		{
			Console.WriteLine("Stops the person ...");
		}

		public void HappyBirthday()
		{
			Console.WriteLine("Happy brithday the Person");
			Age += 1;
		}

		//public void Drive(Car car)
		//{
		//	Console.WriteLine("The person is driving ...");
		//	car.Run();
		//}

		//public void Drive(Bus bus)
		//{
		//	Console.WriteLine("The person is driving ...");
		//	bus.Run();
		//}

		//public void Drive(Bicycle bicycle)
		//{
		//	Console.WriteLine("The person is driving ...");
		//	bicycle.Run();
		//}

		public void Drive(IVehicle vehicle)
		{
			Console.WriteLine("The person is driving ...");
			vehicle.Run();
		}
	}
}
