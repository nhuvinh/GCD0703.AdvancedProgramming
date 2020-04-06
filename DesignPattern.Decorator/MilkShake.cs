using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
	class MilkShake : ICoffee
	{
		private ICoffee _coffee;
		public MilkShake(ICoffee coffee)
		{
			_coffee = coffee;
		}

		public double GetCost()
		{
			return _coffee.GetCost() + 3.0;
		}

		public string GetDescription()
		{
			return _coffee.GetDescription() + " ,Milkshake";
		}
	}
}
