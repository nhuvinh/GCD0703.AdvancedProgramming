using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Visitor
{
	interface IAnimal
	{
		void Accept(IAnimalOperation operation);
	}
}
