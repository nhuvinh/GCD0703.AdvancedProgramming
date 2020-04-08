using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Visitor
{
	interface IAnimalOperation
	{
		void LionVisitor(Lion lion);
		void DogVisitor(Dog dog);
		void CatVisitor(Cat cat);
	}
}
