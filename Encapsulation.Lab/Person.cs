using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Lab
{
	class Person
	{
		private string FirstName;
		private string LastName;
		private int Age;

		public Person(string firstName, string lastName, int age)
		{
			FirstName = firstName;
			LastName = lastName;
			Age = age;
		}

		public override string ToString()
		{
			return FirstName + " " + LastName + " is " + Age + " years old.";
		}

		public string GetFirstName()
		{
			return FirstName;
		}

		public int GetAge()
		{
			return Age;
		}
	}
}
