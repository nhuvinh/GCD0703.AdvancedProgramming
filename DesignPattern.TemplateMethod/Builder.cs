using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.TemplateMethod
{
	abstract class Builder
	{
		public abstract void SetUp();
		public abstract void Plan();
		public abstract void Implement();
		public abstract void Test();
		public abstract void Deploy();

		// Template Method
		public void Build()
		{
			SetUp();
			Plan();
			Implement();
			Test();
			Deploy();
		}

		public void Update()
		{
			Implement();
			Test();
			Deploy();
		}
	}
}
