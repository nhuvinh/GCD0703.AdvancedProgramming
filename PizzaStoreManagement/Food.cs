using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreManagement
{
	abstract class Food : Product
	{
		protected double Calories;
		public Food(double price, double calories) : base(price)
		{
			Calories = calories;
		}
	}
}
