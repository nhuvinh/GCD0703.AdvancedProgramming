using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Theory
{
	public class UsainBolt : Person
	{
		// Override the Run() method in Person class
		public override void Run()
		{
			Console.WriteLine("Usain Bolt runs very fast ...");
		}
	}
}
