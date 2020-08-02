using System;
using System.IO;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using Microsoft.VisualBasic.FileIO;

namespace _01.Oddline
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Path.Combine("data", "input.txt");
            var dest = Path.Combine("data", "output.txt");

            using (FileStream file = new FileStream(path, FileMode.Open))
            {
                using (TextReader text = new StreamReader(file))
                {
                    using (FileStream destFile = new FileStream(dest, FileMode.Create))
                    {
                        using (TextWriter writer = new StreamWriter(destFile))
                        {
                            string line = text.ReadLine();
                            int lineNumber = 0;
                            while (line != null)
                            {
                                if (lineNumber % 2 != 0)
                                {
                                   writer.WriteLine(line);
                                }
                                lineNumber++;
                                line = text.ReadLine();
                            }
                        }
                    }

                }
            }
        }
    }
}
