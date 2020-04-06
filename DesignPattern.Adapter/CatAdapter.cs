using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adapter
{
	class CatAdapter : ILion
	{
		private Cat _cat;
		public CatAdapter(Cat cat)
		{
			_cat = cat;
		}
	}
}
