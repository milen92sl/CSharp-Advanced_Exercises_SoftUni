using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Knights_of_Honnor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            //input = input.Select(n => $"Sir {n}").ToList();
            input = MySelect(input, n => $"Sir {n}");

            Action<string[]> printWords = a =>
                Console.WriteLine(string.Join(Environment.NewLine, a));

            printWords(input.ToArray());
        }

        static List<string> MySelect(List<string> items, Func<string, string> func)
        {
            List<string> newList = new List<string>();

            foreach (var item in items)
            {
                string newItem = func(item);
                newList.Add(newItem);
            }
            return newList;
        }

    }

}

