using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _08._Custom_Comparator_
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Array.Sort(numbers, (x, y) =>
            {
                int sorter = 0;
                if (x % 2 == 0 && y % 2 != 0)
                {
                    sorter = -1;
                }
                else if (x % 2 != 0 && y % 2 == 0)
                {
                    sorter = 1;
                }
                else
                {
                    sorter = x.CompareTo(y); // sorted = x - y;
                }
                return sorter;
            });

            Console.WriteLine(string.Join(" ", numbers));
        }


    }
}
