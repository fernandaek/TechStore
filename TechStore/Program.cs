using System;
using System.Collections.Generic;
using TechStore.Entities;

namespace TechStore
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            var n = int.Parse(Console.ReadLine());
            for (var i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Product #"+ i + " data");
                Console.Write("National, Used or Imported? ");
                var answer = Console.ReadLine();
                Console.Write("Name: ");
                var name = Console.ReadLine();
                Console.Write("Price: ");
                var price = double.Parse(Console.ReadLine());

                if(answer == "imported" || answer == "Imported")
                {
                    Console.Write("Importation fee: ");
                    var additionalFee = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, additionalFee));
                }
                else if (answer == "Used" || answer == "used")
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                    list.Add(new UsedProduct(name, price, date));
                }
                else
                {
                    list.Add(new Product(name, price));
                }
            }
            Console.WriteLine();
            Console.WriteLine("Pice tags");

            foreach (Product product in list)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
