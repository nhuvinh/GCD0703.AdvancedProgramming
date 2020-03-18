using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCD0703.Inheritance.Labs
{
	class StackOfStrings
	{
		private List<string> data;

		public StackOfStrings()
		{
			data = new List<string>();
		}
		public void Push(string item)
		{
			data.Add(item);
		}

		public string Pop()
		{
			if (IsEmpty()) return null;
			else
			{
				string result = data.ElementAt(data.Count - 1);
				data.RemoveAt(data.Count - 1);
				return result;
			}
		}

		public string Peek()
		{
			if (IsEmpty()) return null;
			else return data.ElementAt(data.Count - 1);
		}

		public bool IsEmpty()
		{
			return !data.Any();
		}

		public void Print()
		{
			foreach (var item in data)
			{
				Console.WriteLine(item);
			}
		}
	}
}
