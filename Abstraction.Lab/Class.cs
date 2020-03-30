using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Lab
{
	public class Class
	{
		public List<Student> Students;

		public Class()
		{
			Students = new List<Student>();
		}

		public void Create(Student student)
		{
			Students.Add(student);
		}

		public void Show(string studentName)
		{
			var student = Students.Find(x => x.StudentName == studentName);

			if (student == null)
			{
				Console.WriteLine("There is no student in the class");
			}

			else
			{
				student.Print();
			}
		}
	}
}
