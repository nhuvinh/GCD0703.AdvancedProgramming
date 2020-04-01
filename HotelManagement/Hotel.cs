using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement
{
	class Hotel
	{
		public string Name;
		public List<Room> SingleRooms;
		public List<Room> DoubleRooms;

		public Hotel(string name)
		{
			Name = name;
			SingleRooms = new List<Room>();
			DoubleRooms = new List<Room>();
		}

		public Room Search(decimal price, int capacity, DateTime startDate, DateTime endDate)
		{
			return null;
		}
	}
}
