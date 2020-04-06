using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Facade
{
	class ComputerFacade
	{
		private Computer _computer;
		public ComputerFacade(Computer computer)
		{
			_computer = computer;
		}

		public void TurnOn()
		{
			_computer.GetElectric();
			_computer.MakeSound();
			_computer.ShowLoadingScreen();
		}

		public void TurnOff()
		{
			_computer.CloseEverything();
			_computer.Sooth();
			_computer.PullTheCurrent();
		}
	}
}
