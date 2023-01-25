using System;

namespace classwork
{
	class Program
	{
		static void Main(string[] args)
		{

			// Task 1.

			Human human1 = new Human();

			human1.Name = "Namiq";
			human1.Surname = "Mammadov";
			human1.Age = 45;
			
			Console.WriteLine(human1.GetFullName());


			// Task 2.

			Student student1 = new Student();

			student1.FullName = "Namiq Aliyev";
			student1.GroupNo = "P200";
			student1.Point = 90;

			Console.WriteLine(student1.IsGraduated());

			Console.WriteLine(student1.GetInfo());


			// Task 3.

			Product[] products = new Product[3];

			for (int i = 0; i < products.Length; i++)
			{
				Console.WriteLine("Mehsul adi: ");
				string name = Console.ReadLine();

				double price;
				do
				{
					Console.WriteLine("Qiymeti: ");
					price = Convert.ToDouble(Console.ReadLine());
				} while (price<0);

				double discountPercent;
				do
				{
					Console.WriteLine("Endirim faizi: ");
					discountPercent = Convert.ToDouble(Console.ReadLine());
				} while (discountPercent<0 || discountPercent>100 );

				Product pr1 = new Product(name, price, discountPercent);

				products[i] = pr1;
			}

			foreach (var item in products)
			{
				Console.WriteLine(item.Name+ "-" +item.Price + "-" +item.DiscountPercent);
			}
		}
	}
}

