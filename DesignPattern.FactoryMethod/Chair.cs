using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod
{
	class Chair : IProduct
	{
		public void Print()
		{
			Console.WriteLine("This is a Chair");
		}
	}
}
