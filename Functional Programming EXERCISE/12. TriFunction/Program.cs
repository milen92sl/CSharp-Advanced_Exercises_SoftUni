﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> people = Console.ReadLine()
                .Split()
                .ToList();

            Func<string, int> getAsciiSum = p => p.Select(c=> (int)c).Sum();
            //string person = GetName(people, n, getAsciiSum);
            //Console.WriteLine(person);

            Func<List<string>, int, Func<string, int>, string> nameFunc = (person, n, func) =>
                people.FirstOrDefault(p=> func(p) >= n);

            string res = nameFunc(people, n, getAsciiSum);
            Console.WriteLine(res);
        }

        static string GetName(List<string> people, int n, Func<string,int> func )
        {
            string res = null;

            foreach (var person in people)
            {
                if (func(person) >= n)
                {
                    res = person;
                }
            }
            return res;
        }
    }
}
