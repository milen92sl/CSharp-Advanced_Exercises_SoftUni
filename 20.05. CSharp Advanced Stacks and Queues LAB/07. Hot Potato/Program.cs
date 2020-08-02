using System;
using System.Collections;
using System.Collections.Generic;

namespace _07._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int tosses = int.Parse(Console.ReadLine());

            Queue<string> childs =
                new Queue<string>
                (input.Split(' ', StringSplitOptions
                .RemoveEmptyEntries));

            while (childs.Count > 1)
            {
                for (int i = 1; i < tosses; i++)
                {
                    string kid = childs.Dequeue();
                    childs.Enqueue(kid);
                }
                Console.WriteLine($"Removed {childs.Dequeue()}");

            }
            Console.WriteLine($"Last is {childs.Dequeue()}");
        }
    }
}
