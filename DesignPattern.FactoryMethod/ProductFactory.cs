using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod
{
	class ProductFactory
	{
		public IProduct CreateTable()
		{
			return new Table();
		}

		public IProduct CreateChair()
		{
			return new Chair();
		}

		public IProduct CreateCar()
		{
			return new Car();
		}
	}
}
