using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _01SpaceshipCrafting
{
    public class StartUp
    {
        private const int GLASS_MIN_VALUE = 25;
        private const int ALUMINIUM_MIN_VALUE = 50;
        private const int LITHIUM_MIN_VALUE = 75;
        private const int CARNBON_FIBER_MIN_VALUE = 100;

        private static int glassCount;
        private static int aluminiumCount;
        private static int lithiumCount;
        private static int carbonFiberCount;

        static void Main(string[] args)
        {
            int[] liquidsInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] inputPhysicalItems = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> chemicalLiquids = new Queue<int>(liquidsInput);
            Stack<int> physicalItems = new Stack<int>(inputPhysicalItems);

            while (liquidsInput.Length > 0 && physicalItems.Count > 0)
            {
                MixChemicals(chemicalLiquids, physicalItems);
            }

            isSucceed();

            PrintOutput(chemicalLiquids, physicalItems);
        }

        private static void isSucceed()
        {
            if (glassCount > 0 && aluminiumCount > 0 && lithiumCount > 0 && carbonFiberCount > 0)
            {
                Console.WriteLine("Wohoo! You succeeded in building the spaceship!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You did't have enough materials to build the spaceship.");
            }
        }

        private static void MixChemicals(Queue<int> chemicalLiquids, Stack<int> physicalItems)
        {
            int currentLiquid = chemicalLiquids.Dequeue();
            int currentItem = physicalItems.Pop();

            int currentSum = currentLiquid + currentItem;

            if (currentSum == GLASS_MIN_VALUE)
            {
                glassCount++;
            }
            else if (currentSum == ALUMINIUM_MIN_VALUE)
            {
                aluminiumCount++;
            }
            else if (currentSum == LITHIUM_MIN_VALUE)
            {
                lithiumCount++;
            }
            else if (currentSum == CARNBON_FIBER_MIN_VALUE)
            {
                carbonFiberCount++;
            }
            else
            {
                physicalItems.Push(currentItem + 3);
            }
        }

        private static void PrintOutput(Queue<int> chemicalLiquids, Stack<int> physicalItems)
        {
            //string liquidsString = chemicalLiquids.Count > 0 ? String.Join(", ", chemicalLiquids) : "none";
            //Console.WriteLine($"Liquids left: {liquidsString}");

            if (chemicalLiquids.Count > 0)
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", chemicalLiquids)}");
            }
            else
            {
                Console.WriteLine("Liquids left: none");
            }

            string itemsString = physicalItems.Count > 0 ? String.Join(", ", physicalItems) : "none";
            Console.WriteLine($"Physical items left: {itemsString}");

            Console.WriteLine($"Aluminium: {aluminiumCount}");
            Console.WriteLine($"Carbon fiber: {carbonFiberCount}");
            Console.WriteLine($"Glass: {glassCount}");
            Console.WriteLine($"Lithium: {lithiumCount}");
        }
    }
}
