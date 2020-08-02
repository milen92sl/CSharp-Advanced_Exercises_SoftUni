using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int endDigit = int.Parse(Console.ReadLine());
            var dividers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<Predicate<int>> predicates = new List<Predicate<int>>();

            dividers.ForEach(n => predicates.Add(x => x % n == 0));
            List<int> result = new List<int>();

            for (int i = 1; i <= endDigit; i++)
            {
                bool isDivisible = true;

                foreach (var predicate in predicates)
                {
                    if (!predicate(i))
                    {
                        isDivisible = false;
                        break;
                    }
                }

                if (isDivisible)
                {
                    result.Add(i);
                }
            }

            Console.WriteLine(String.Join(" ", result));
        }
    }
}

