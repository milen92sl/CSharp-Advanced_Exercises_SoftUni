﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;

namespace DatingApp
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] malesInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            int[] femalesInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> males = new Stack<int>(malesInput);
            Queue<int> females = new Queue<int>(femalesInput);
            int matchesCount = 0;

            while (males.Count > 0 && females.Count > 0)
            {
                int currentMale = males.Peek();
                int currentFemale = females.Peek();
                
                if (currentMale <= 0)
                {
                    males.Pop();
                    continue;
                }
                if (currentFemale <= 0)
                {
                    females.Dequeue();
                    continue;
                }

                if (currentMale % 25 == 0)
                {
                    males.Pop();
                    if (males.Count > 0)
                    {
                        males.Pop();
                    }
                    continue;
                }

                if (currentFemale% 25 == 0)
                {
                    females.Dequeue();
                    if (females.Count > 0)
                    {
                        females.Dequeue();
                    }
                    continue;
                }

                if (currentMale == currentFemale)
                {
                    matchesCount++;
                    males.Pop();
                    females.Dequeue();
                }
                else
                {
                    females.Dequeue();
                    males.Pop();
                    males.Push(currentMale - 2);
                }
            }

            Console.WriteLine($"Matches: {matchesCount}");
            string malesString = males.Count > 0 ? String.Join(", ", males) : "none";
            Console.WriteLine($"Males left: {malesString}");

            string femalesString = females.Count > 0 ? String.Join(", ", females) : "none";
            Console.WriteLine($"Females left: {femalesString}");
        }
    }
}
