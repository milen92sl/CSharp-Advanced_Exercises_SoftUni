using System;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;

namespace _04.Froggy
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] stones = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            Lake lake = new Lake(stones);

           Console.WriteLine(string.Join(", ", lake));

        }
    }
}
