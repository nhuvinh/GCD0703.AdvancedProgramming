using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreManagement
{
	class Program
	{
		static void Main(string[] args)
		{
			Order order = new Order();

			order.AddProduct(new Mug());
			order.AddProduct(new Shirt());

			order.AddProduct(new Wine());
			order.AddProduct(new Water());

			MargheritaPizza basePizza = new MargheritaPizza(true);
			HawaiianPizza hawaiianPizza = new HawaiianPizza(basePizza);
			hawaiianPizza.AddToping(new Cheese());


			order.AddProduct(hawaiianPizza);

			Console.WriteLine("Total price of Order: " + order.GetTotalPrice());

			Console.ReadLine();

			order.ShowDescription();

			Console.ReadLine();


		}
	}
}
