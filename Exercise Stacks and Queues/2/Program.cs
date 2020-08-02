using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int n = data[0];
            int s = data[1];
            int x = data[2];

            int[] numsArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> nums = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                nums.Enqueue(numsArr[i]);
            }
            for (int i = 0; i < s; i++)
            {
                nums.Dequeue();
            }

            if (nums.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (nums.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(nums.Min());
            }

        }
    }
}
