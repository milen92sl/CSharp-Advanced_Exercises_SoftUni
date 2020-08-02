using System;
using System.IO;
using System.Linq;

namespace _01.Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "text.txt";
            string outputName = "output.txt";

            using StreamReader streamReader = new StreamReader(fileName);
            using StreamWriter streamWriter = new StreamWriter(outputName);

            string line = streamReader.ReadLine();
            int counter = 0;

            while (line != null)
            {
                if (counter++ % 2 == 0)
                {
                    string[] lineArr = line
                        .Split(new string[] { "-", ",", ".", "!", "?" },
                            StringSplitOptions.RemoveEmptyEntries);

                    string result = string.Join("@", lineArr.Reverse());
                    streamWriter.WriteLine(result);
                }

                line = Console.ReadLine();
            }
        }
    }
}
    

