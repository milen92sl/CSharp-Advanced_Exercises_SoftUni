using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputW = Console.ReadLine();

            var inputDict = new SortedDictionary<char, int>();
            int counter = 0;
            for (int i = 0; i < inputW.Length; i++)
            {
                char currentChar = inputW[i];
                
                if (!inputDict.ContainsKey(currentChar))
                {
                    inputDict.Add(currentChar,0);
                }

                inputDict[currentChar]++;
            }

            foreach (var kvp in inputDict)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");    
            }
        }
    }
}
