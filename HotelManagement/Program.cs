using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement
{
	class Program
	{
		static void Main(string[] args)
		{
			Hotel hotel = new Hotel("TestHotel");

			hotel.AddRoom("Single", 1, 100);
			hotel.AddRoom("Single", 2, 200);
			hotel.AddRoom("Single", 3, 150);
			hotel.AddRoom("Single", 4, 120);
			hotel.AddRoom("Single", 5, 250);
			hotel.AddRoom("Single", 6, 330);
			hotel.AddRoom("Single", 7, 400);

			hotel.AddRoom("Double", 1, 200);
			hotel.AddRoom("Double", 2, 250);
			hotel.AddRoom("Double", 3, 260);
			hotel.AddRoom("Double", 4, 270);
			hotel.AddRoom("Double", 5, 300);
			hotel.AddRoom("Double", 6, 400);

			Room searchRoom = hotel.Search(400, 2, new DateTime(2020, 04, 01), new DateTime(2020, 04, 05));

			searchRoom.Print();

			Console.ReadLine();

		}
	}
}
