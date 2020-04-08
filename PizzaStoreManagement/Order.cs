using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreManagement
{
	class Order
	{
		List<Product> Products;
		public Order()
		{
			Products = new List<Product>();
		}

		public void AddProduct(Product product)
		{
			Products.Add(product);
		}

		public double GetTotalPrice()
		{
			return Products.Sum(x => x.GetPrice());
		}

		public void ShowDescription()
		{
			foreach (var product in Products)
			{
				Console.WriteLine(product.ToString());
			}
		}
	}
}
