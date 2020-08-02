using System;
using System.Linq;

namespace _10._Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            var guests = Console.ReadLine().Split().ToList();

            Func<string, string, string, bool> filter = (guest, action, criteria) => action == "EndsWith" ?
                guest.EndsWith(criteria) : action == "StartsWith" ?
                    guest.StartsWith(criteria) : guest.Length == int.Parse(criteria);


            while (true)
            {
                var input = Console.ReadLine().Split();

                if (input[0] == "Party!")
                {
                    break;
                }

                var command = input[0];
                var action = input[1];
                var criteria = input[2];

                if (command == "Remove")
                {
                    guests = guests.Where(g => !filter(g, action, criteria)).ToList();
                }

                else if (command == "Double")
                {
                    var duplicate = guests.Where(g => filter(g, action, criteria)).ToList();

                    foreach (var guest in duplicate)
                    {
                        int index = guests.IndexOf(guest) + 1;

                        guests.Insert(index, guest);
                    }
                }
            }

            if (guests.Any())
            {
                Console.WriteLine($"{string.Join(", ", guests)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
    }
}
