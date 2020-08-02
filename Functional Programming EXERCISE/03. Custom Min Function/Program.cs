using System;
using System.Linq;

namespace _03._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> myIntParse = s => int.Parse(s); //same

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse) //same 
                                   //.Select(x => int.Parse(x)) same
                                   //.Select(myIntParse)
                .ToArray();

            Func<int[], int> minFunc = nums =>
            {
                int minNum = Int32.MaxValue;

                foreach (var num in nums)
                {
                    if (num < minNum)
                    {
                        minNum = num;
                    }
                }

                return minNum;
            };
            Console.WriteLine(minFunc(numbers));
        }
    }
}

