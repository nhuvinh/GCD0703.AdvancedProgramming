using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCD0703.Inheritance
{
	public class Vehicle
	{
		public string BrandName;
		public string Model;
		public decimal Price;
		public int FuelAmount;

		public Vehicle()
		{
			BrandName = "N/A";
			Model = "N/A";
			Price = 0;
			FuelAmount = 0;
		}

		public Vehicle(string brandName, string model, decimal price, int fuelAmount)
		{
			BrandName = brandName;
			Model = model;
			Price = price;
			FuelAmount = fuelAmount;
		}

		public virtual void Print()
		{
			Console.WriteLine("BrandName: " + BrandName);
			Console.WriteLine("Model: " + Model);
			Console.WriteLine("Price: " + Price);
			Console.WriteLine("FuelAmount: " + FuelAmount);
		}

		public virtual void Run()
		{
			Console.WriteLine("The vehicule is running ...");
		}
	}
}
