using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Visitor
{
	class Eat : IAnimalOperation
	{
		public void CatVisitor(Cat cat)
		{
			Console.WriteLine("The cat is eating ...");
		}

		public void DogVisitor(Dog dog)
		{
			Console.WriteLine("The dog is eating...");
		}

		public void LionVisitor(Lion lion)
		{
			Console.WriteLine("The lion is eating...");
		}
	}
}
