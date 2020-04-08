using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Visitor
{
	class Speak : IAnimalOperation
	{
		public void CatVisitor(Cat cat)
		{
			Console.WriteLine("Meow...");
		}

		public void DogVisitor(Dog dog)
		{
			Console.WriteLine("Woof...");
		}

		public void LionVisitor(Lion lion)
		{
			Console.WriteLine("Roarrrrrr...");
		}
	}
}
