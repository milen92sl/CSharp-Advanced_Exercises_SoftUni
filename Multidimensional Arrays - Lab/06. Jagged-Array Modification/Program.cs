using System;
using System.ComponentModel.Design;
using System.Linq;

namespace _06._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArr = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                jaggedArr[i] = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();
            }

            string[] tokens = Console.ReadLine()
                .Split(' ');

            while (tokens[0] != "END")
            {
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);

                if (row < 0 || row >= rows || col < 0 || col >= jaggedArr[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    switch (tokens[0])
                    {
                        case "Add":
                            jaggedArr[row][col] += value;
                            break;
                        case "Subtract":
                            jaggedArr[row][col] -= value;
                            break;
                        default:
                            break;
                    }
                }
                tokens = Console.ReadLine()
                    .Split(' ');
            }
            foreach (int[] row in jaggedArr)
            {
                Console.WriteLine(string.Join(' ', row));
            }

        }
    }
}
