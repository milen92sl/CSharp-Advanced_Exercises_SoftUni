using System;
using System.Collections.Generic;

namespace _03._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {

            SortedDictionary<string, Dictionary<string, decimal>> shops = new SortedDictionary<string, Dictionary<string, decimal>>();
            string input = Console.ReadLine();

            while (input != "Revision")
            {
                string[] tokens = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                if (!shops.ContainsKey(tokens[0]))
                {
                    shops[tokens[0]] = new Dictionary<string, decimal>();
                }
                shops[tokens[0]].Add(tokens[1], decimal.Parse(tokens[2]));


                input = Console.ReadLine();
            }

            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {(double)product.Value}"); 
                }
            }
        }
    }
}
