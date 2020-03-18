using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects.Theory
{
	class Program
	{
		public class Car // Define class name
		{
			public string BrandName; // Properties of class Car
			public string ModelName;
			public decimal Price;
			public int Speed = 0;

			// Constructor to create an Car object
			public Car() // Constructor without Parameters
			{
				BrandName = "N/A";
				ModelName = "N/A";
				Price = 0;
			}

			// Constructor with Parameters
			public Car(string brandName, string modelName, decimal price)
			{
				BrandName = brandName;
				ModelName = modelName;
				Price = price;
			}

			// Function
			public void Run()
			{
				Console.WriteLine("The car is running ...");
			}

			public void Stop()
			{
				Console.WriteLine("The car is stopped ...");
			}

			public void IncreaseSpeed(int speed)
			{
				Speed = Speed + speed;
			}

			public void DecreaseSpeed(int speed)
			{
				Speed = Speed - speed; // -20
				if (!IsSpeedGreaterThanZero())
				{
					Speed = 0;
				}
			}

			public bool IsSpeedGreaterThanZero()
			{
				return Speed >= 0;
			}
		}
		static void Main(string[] args)
		{
			// Use constructor to initiate a Car object
			Car myCar = new Car();
			Console.WriteLine("BrandName:" + myCar.BrandName);
			Console.WriteLine("ModelName:" + myCar.ModelName);
			Console.WriteLine("Price:" + myCar.Price);
			Console.WriteLine("=============================");

			// Set value to properties of an Object
			myCar.BrandName = "Tesla";
			myCar.ModelName = "Tesla T-Model";
			myCar.Price = 1000000;
			Console.WriteLine("BrandName:" + myCar.BrandName);
			Console.WriteLine("ModelName:" + myCar.ModelName);
			Console.WriteLine("Price:" + myCar.Price);
			Console.WriteLine("=============================");

			// Use Constructor with Parameters to create an Object
			Car yourCar = new Car("VinFast", "VinFast S Model", 500000);
			Console.WriteLine("BrandName of yourCar:" + yourCar.BrandName);
			Console.WriteLine("ModelName of yourCar:" + yourCar.ModelName);
			Console.WriteLine("Price of yourCar:" + yourCar.Price);
			Console.WriteLine("Speed of yourCar:" + yourCar.Speed);

			// Increase Speed
			Console.WriteLine("==== Increase speed ====");
			yourCar.IncreaseSpeed(20);
			Console.WriteLine("Speed of yourCar:" + yourCar.Speed);

			// Decrase Speed
			Console.WriteLine("==== Decrease speed ====");
			yourCar.DecreaseSpeed(40);
			Console.WriteLine("Speed of yourCar:" + yourCar.Speed);

			// Make your Car Run and Stop
			Console.WriteLine("==== Run and Stop Car ====");
			yourCar.Run();
			yourCar.Stop();
			Console.ReadLine();

		}
	}
}
