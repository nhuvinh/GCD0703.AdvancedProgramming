using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Theory
{
	public class Dog : IBehave
	{
		public string Name;
		public int Age = 0;
		public string Species;
		public void Eat()
		{
			Console.WriteLine("The dog is eating ...");
		}

		public void Run()
		{
			Console.WriteLine("The dog is running ...");

		}

		public void Sleep()
		{
			Console.WriteLine("The dog is sleeping ...");

		}

		public void Stop()
		{
			Console.WriteLine("Stops the dog ...");
		}

		public void HappyBirthday()
		{
			Console.WriteLine("Happy birthday the dog");
			Age += 7;
		}
	}
}
