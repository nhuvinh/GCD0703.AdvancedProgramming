using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement
{
	class Room
	{
		public decimal Price;
		public string RoomType;
		public List<Booking> Bookings;

		public Room(decimal price, string roomType)
		{
			Price = price;
			RoomType = roomType;
			Bookings = new List<Booking>();
		}

		public bool IsBooked(DateTime startDate, DateTime endDate)
		{
			return false;
		}
	}
}
