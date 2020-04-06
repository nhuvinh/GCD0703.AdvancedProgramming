using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
	class MilkCoffee : ICoffee
	{
		private ICoffee _coffee;

		public MilkCoffee(ICoffee coffee)
		{
			_coffee = coffee;
		}
		public double GetCost()
		{
			return _coffee.GetCost() + 1.0;
		}

		public string GetDescription()
		{
			return _coffee.GetDescription() + ", Milk";
		}
	}
}
