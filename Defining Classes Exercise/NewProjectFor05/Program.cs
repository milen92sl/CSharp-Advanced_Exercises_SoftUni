using System;

namespace NewProjectFor05
{
    public class Program
    {
        static void Main(string[] args)
        {
            double res = DateModifier.GetDaysBetween(Console.ReadLine(), Console.ReadLine());
            Console.WriteLine(res);
        }
    }
}
