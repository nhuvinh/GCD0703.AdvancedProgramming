using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.TemplateMethod
{
	class Program
	{
		static void Main(string[] args)
		{
			AndroidBuilder androidBuilder = new AndroidBuilder();
			androidBuilder.Build();
			Console.ReadLine();

			androidBuilder.Update();
			Console.ReadLine();
			IOSBuilder iOSBuilder = new IOSBuilder();
			iOSBuilder.Build();
			Console.ReadLine();

			iOSBuilder.Update();

			Console.ReadLine();
		}
	}
}
