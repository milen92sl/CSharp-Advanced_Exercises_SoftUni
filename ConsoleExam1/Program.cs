using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleExam1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[] input2 = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            Stack<int> lilies = new Stack<int>(input1);
            Queue<int> roses = new Queue<int>(input2);
            int wreathsCount = 0;
            int sumForStore = 0;

            while (lilies.Count > 0 && roses.Count > 0)
            {
                int currentLilie = lilies.Peek();
                int currentRose = roses.Peek();
                int sum = currentLilie + currentRose;
                
                if (sum == 15)
                {
                    wreathsCount++;
                    if (wreathsCount >= 5)
                    {
                        Console.WriteLine($"You made it, you are going to the competition with {wreathsCount} wreaths!");
                        break;
                    }
                    lilies.Pop();
                    roses.Dequeue();
                }
                else if (sum > 15)
                {
                    lilies.Pop();
                    lilies.Push(currentLilie - 2);
                }
                else if (sum < 15)
                {
                    sumForStore += sum;
                    lilies.Pop();
                    roses.Dequeue();
                }

                if (sumForStore > 0 && lilies.Count <= 0 || roses.Count<= 0)
                {
                   
                    int restWreaths = sumForStore / 15;
                    wreathsCount += restWreaths;
                }
                
                
            }

            if (wreathsCount < 5)
            {
                Console.WriteLine($"You didn't make it, you need {5-wreathsCount} wreaths more!");
            }
            
        }
    }
}
