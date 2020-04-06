using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Facade
{
	class Program
	{
		static void Main(string[] args)
		{
			Computer computer = new Computer();

			ComputerFacade facade = new ComputerFacade(computer);
			facade.TurnOn();
			facade.TurnOff();
			Console.ReadLine();
		}
	}
}
