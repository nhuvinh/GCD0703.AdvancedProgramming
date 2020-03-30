using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Lab
{
	public class Rectangle
	{
		Point TopLeft;
		Point BottomRight;

		public Rectangle(int topLeftX, int topLeftY, int bottomRightX, int bottomRightY)
		{
			TopLeft = new Point(topLeftX, topLeftY);
			BottomRight = new Point(bottomRightX, bottomRightY);
		}

		public bool Contains(Point point)
		{
			return point.GetX() >= TopLeft.GetX() && point.GetX() <= BottomRight.GetX()
				&& point.GetY() <= TopLeft.GetY() && point.GetY() >= BottomRight.GetY();
		}

	}
}
