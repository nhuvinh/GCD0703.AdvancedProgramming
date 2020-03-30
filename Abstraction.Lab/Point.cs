using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Lab
{
	public class Point
	{
		int X;
		int Y;

		public Point(int x, int y)
		{
			X = x;
			Y = y;
		}

		public int GetX()
		{
			return X;
		}

		public int GetY()
		{
			return Y;
		}
	}
}
