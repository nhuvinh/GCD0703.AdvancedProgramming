using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCD0703.Inheritance
{
	public class Bus : Vehicle
	{
		public string Company;
		public int Seats;

		public Bus() : base()
		{
			Company = "N/A";
			Seats = 0;
		}

		public Bus(string brandName, string model, decimal price, int fuelAmount, string company, int seats)
			: base(brandName, model, price, fuelAmount)
		{
			Company = company;
			Seats = seats;
		}

		public override void Print()
		{
			base.Print();
			Console.WriteLine("This bus belongs to company: " + Company);
			Console.WriteLine("This bus has: " + Seats + " seats");
		}
	}
}
