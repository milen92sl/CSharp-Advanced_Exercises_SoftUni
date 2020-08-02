using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothesArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> boxes = new Stack<int>(clothesArr);

            int rackCapacity = int.Parse(Console.ReadLine()); // 16
            int racksCount = 1;
            int currentRackCapacity = rackCapacity;
            // 5 4 8 6 3 8 7 7 9
            while (boxes.Count > 0)
            {
                int currentClothers = boxes.Peek();


                if (currentRackCapacity >= currentClothers)
                {
                    currentRackCapacity -= currentClothers;
                    boxes.Pop();
                }
                else
                {
                    racksCount++;
                    currentRackCapacity = rackCapacity;
                }
            }

            Console.WriteLine(racksCount);
        }
    }
}