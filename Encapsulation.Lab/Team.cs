using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Lab
{
	class Team
	{
		private string _name;
		private List<Person> _firstTeam;
		private List<Person> _reserveTeam;

		public List<Person> FirstTeam { get; private set; }
		public List<Person> ReserveTeam { get; private set; }

		public Team(string name)
		{
			_name = name;
			_firstTeam = new List<Person>();
			_reserveTeam = new List<Person>();

			FirstTeam = new List<Person>();
			ReserveTeam = new List<Person>();
		}

		public void AddPlayer(Person person)
		{
			if (person.GetAge() < 40)
			{
				_firstTeam.Add(person);
				FirstTeam.Add(person);
			}
			else
			{
				_reserveTeam.Add(person);
				ReserveTeam.Add(person);
			}
		}
	}
}
