using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Bombs
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = Console.ReadLine().Split(", ")
                .Select(int.Parse).ToArray();
            int[] input2 = Console.ReadLine().Split(", ")
                .Select(int.Parse).ToArray();

            Queue<int> bombsEfects = new Queue<int>(input1);
            Stack<int> bombsCasing = new Stack<int>(input2);

            Dictionary<int, string> bombsTypes = new Dictionary<int, string>
            {
                {40,"Datura Bombs"},
                {60, "Cherry Bombs"},
                {120, "Smoke Decoy Bombs"}
            };

            Dictionary<string, int> bombsMade = new Dictionary<string, int>();

            while (bombsEfects.Count > 0 && bombsCasing.Count > 0)
            {
                int sumForBomb = bombsEfects.Peek() + bombsCasing.Peek();

                if (bombsTypes.ContainsKey(sumForBomb))
                {
                    if (!bombsMade.ContainsKey(bombsTypes[sumForBomb]))
                    {
                        bombsMade.Add(bombsTypes[sumForBomb], 0);
                    }

                    bombsMade[bombsTypes[sumForBomb]]++;

                    bombsEfects.Dequeue();
                    bombsCasing.Pop();
                }
                else
                {
                    int bombCasingToDecrease = bombsCasing.Peek() - 5;
                    bombsCasing.Pop();
                    bombsCasing.Push(bombCasingToDecrease);
                }
            }


            if (bombsMade["Datura Bombs"] == 3
                && bombsMade["Cherry Bombs"] == 3
                && bombsMade["Smoke Decoy Bombs"] == 3)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (bombsEfects.Count > 0)
            {
                Console.WriteLine("Bomb Effects: " + string.Join(", ", bombsEfects));
            }
            else
            {
                Console.WriteLine("Bomb Effects: empty");
            }

            if (bombsCasing.Count > 0)
            {
                Console.WriteLine("Bomb Casings: " + string.Join(", ", bombsCasing));
            }
            else
            {
                Console.WriteLine("Bomb Casings: empty");
            }

            foreach (var bombs in bombsMade.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{bombs.Key}: {bombs.Value}");
            }
        }
    }
}