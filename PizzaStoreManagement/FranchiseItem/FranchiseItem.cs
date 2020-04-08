using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreManagement
{
	abstract class FranchiseItem : Product
	{
		public FranchiseItem(double price) : base(price)
		{

		}
	}
}
