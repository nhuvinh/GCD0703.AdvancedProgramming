using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreManagement
{
	abstract class Pizza : Food
	{
		protected bool FamilySize;

		public Pizza(double price, double calories, bool familySize) : base(price, calories)
		{
			FamilySize = familySize;
			if (familySize)
			{
				Price = Price + 4.15;
				Calories = Calories * 1.95;
			}
		}

		public abstract void AddToping(Topping topping);
		public bool GetSize()
		{
			return FamilySize;
		}
	}
}
