using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod
{
	class Program
	{
		static void Main(string[] args)
		{
			ProductFactory factory = new ProductFactory();

			IProduct car = factory.CreateCar();
			car.Print();

			IProduct table = factory.CreateTable();
			table.Print();

			Console.ReadLine();
		}
	}
}
