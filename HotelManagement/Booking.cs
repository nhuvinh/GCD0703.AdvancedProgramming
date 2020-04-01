using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement
{
	class Booking
	{
		public DateTime StartDate { get; private set; }
		public DateTime EndDate { get; private set; }

		public Booking(DateTime startDate, DateTime endDate)
		{
			StartDate = startDate;
			EndDate = endDate;
		}
	}
}
