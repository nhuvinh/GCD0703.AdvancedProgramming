using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects.Lab
{
	public class BankAccount
	{
		private int id;
		private decimal balance;

		public int Id;
		public decimal Balance;

		public BankAccount()
		{

		}

		public BankAccount(int id, decimal balance)
		{
			Id = id;
			Balance = balance;
		}

		public void Deposit(decimal amount)
		{
			Balance += amount;
		}

		public void Withdraw(decimal amount)
		{
			Balance -= amount;
		}

		public override string ToString()
		{
			return "Id: " + Id + ", Balance: " + Balance;
		}
	}
}
