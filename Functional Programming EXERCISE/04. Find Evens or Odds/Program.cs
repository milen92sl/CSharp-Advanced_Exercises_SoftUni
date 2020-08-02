using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] ranges = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int start = ranges[0];
            int end = ranges[1];
            string criteria = Console.ReadLine();

            Func<int, int, List<int>> generateList = (start, end) =>
            {
                List<int> nums = new List<int>();

                for (int i = start; i <= end; i++)
                {
                    nums.Add(i);
                }

                return nums;
            };
            List<int> numbers = generateList(start, end);
            if (criteria == "even")
            {
                Func<int, bool> evenPredicate = n => n % 2 == 0;
                numbers = numbers.Where(evenPredicate).ToList();
                Console.WriteLine(string.Join(" ", numbers));
            }
            else
            {
                Func<int, bool> oddPredicate = n => n % 2 != 0;
                numbers = numbers.Where(oddPredicate).ToList();
                Console.WriteLine(string.Join(" ", numbers));
            }
            
        }

    }
}

