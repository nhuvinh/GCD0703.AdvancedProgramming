using GCD0703.Inheritance.Labs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Lab
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("====== Lab ======");
			Dog myDog = new Dog();
			myDog.Bark();
			myDog.Eat();

			Console.WriteLine("==========");

			Puppy myPuppy = new Puppy();
			myPuppy.Bark();
			myPuppy.Eat();
			myPuppy.Weep();

			Console.WriteLine("==========");
			Cat myCat = new Cat();
			myCat.Eat();
			myCat.Meow();



			// RandomList
			RandomList rndList = new RandomList();

			foreach (var item in rndList)
			{
				Console.WriteLine(item);
			}
			Console.ReadLine();

			Console.WriteLine(rndList.RandomString());

			Console.ReadLine();

			foreach (var item in rndList)
			{
				Console.WriteLine(item);
			}

			Console.ReadLine();

			// StackOfStrings 

			StackOfStrings stackOfStrings = new StackOfStrings();

			stackOfStrings.Print();

			stackOfStrings.Pop();
			Console.WriteLine("======");
			stackOfStrings.Print();
			Console.WriteLine("======");
			Console.WriteLine(stackOfStrings.Peek());


			Console.ReadLine();
		}
	}
}
