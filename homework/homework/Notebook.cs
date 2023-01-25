using System;
namespace homework
{
	internal class Notebook
	{
		public string Brand;
		public string Model;
		public double Price; 

		public string ShowInfo()
		{
			return Brand + "-" + Model + "-" + Price;
		}


        public Notebook(string brand, string model)
        {
            Brand = brand;
			Model = model;
        }




	}
}

