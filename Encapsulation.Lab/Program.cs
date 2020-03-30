using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Lab
{
	class Program
	{
		static void Main(string[] args)
		{
			//var lines = int.Parse(Console.ReadLine());
			//var persons = new List<Person>();
			//for (int i = 0; i < lines; i++)
			//{
			//	var cmdArgs = Console.ReadLine().Split();
			//	var person = new Person(cmdArgs[0],
			//													cmdArgs[1],
			//													int.Parse(cmdArgs[2]),
			//													decimal.Parse(cmdArgs[3]));

			//	persons.Add(person);
			//}
			//var bonus = decimal.Parse(Console.ReadLine());
			//persons.ForEach(p => p.IncreaseSalary(bonus));
			//persons.ForEach(p => Console.WriteLine(p.ToString()));

			List<Person> persons = new List<Person>()
			{
				new Person("Vinh", "Hoang", 20,2200 ),
				new Person("Boiko", "Borisov", 57, 3333),
				new Person("Ventsislav", "Ivanov" ,27, 600),
				new Person("Grigor", "Dimitrov", 25, 666),
				new Person("Boiko", "Angelov", 35, 555)
			};

			Team team = new Team("GCD0704");

			foreach (var p in persons)
			{
				team.AddPlayer(p);
			}

			foreach (var p in team.FirstTeam)
			{
				Console.WriteLine(p.ToString());
			}

			Console.ReadLine();

			foreach (var p in team.ReserveTeam)
			{
				Console.WriteLine(p.ToString());
			}

			Console.ReadLine();

		}
	}
}
