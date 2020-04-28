using Products.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;

namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> list = new List<Product>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data");
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                switch (ch)
                {
                    case 'c':
                        list.Add(new Product(name, price));

                        break;

                    case 'i':
                        Console.Write("Custom fee: ");
                        double cFee = double.Parse(Console.ReadLine());
                        list.Add(new ImportedProducts(name, price, cFee));
                        break;

                    case 'u':
                        Console.Write("Manufacture date: ");
                        DateTime manufacteDate = DateTime.Parse(Console.ReadLine());
                        list.Add(new UsedProduct(name, price, manufacteDate));
                        break;
                }
                                
            }
            
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            
            foreach (Product p in list)
            {
                Console.WriteLine(p.Name + p.PriceTag()); 
            }

        }
    }
}
