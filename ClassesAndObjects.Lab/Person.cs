using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects.Lab
{
	class Person
	{
		private string _name;
		private int _age;
		private List<BankAccount> _accounts;

		public Person(string name, int age)
		{
			_name = name;
			_age = age;
			_accounts = new List<BankAccount>();
		}

		public Person(string name, int age, List<BankAccount> accounts)
		{
			_name = name;
			_age = age;
			_accounts = accounts;
		}

		public decimal GetBalance()
		{
			if (!_accounts.Any()) return 0;
			else
			{
				return _accounts.Sum(item => item.Balance);
			}
		}
	}
}
