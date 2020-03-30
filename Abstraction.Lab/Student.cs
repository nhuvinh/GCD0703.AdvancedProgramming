using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Lab
{
	public class Student
	{
		public string StudentName;
		int StudentAge;
		double StudentGrade;

		public Student(string name, int age, double grade)
		{
			StudentName = name;
			StudentAge = age;
			StudentGrade = grade;
		}

		public void Print()
		{
			Console.WriteLine(StudentName + " is " + StudentAge + " years old.");
		}

		public string GetName()
		{
			return StudentName;
		}
	}
}
