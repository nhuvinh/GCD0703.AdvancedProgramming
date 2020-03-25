using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Theory
{
	public class Animal
	{

		// Public Access Modifier
		public string Name;
		public int Age;

		// Private Access Modifier
		private string _name;
		private int _age;

		// Protected Access Modifier
		protected string Address;

		public Animal()
		{
			Name = "N/A";
			Age = 0;
			Address = "N/A";
		}

		public Animal(string name, int age)
		{
			_name = name;
			_age = age;
		}

	}
}
