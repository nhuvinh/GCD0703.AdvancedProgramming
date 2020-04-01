using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using HotelManagement;

namespace HotelManagement.Test
{
	[TestFixture]
	class Room_Test
	{
		private Room room;
		[SetUp]
		public void Setup()
		{
			room = new Room(10, "SingleRoom")
			{

			};

			room.AddBooking(new DateTime(2020, 04, 01), new DateTime(2020, 04, 05));
			room.AddBooking(new DateTime(2020, 04, 07), new DateTime(2020, 04, 10));
		}

		[Test]
		public void IsBooked_Input1_ReturnFalse()
		{
			var result = room.IsBooked(new DateTime(2020, 04, 04), new DateTime(2020, 04, 06));

			Assert.IsFalse(result);
		}
	}
}
