using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement
{
	public class Room
	{
		public int Id;
		public decimal Price;
		public string RoomType;
		public List<Booking> Bookings;

		public Room(int id, decimal price, string roomType)
		{
			Id = id;
			Price = price;
			RoomType = roomType;
			Bookings = new List<Booking>();
		}

		public bool IsBooked(DateTime startDate, DateTime endDate)
		{
			bool result = false;
			bool tempResult;
			foreach (var booking in Bookings)
			{
				tempResult = startDate > booking.EndDate || endDate < booking.StartDate;
				result = !tempResult || result;
			}
			return result;
		}

		public void AddBooking(DateTime startDate, DateTime endDate)
		{
			Bookings.Add(new Booking(startDate, endDate));
		}

		public void Print()
		{
			Console.WriteLine("Room Status");
			Console.WriteLine("Id: " + Id + " Price: " + Price + "RoomType" + RoomType);
			foreach (var booking in Bookings)
			{
				booking.Print();
			}
		}
	}
}
