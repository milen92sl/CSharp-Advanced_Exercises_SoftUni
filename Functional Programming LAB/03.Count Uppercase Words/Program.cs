using System;
using System.ComponentModel;
using System.Linq;

namespace _03.Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> isFirstLetterCapital = 
                str => str[0] == str.ToUpper()[0];
            
            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(x=> isFirstLetterCapital(x))
                .ToList()
                .ForEach(x=> Console.WriteLine(x));

        }
    }
}
