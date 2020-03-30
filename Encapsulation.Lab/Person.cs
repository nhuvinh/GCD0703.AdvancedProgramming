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
		private decimal Salary;

		public Person(string firstName, string lastName, int age, decimal salary)
		{
			FirstName = firstName;
			LastName = lastName;
			Age = age;
			Salary = salary;
		}

		public override string ToString()
		{
			return FirstName + " " + LastName + " is " + Age + " years old, receives " + Salary;
		}

		public string GetFirstName()
		{
			return FirstName;
		}

		public int GetAge()
		{
			return Age;
		}

		public void IncreaseSalary(decimal percentage)
		{
			if (Age < 30)
			{
				Salary += Salary * percentage / 2 / 100;
			}
			else
				Salary += Salary * percentage / 100;
		}
	}
}
