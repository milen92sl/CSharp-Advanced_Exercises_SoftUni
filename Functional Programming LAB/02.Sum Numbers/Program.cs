using System;
using System.Linq;

namespace _02.Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(el =>
                {
                    int result = Convert.ToInt32(el);
                    return result;
                })
                .ToArray();
            Console.WriteLine(input.Length);
            Console.WriteLine(input.Sum());

            //4, 2, 1, 3, 5, 7, 1, 4, 2, 12
        }
    }
}
