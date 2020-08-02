using System;
using System.Linq;
using System.Collections.Generic;

namespace _6.Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(", ")
                .ToArray();
            Queue<string> songs = new Queue<string>(input);

            while (songs.Count > 0)
            {
                string sequence = Console.ReadLine();
                string[] commands = sequence.Split();
                string command = commands[0];

                if (command == "Play")
                {
                    songs.Dequeue();
                }
                else if (command == "Add")
                {
                    string song = sequence.Substring(4);
                    if (songs.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(song);
                    }
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", songs));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}