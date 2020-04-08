using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Visitor
{
	class Dog : IAnimal
	{
		public void Accept(IAnimalOperation operation)
		{
			operation.DogVisitor(this);
		}
	}
}
