using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
                Queue<string> pumps = new Queue<string>();

            for (int i = 0; i < n; i++)
            {
                pumps.Enqueue(Console.ReadLine());
            }

            int totalAmount = 0;
            int index = 0;
            int lenght = pumps.Count;
            
            for (int i = 0; i < lenght; i++)
            {
                totalAmount = 0;
                bool isCompleted = true;
                for (int j = 0; j < lenght; j++)
                {
                    string currentPump = pumps.Dequeue();
                    int[] currentPumpValues = currentPump.Split().Select(int.Parse).ToArray();
                    int currentAmount = currentPumpValues[0];
                    int distance = currentPumpValues[1];

                    totalAmount += currentAmount;

                    if (totalAmount >= distance)
                    {
                        totalAmount -= distance;
                        //counter++;
                    }
                    else
                    {
                        isCompleted = false;
                    }

                    pumps.Enqueue(currentPump);
                    
                }

                if (isCompleted)
                {
                    index = i;
                    break;
                }

                pumps.Enqueue(pumps.Dequeue());
            }

            Console.WriteLine(index);
        }
    }
}
