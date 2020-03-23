using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Theory
{
	public class Car : IVehicle
	{
		public void Run()
		{
			Console.WriteLine("The Car is running ...");
		}
	}
}
