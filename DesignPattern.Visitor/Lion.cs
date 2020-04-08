using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Visitor
{
	class Lion : IAnimal
	{
		public void Accept(IAnimalOperation operation)
		{
			operation.LionVisitor(this);
		}

	}
}
