using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
	class President
	{
		private static President instance;

		private President()
		{

		}

		public static President GetInstance()
		{
			if (instance != null)
			{
				return instance;
			}
			else
			{
				instance = new President();
				return instance;
			}
		}
	}
}
