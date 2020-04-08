using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreManagement
{
	abstract class Product
	{
		protected double Price;
		public Product(double price)
		{
			Price = price;
		}

		public double GetPrice()
		{
			return Price;
		}
	}
}
