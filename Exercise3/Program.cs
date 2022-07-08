using System.Collections.Generic;
using Exercise3.Entities;
using System.Globalization;
using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++) {
                Console.WriteLine($"Product #{i} data");
                Console.Write("Common, used or importec (c/u/i)? ");
                char Type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string Name = Console.ReadLine();
                Console.Write("Price: ");
                double Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(Type == 'i')
                {
                    Console.Write("Customs fee: ");
                    double Fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(Name, Price, Fee));
                }
                if(Type == 'u')
                {
                    Console.WriteLine("Manufacture date (DD/MM/YYYY): ");
                    DateTime Manufacture = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(Name, Price, Manufacture));
                }
                if(Type == 'c')
                {
                    list.Add(new Product(Name, Price));
                }
               
            }
            foreach (Product prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }

        }
    }
}
