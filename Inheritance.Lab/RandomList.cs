using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCD0703.Inheritance.Labs
{
	public class RandomList : List<string>
	{
		public string RandomString()
		{
			if (!this.Any())
			{
				return null;
			}
			else
			{
				Random rnd = new Random();
				int random = rnd.Next(0, this.Count - 1);
				string result = this.ElementAt(random);
				this.RemoveAt(random);
				return result;

			}
		}
	}
}
