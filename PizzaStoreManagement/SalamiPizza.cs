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
		public SalamiPizza(MargheritaPizza basePizza, bool familySize) : base(5.99, 1160, familySize)
		{
			_basePizza = basePizza;
		}
	}
}
