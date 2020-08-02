using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;

namespace _07._The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputCommand = Console.ReadLine();
            Dictionary<string, Dictionary<string, SortedSet<string>>> app =
                new Dictionary<string, Dictionary<string, SortedSet<string>>>();

            //app[vloggerName]["followers"] -> SortedSet<vloggers>

            //app[vloggerName]["following"] -> SortedSet<vloggers>

            while (inputCommand != "Statistics")
            {
                string[] tokens = inputCommand.Split();
                string vloggerName = tokens[0];

                if (tokens[1] == "joined")
                {
                    if (!app.ContainsKey(vloggerName))
                    {
                        app.Add(vloggerName, new Dictionary<string, SortedSet<string>>());

                        app[vloggerName].Add("followers", new SortedSet<string>());
                        app[vloggerName].Add("following", new SortedSet<string>());
                    }
                }
                else
                {
                    string vloggerNameTwo = tokens[2];
                    if (!app.ContainsKey(vloggerName) || !app.ContainsKey(vloggerNameTwo) || vloggerName == vloggerNameTwo)
                    {
                        inputCommand = Console.ReadLine();
                        continue;
                    }

                    app[vloggerName]["following"].Add(vloggerNameTwo);
                    app[vloggerNameTwo]["followers"].Add(vloggerName);
                }

                inputCommand = Console.ReadLine();
            }

            Console.WriteLine($"The V-Logger has a total of {app.Count} vloggers in its logs.");
            int counter = 1;

           app =  app.OrderByDescending(kvp => kvp.Value["followers"].Count)
                .ThenBy(kvp => kvp.Value["following"].Count)
                .ToDictionary(k => k.Key,
                    v => v.Value);

            foreach ((string vlogger, Dictionary<string, SortedSet<string>> vloggerProfile) in app)
            {
                Console.WriteLine
                    ($"{counter++}. {vlogger} : {vloggerProfile["followers"].Count} followers, " +
                     $"{vloggerProfile["following"].Count} following");

                if (counter == 2)
                {
                    foreach (string f in vloggerProfile["followers"])
                    {
                        Console.WriteLine($"*  {f}");
                    }
                }
            }
        }
    }
}
