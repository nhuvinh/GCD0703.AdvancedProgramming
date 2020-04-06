using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.TemplateMethod
{
	class IOSBuilder : Builder
	{
		public override void Deploy()
		{
			Console.WriteLine("Deploy in the App Store...");
		}

		public override void Implement()
		{
			Console.WriteLine("Implement with XCode...");
		}

		public override void Plan()
		{
			Console.WriteLine("Plan with IOS Team...");
		}

		public override void SetUp()
		{
			Console.WriteLine("SetUp XCode...");
		}

		public override void Test()
		{
			Console.WriteLine("Test the iOS App...");
		}
	}
}
