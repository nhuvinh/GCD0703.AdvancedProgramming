using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects.Lab
{
	class Bank
	{
		public Dictionary<int, BankAccount> _accounts;

		public Bank()
		{
			_accounts = new Dictionary<int, BankAccount>();
		}

		public void Create(int id, decimal amount)
		{
			_accounts.Add(id, new BankAccount(id, amount));
		}

		public void Deposit(int id, decimal amount)
		{
			_accounts[id].Deposit(amount);
		}

		public void Withdraw(int id, decimal amount)
		{
			_accounts[id].Withdraw(amount);
		}

		public void Print(int id)
		{
			Console.WriteLine(_accounts[id]);
		}


	}
}
