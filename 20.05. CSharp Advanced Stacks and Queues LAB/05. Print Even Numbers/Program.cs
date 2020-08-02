using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _05._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            var queueNums = new Queue<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == 0)
                {
                    queueNums.Enqueue(int.Parse(input[i]));
                }
                
            }

            Console.WriteLine($"{queueNums}");
        }
    }
}
