using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            Stack<int> finalStack = new Stack<int>();

            for (int i = 0; i < N; i++)
            {
                int[] queries = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                int currQuerie = queries[0];

                

                if (currQuerie == 2)
                {
                    if (finalStack.Any())
                    {
                        finalStack.Pop();
                    }

                }
                if (currQuerie == 3)
                {
                    if (finalStack.Count > 0)
                    {
                        int maxNum = finalStack.Max();
                        Console.WriteLine(maxNum);
                    }
                }
                if (currQuerie == 4)
                {
                    if (finalStack.Count > 0)
                    {
                        int minNum = finalStack.Min();
                        Console.WriteLine(minNum);
                    }
                }
                if (currQuerie == 1)
                {
                    int x = queries[1];
                    finalStack.Push(x);
                    
                }
                
            }
            Console.WriteLine(string.Join(", ", finalStack));
        }
    }
}
