using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
	class BlackCoffee : ICoffee
	{
		public double GetCost()
		{
			return 8.0;
		}

		public string GetDescription()
		{
			return "This is a Black Coffee";
		}
	}
}
