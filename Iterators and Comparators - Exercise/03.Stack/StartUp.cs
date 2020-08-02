using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _03.Stack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            MyStack<int> myStack = new MyStack<int>();
            
            string commandInput = Console.ReadLine();

            while (commandInput != "END")
            {
                string[] tokens = commandInput
                    .Split(new string[]{" ", ", "},StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];

                if (command == "Push")
                {
                    foreach (string item in tokens.Skip(1))
                    {
                        myStack.Push(int.Parse(item));
                    }
                }
                else if (command == "Pop")
                {
                    if (myStack.Count == 0)
                    {
                        Console.WriteLine("No elements");
                    }
                    else
                    {
                        myStack.Pop();
                    }
                }
                commandInput = Console.ReadLine();
            }

            foreach (int i in myStack)
            {
                Console.WriteLine(i);
            }

            foreach (int i in myStack)
            {
                Console.WriteLine(i);
            }
        }
    }
}
