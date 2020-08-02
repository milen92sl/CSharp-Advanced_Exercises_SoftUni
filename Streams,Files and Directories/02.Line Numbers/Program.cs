using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _02.Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "text.txt";
            string[] lines = File.ReadAllLines(path);
            int counter = 1;
            List<string> resLines = new List<string>();
            foreach (string line in lines)
            {
                int lettersCount = 0;
                int punctuationMarksCount = 0;

                
                foreach (char c in line)
                {
                    if (char.IsLetter(c))
                    {
                        lettersCount++;
                    }
                    else if (char.IsPunctuation(c))
                    {
                        punctuationMarksCount++;
                    }

                }
                resLines.Add(($"Line {counter++}:{line}({lettersCount})({punctuationMarksCount})"));

                File.WriteAllLines("output.txt",resLines);
            }
        }
    }
}
