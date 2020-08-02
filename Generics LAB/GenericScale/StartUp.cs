using System;

namespace GenericScale
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var intEqu = new EqualityScale<string>("gg","gg");
            var intEqu2 =new EqualityScale<int>(1,5);

            Console.WriteLine(intEqu.AreEqual());
            Console.WriteLine(intEqu2.AreEqual());
        }
    }
}
