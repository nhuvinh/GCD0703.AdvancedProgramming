using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreManagement
{
	class MargheritaPizza : Pizza
	{

		public MargheritaPizza(bool familySize) : base(4.99, 1104, familySize)
		{
		}
	}
}
