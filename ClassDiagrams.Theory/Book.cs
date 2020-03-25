using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagrams.Theory
{
	public class Book
	{
		public List<Page> Pages;

		public Book()
		{
			Pages = new List<Page>();
		}
	}
}
