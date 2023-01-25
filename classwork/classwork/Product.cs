using System;
namespace classwork
{
	internal class Product
	{
		public string Name;
		public double Price;
		public double DiscountPercent;


		public Product(string name, double price, double discountPercent)
		{
			Name = name;
			Price = price;
			DiscountPercent = discountPercent;
		}
	}
}

