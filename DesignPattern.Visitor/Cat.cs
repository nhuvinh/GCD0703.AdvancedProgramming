using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Visitor
{
	class Cat : IAnimal
	{
		public void Accept(IAnimalOperation operation)
		{
			operation.CatVisitor(this);
		}
	}
}
