﻿using System;
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
	}
}
