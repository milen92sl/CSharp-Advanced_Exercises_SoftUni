using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalQuantity = int.Parse(Console.ReadLine());
            int[] ordersArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> orders = new Queue<int>(ordersArr);
            int maxOrder = 0;
            while (orders.Any())
            {
                int currentOrder = orders.Peek();

                if (currentOrder > maxOrder)
                {
                    maxOrder = currentOrder;
                }

                if (totalQuantity < currentOrder)
                {
                    break;
                }

                
                orders.Dequeue();
                totalQuantity -= currentOrder;

                
            }
            if (orders.Any())
            {
                Console.WriteLine(maxOrder);
                Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
            }
            else
            {
                Console.WriteLine(maxOrder);
                Console.WriteLine("Orders complete");
            }
        }
    }
}
