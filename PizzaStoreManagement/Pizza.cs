using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreManagement
{
	class Pizza : Food
	{
		protected bool FamilySize;
		protected List<Topping> Toppings;
		public Pizza(double price, double calories, bool familySize) : base(price, calories)
		{
			FamilySize = familySize;
			Toppings = new List<Topping>();
			if (familySize)
			{
				Price = Price + 4.15;
				Calories = Calories * 1.95;
			}
		}

		public void AddToping(Topping topping)
		{
			Toppings.Add(topping);
		}
	}
}
