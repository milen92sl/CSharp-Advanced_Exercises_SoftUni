using System;
using System.IO;
namespace _03._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Path.Combine("data", "input.txt");
            string dest = Path.Combine("data", "output.txt");
            var lines = File.ReadAllLines(path);
            int counter = 1;
            string [] output = new string[lines.Length];
            {
                foreach (var line in lines)
                {
                    output[counter - 1] = $"{counter}. {line}";
                    counter++;  
                }
                File.WriteAllLines(dest,output);
            }

        }
    }
}
