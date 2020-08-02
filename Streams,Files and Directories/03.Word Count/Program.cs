using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace _03.Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] words = File.ReadAllLines("words.txt");
            string[] lines = File.ReadAllLines("text.txt");

            Dictionary<string, int> wordsFraquency = new Dictionary<string, int>();

            foreach (string word in words)
            {
                wordsFraquency.Add(word.ToLower(), 0);
            }

            foreach (string line in lines)
            {
                string[] textLine = line.ToLower()
                    .Split(new char[] {' ', '-', '.', ',', '!', '?'});

                foreach (var word in textLine)
                {
                    if (wordsFraquency.ContainsKey(word))
                    {
                        wordsFraquency[word]++;
                    }
                }
            }

            wordsFraquency.OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, y => y.Value);

            StringBuilder sb = new StringBuilder();

            foreach ((var word,int count) in wordsFraquency)
            {
                sb.Append($"{word} - {count}");
            }

            File.WriteAllText("actualResult.txt",sb.ToString());

        }
    }
}
