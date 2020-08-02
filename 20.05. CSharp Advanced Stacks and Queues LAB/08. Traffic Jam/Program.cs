using System;
using System.Collections;
using System.Collections.Generic;

namespace _08._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string token = Console.ReadLine();
            int counter = 0;
            Queue<string> cars = new Queue<string>();

            while (token.ToLower() != "end")
            {
                if (token.ToLower() != "green")
                {
                    cars.Enqueue(token);
                }
                else
                {
                    for (int i = 0; i < count; i++)
                    {
                        string car;

                        if (cars.TryDequeue(out car))
                        {
                            Console.WriteLine($"{car} passed!");
                            counter++;
                        }
                    }
                }
                token = Console.ReadLine();
            }
            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
