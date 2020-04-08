using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Visitor
{
	class Program
	{
		static void Main(string[] args)
		{
			Dog dog = new Dog();
			Cat cat = new Cat();
			Lion lion = new Lion();

			Speak speak = new Speak();
			dog.Accept(speak);
			cat.Accept(speak);
			lion.Accept(speak);

			Eat eat = new Eat();
			dog.Accept(eat);
			cat.Accept(eat);
			lion.Accept(eat);

			Console.ReadLine();
		}
	}
}
