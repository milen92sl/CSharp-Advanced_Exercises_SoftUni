using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                Person person = new Person(tokens[0], int.Parse(tokens[1]));
                people.Add(person);
            }

            people = people.Where(p => p.Age > 30)
                .OrderBy(p => p.Name)
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, people));
        }

    }
}
