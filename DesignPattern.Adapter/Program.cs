using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adapter
{
	class Program
	{
		static void Main(string[] args)
		{
			AfricanLion africanLion = new AfricanLion();
			AsianLion asianLion = new AsianLion();

			WildDog wildDog = new WildDog();
			WildDogAdapter wildDogAdapter = new WildDogAdapter(wildDog);

			Cat cat = new Cat();
			CatAdapter catAdapter = new CatAdapter(cat);

			Hunter hunter = new Hunter();
			hunter.Hunt(asianLion);
			hunter.Hunt(africanLion);
			hunter.Hunt(wildDogAdapter);
			hunter.Hunt(catAdapter);

		}
	}
}
