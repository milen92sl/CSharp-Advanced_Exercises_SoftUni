using System;
using System.Collections.Generic;
using System.Security;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var data = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(new string [] {" -> ",","},StringSplitOptions.None);

                string color = tokens[0];

                if (!data.ContainsKey(color))
                {
                    data.Add(color, new Dictionary<string, int>());
                }


                for (int j = 1; j < tokens.Length; j++)
                {
                    string currentClothes = tokens[j];

                    if (!data[color].ContainsKey(currentClothes))
                    {
                        data[color].Add(currentClothes, 0);
                    }

                    data[color][currentClothes]++;
                }
            }

            string [] searchedData = Console.ReadLine().Split();
            string searchedColor = searchedData[0];
            string seachedClothes = searchedData[1];

            foreach ((string color, Dictionary<string,int> clothesData) in data)
            {
                Console.WriteLine($"{color} clothes:");
                foreach ((string c, int counter) in clothesData)
                {

                    if (searchedColor == color && seachedClothes == c)
                    {
                        Console.WriteLine($"* {c} - {counter} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {c} - {counter}");
                    }
                }
            }
        }
    }
}
