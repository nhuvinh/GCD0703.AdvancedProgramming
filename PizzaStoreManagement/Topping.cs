using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreManagement
{
	abstract class Topping
	{
		protected double Price;
		protected int Calories;
		public Topping(double price, int calories)
		{
			Price = price;
			Calories = calories;
		}
	}
}
