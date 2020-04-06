using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{

	class Program
	{
		static void Main(string[] args)
		{
			President president_1 = President.GetInstance();

			President president_2 = President.GetInstance();

			President president_3 = President.GetInstance();

			Console.WriteLine(president_1.ToString());
			Console.WriteLine(president_2.ToString());

			Console.WriteLine(president_2.Equals(president_1));

			// President president_3 = new President();

			Console.ReadLine();
		}
	}
}
