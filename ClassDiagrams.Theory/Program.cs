using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagrams.Theory
{
	class Program
	{
		static void Main(string[] args)
		{
			Engine engine_1 = new Engine();
			Car myCar = new Car(engine_1);

			Engine engine_2 = new Engine();
			myCar.CarEngine = engine_2;

			Book myBook = new Book();
		}
	}
}
