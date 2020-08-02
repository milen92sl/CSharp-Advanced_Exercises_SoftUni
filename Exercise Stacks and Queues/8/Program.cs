using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Stack<char> openParentheses = new Stack<char>();
            bool isBalanced = true;
            foreach (char c in expression)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    openParentheses.Push(c);
                }
                else
                {
                    if (!openParentheses.Any())
                    {
                        isBalanced = false;
                        break;
                    }
                    char currentOpenParentheses = openParentheses.Pop();
                    
                    bool isRoundBalanced = currentOpenParentheses == '(' && c == ')';
                    bool isCurlyBalanced = currentOpenParentheses == '{' && c == '}';
                    bool isSquareBalanced = currentOpenParentheses == '[' && c == ']';

                    if (isRoundBalanced == false && isCurlyBalanced == false && isSquareBalanced == false)
                    {
                        isBalanced = false;
                        break;
                    } 
                }
            }

            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
