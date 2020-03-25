using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagrams.Theory
{
	abstract class RectangularShape : IShape
	{
		private int width;
		private int height;
		double area;

		public bool contains(int x, int y)
		{
			// To be implemented
			return false;
		}

		public double getArea()
		{
			// To be implemented
			throw new NotImplementedException();
		}
	}
}
