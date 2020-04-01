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

		public void AddRoom(string roomType, int id, decimal price)
		{
			if (roomType.Equals("Single"))
			{
				SingleRooms.Add(new Room(id, price, roomType));
			}
			else if (roomType.Equals("Double"))
			{
				DoubleRooms.Add(new Room(id, price, roomType));
			}
		}

		public Room Search(decimal price, int capacity, DateTime startDate, DateTime endDate)
		{
			Room roomResult;
			if (capacity == 1)
			{
				roomResult = SingleRooms.SingleOrDefault(x => x.Price == price && !x.IsBooked(startDate, endDate));
				if (roomResult != null)
				{
					roomResult.AddBooking(startDate, endDate);
				}
				else if (roomResult == null)
				{
					roomResult = SingleRooms.FirstOrDefault(x => !x.IsBooked(startDate, endDate));
				}

			}
			else
			{
				roomResult = DoubleRooms.SingleOrDefault(x => x.Price == price && !x.IsBooked(startDate, endDate));
				if (roomResult != null)
				{
					roomResult.AddBooking(startDate, endDate);
				}
				else if (roomResult == null)
				{
					roomResult = DoubleRooms.FirstOrDefault(x => !x.IsBooked(startDate, endDate));
				}
			}
			return roomResult;
		}
	}
}
