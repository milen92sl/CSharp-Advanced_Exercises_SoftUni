using System;
using System.Collections.Generic;
using System.Linq;

namespace _01Bombs
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            var input2 = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();

            Stack<int> bombsEfects = new Stack<int>(input1);
            Queue<int> bombsCasing = new Queue<int>(input2);

            Dictionary<int, string> bombsTypes = new Dictionary<int, string>
            {
                {40, "Datura Bombs"},
                {60, "Cherry Bombs"},
                {120, "Smoke Decoy Bombs"},
                {400, "Bicycle"}
            };

            //bombCasings = Stack
            // bombEfects = Queue

            Dictionary<string, int> bombsMade = new Dictionary<string, int>();

            while (materialsForCrafting.Count > 0 && magicLevelValues.Count > 0)
            {
                int magicLevel = materialsForCrafting.Peek() * magicLevelValues.Peek();

            }
        }
    }
}
