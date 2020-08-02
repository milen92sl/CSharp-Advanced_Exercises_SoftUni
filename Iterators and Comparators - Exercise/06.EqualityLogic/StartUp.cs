using System;
using System.Collections.Generic;

namespace _06.EqualityLogic
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            SortedSet<Person> peopleSortedSet = new SortedSet<Person>();
            HashSet<Person> peopleHashSet = new HashSet<Person>();

            List<Person> people = new List<Person>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string name = tokens[0];
                int age = int.Parse(tokens[1]);

                Person person = new Person(name, age);

                peopleSortedSet.Add(person);
                peopleHashSet.Add(person);
            }

            Console.WriteLine(peopleSortedSet.Count);
            Console.WriteLine(peopleHashSet.Count);

        }
    }
}
