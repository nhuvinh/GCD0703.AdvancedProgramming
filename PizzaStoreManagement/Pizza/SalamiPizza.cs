using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreManagement
{
	class SalamiPizza : Pizza
	{
		MargheritaPizza _basePizza;
		public SalamiPizza(MargheritaPizza basePizza) : base(5.99, 1160, basePizza.GetSize())
		{
			_basePizza = basePizza;
		}

		public override void AddToping(Topping topping)
		{
			_basePizza.AddToping(topping);
		}

		public override double GetPrice()
		{
			return Price + _basePizza.GetToppingPrice();
		}
	}
}
