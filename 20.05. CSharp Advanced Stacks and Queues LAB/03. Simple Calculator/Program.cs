using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace _03._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<string> stack = new Stack<string>(input
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Reverse());

            while (stack.Count > 1 )
            {
                int operand1 = int.Parse(stack.Pop());
                string opr = stack.Pop();
                int operand2 = int.Parse(stack.Pop());

                switch (opr)
                {
                    case "+":
                        stack.Push((operand1 + operand2).ToString());
                        break;
                    case "-":
                        stack.Push((operand1 - operand2).ToString());
                        break;

                    default:
                        throw new ArgumentException("Unknown operator");
                        
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
