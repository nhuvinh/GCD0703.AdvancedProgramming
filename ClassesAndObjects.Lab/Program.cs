using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects.Lab
{
	class Program
	{
		static void Main(string[] args)
		{
			BankAccount acc = new BankAccount();
			acc.Id = 1;
			acc.Balance = 15;
			Console.WriteLine(acc.ToString());

			acc.Deposit(15);
			Console.WriteLine(acc.ToString());

			acc.Withdraw(10);
			Console.WriteLine(acc.ToString());

			Console.ReadLine();

			List<BankAccount> accounts = new List<BankAccount>()
			{
				new BankAccount(1, 15),
				new BankAccount(2, 20),
				new BankAccount(3, 30)
			};

			Person person = new Person("Vinh Hoang", 30, accounts);
			Console.WriteLine("Get all balances: " + person.GetBalance());

			Console.ReadLine();

			Bank bank = new Bank();
			bank.Create(1, 20);
			bank.Create(2, 40);
			bank.Create(3, 60);
			bank.Create(6, 100);

			Console.ReadLine();

			foreach (var item in bank._accounts)
			{
				Console.WriteLine(item);
			}

			Console.ReadLine();



		}
	}
}
