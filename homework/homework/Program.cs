using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook("Apple", "MacBook Pro 14");

            notebook.Price = 5900;

            Console.WriteLine(notebook.ShowInfo());


            Notebook[] notebooks = new Notebook[4];

            for (int i = 0; i < notebooks.Length; i++)
            {
                Console.WriteLine("Brend: ");
                string brand = Console.ReadLine();

                Console.WriteLine("Model: ");
                string model = Console.ReadLine();

                Console.WriteLine("Qiymeti: ");
                double price = Convert.ToDouble(Console.ReadLine());

                Notebook ntbk = new Notebook(brand, model);
                ntbk.Price = price;

                notebooks[i] = ntbk;
            }

            double sum = 0;
            double average;

            foreach (var item in notebooks)
            {
                sum += item.Price;
            }

            average = sum / notebooks.Length;
            Console.WriteLine("Notbuklarin qiymetlerinin ortalamasi: " + average);
            
        }
    }
}

