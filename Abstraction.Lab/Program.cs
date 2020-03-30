using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Lab
{
	class Program
	{
		static void Main(string[] args)
		{
			Rectangle rectangle = new Rectangle(-2, 3, 3, -1);
			Point point_1 = new Point(1, 1);
			Point point_2 = new Point(5, 3);

			Console.WriteLine(rectangle.Contains(point_1));
			Console.WriteLine(rectangle.Contains(point_2));

			Console.ReadLine();
		}
	}
}
