using System;
namespace classwork
{
	internal class Human
	{
		public string Name;
		public string Surname;
		public int Age;

		public string GetFullName()
		{
			return Name +" "+ Surname;
		}
	}
}

