using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adapter
{
	class WildDogAdapter : ILion
	{
		private WildDog _wildDog;
		public WildDogAdapter(WildDog wildDog)
		{
			_wildDog = wildDog;
		}
	}
}
