using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
	class Computer
	{
		public void GetElectric()
		{
			Console.WriteLine("Ouch...ouch...");
		}
		public void MakeSound()
		{
			Console.WriteLine("Beep...beep...");
		}
		public void ShowLoadingScreen()
		{
			Console.WriteLine("Loading the screen ...");
		}

		public void CloseEverything()
		{
			Console.WriteLine("Close windows ...");
		}
		public void Sooth()
		{
			Console.WriteLine("Zzzzz...");
		}

		public void PullTheCurrent()
		{
			Console.WriteLine("Current OFF...");
		}

	}
}
