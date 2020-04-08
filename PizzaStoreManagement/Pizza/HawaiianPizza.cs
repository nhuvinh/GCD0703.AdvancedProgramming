using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreManagement
{
	class HawaiianPizza : Pizza
	{
		private MargheritaPizza _basePizza;
		public HawaiianPizza(MargheritaPizza basePizza) : base(6.49, 1024, basePizza.GetSize())
		{
			_basePizza = basePizza;
		}
	}
}
