using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreManagement
{
	class MargheritaPizza : Pizza
	{

		protected List<Topping> Toppings;
		public MargheritaPizza(bool familySize) : base(4.99, 1104, familySize)
		{
			Toppings = new List<Topping>();
		}

		public override void AddToping(Topping topping)
		{
			Toppings.Add(topping);
		}

		public override double GetPrice()
		{
			return base.GetPrice() + GetToppingPrice();
		}

		public double GetToppingPrice()
		{
			return Toppings.Sum(x => x.GetPrice());
		}
	}
}
