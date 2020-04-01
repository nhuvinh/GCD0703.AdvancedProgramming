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
			if (capacity == 1)
			{
				// Search in SingleRooms
				foreach (var room in SingleRooms)
				{
					if (!room.IsBooked(startDate, endDate) && room.Price == price)
					{
						room.AddBooking(startDate, endDate);
						return room;
					}
				}
			}
			else
			{
				// Seacrh in DoubleRooms
				foreach (var room in DoubleRooms)
				{
					if (!room.IsBooked(startDate, endDate) && room.Price == price)
					{
						room.AddBooking(startDate, endDate);
						return room;
					}
				}
			}

			return null;
		}
	}
}
