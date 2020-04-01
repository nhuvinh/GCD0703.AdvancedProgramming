using NUnit.Framework;
using HotelManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Tests
{
	[TestFixture]
	public class RoomTests
	{
		private Room room;

		[SetUp]
		public void Setup()
		{
			room = new Room(1, 10, "SingleBed");
			room.AddBooking(
				new DateTime(2020, 04, 15), new DateTime(2020, 04, 20)
				);

			room.AddBooking(
				new DateTime(2020, 04, 23), new DateTime(2020, 04, 27)
				);
		}

		[Test]
		public void IsBooked_Input1_ReturnTrue()
		{
			var result = room.IsBooked(
				new DateTime(2020, 04, 17), new DateTime(2020, 04, 22)
			);

			Assert.IsTrue(result);
		}

		[Test]
		public void IsBooked_Input1_ReturnFalse()
		{
			var result = room.IsBooked(
				new DateTime(2020, 04, 21), new DateTime(2020, 04, 22)
			);

			Assert.IsFalse(result);
		}
	}
}