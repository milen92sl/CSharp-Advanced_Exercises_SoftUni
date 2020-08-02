using System;
using System.Collections.Generic;

namespace _05.ComparingObjects
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            
            List<Person> people = new List<Person>();
            string commandInput = Console.ReadLine();

            while (commandInput != "END")
            {
                string[] tokens = commandInput.Split();
                string command = tokens[0];
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string town = tokens[2];
                people.Add(new Person(name, age, town));

                commandInput = Console.ReadLine();

            }

            int n = int.Parse(Console.ReadLine());
            Person person = people[n - 1];
            int numberOfNotEqualPeople = 0;
            int countOfMatches = 0;


            foreach (Person currentPerson in people)
            {
                int res = person.CompareTo(currentPerson);

                if (res< 0)
                {
                    numberOfNotEqualPeople++;
                }
                else if (res > 0)
                {
                    numberOfNotEqualPeople++;
                }
                else
                {
                    countOfMatches++;
                }

            }

            if (countOfMatches == 1) 
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{countOfMatches} {numberOfNotEqualPeople} {people.Count}");
            }
            
        }
    }
}
