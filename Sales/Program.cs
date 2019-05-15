using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Sales
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesCounter sales = new SalesCounter(ReadSales("./sales.csv"));
            var amountPerStore = sales.GetPerStoreSales();

            foreach((string key, int value) in amountPerStore)
            {
                Console.WriteLine($"{key} {value}");
            }
        }

        private static IEnumerable<Sale> ReadSales(string filePath)
        {
            string[][] items = File.ReadAllLines(filePath)
                .Select(l => l.Split(','))
                .ToArray();

            //List<Sale> sales = items.Select(i => new Sale
            //{
            //    ShopName = i[0],
            //    ProductCategory = i[1],
            //    Amount = int.Parse(i[2])
            //}
            //).ToList();

            //return sales;
            foreach (var i in items)
            {
                yield return new Sale
                {
                    ShopName = i[0],
                    ProductCategory = i[1],
                    Amount = int.Parse(i[2])
                };
            }
        }
    }
}
