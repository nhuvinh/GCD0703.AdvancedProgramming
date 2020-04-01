using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement
{
	public class Booking
	{
		public DateTime StartDate { get; private set; }
		public DateTime EndDate { get; private set; }

		public Booking(DateTime startDate, DateTime endDate)
		{
			StartDate = startDate;
			EndDate = endDate;
		}

		public void Print()
		{
			Console.WriteLine("Booking Status");
			Console.WriteLine("StarteDate: " + StartDate.Date);
			Console.WriteLine("EndDate: " + EndDate.Date);
			Console.WriteLine("=======");

		}
	}
}
