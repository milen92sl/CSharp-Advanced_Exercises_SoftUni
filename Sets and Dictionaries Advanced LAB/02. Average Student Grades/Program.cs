using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numberOfRecords = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> gradesBook = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < numberOfRecords; i++)
            {

                string[] tokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (gradesBook.ContainsKey(tokens[0]))
                {
                    gradesBook[tokens[0]].Add(decimal.Parse(tokens[1]));

                }
                else
                {
                    gradesBook
                        .Add(tokens[0], new List<decimal>() { decimal.Parse(tokens[1]) });
                }
            }

            foreach (var item in gradesBook)
            {
                Console.WriteLine($"{item.Key} -> {string.Join(' ', item.Value.Select(x => x.ToString("F2")))} (avg: {item.Value.Average():f2})");
            }
        }
    }
}
