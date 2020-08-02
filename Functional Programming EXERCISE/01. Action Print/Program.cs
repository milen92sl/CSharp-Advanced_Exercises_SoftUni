using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Action<string[]> printWords = a => Console.WriteLine(string.Join(Environment.NewLine, a));
            printWords(input);
        }

    }
}
