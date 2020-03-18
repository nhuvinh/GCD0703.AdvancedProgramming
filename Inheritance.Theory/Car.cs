using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCD0703.Inheritance
{
	class Car : Vehicle
	{
		public int Wheels;
		public int Seats;

		public Car() : base()
		{
			Wheels = 0;
			Seats = 0;
		}

		public Car(string brandName, string model, decimal price, int fuelAmount, int wheels, int seats)
			: base(brandName, model, price, fuelAmount)
		{
			Wheels = wheels;
			Seats = seats;
		}

		public override void Print()
		{
			base.Print();
			Console.WriteLine("This car has " + Seats + " seats");
			Console.WriteLine("This car has " + Wheels + " wheels");
		}

		public void IncreaseFuel(int fuel)
		{
			FuelAmount += fuel;
		}

		public void DecreaseFuel(int fuel)
		{
			FuelAmount -= fuel;
		}

		public override void Run()
		{
			Console.WriteLine("This car is running ...");
			this.DecreaseFuel(10);
		}
	}
}
