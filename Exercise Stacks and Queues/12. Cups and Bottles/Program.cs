using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _12._Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cupsArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] bottlesArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Queue<int> cups = new Queue<int>(cupsArr);
            Stack<int> bottles = new Stack<int>(bottlesArr);

            int totalWastedWater = 0;

            while (cups.Any() && bottles.Any())
            {
                int currentCup = cups.Dequeue();

                while (currentCup > 0 && bottles.Any())
                {

                    int currentBottle = bottles.Pop();
                    currentCup -= currentBottle;

                    if (currentCup < 0)
                    {
                        totalWastedWater += Math.Abs(currentCup);
                    }
                }
            }

            if (cups.Any())
            {
                Console.WriteLine($"Cups: {string.Join(" ",cups )}");
            }
            else
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }

            Console.WriteLine($"Wasted litters of water: {totalWastedWater}");
        }
    }
}
