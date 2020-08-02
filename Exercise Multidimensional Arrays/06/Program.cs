using System;
using System.ComponentModel.Design;
using System.Linq;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] matrix = new Double[rows][];

            for (int row = 0; row < rows; row++)
            {
                double[] rowValues = Console.ReadLine().Split().Select(double.Parse).ToArray();
                matrix[row] = rowValues;
            }

            for (int row = 0; row < rows - 1; row++)
            {
                double[] rowOne = matrix[row];
                double[] rowTwo = matrix[row + 1];

                if (rowOne.Length == rowTwo.Length)
                {
                    matrix[row] = rowOne.Select(e => e * 2).ToArray();
                    matrix[row + 1] = rowTwo.Select(e => e * 2).ToArray();
                }
                else
                {
                    matrix[row] = rowOne.Select(e => e / 2).ToArray();
                    matrix[row + 1] = rowTwo.Select(e => e / 2).ToArray();
                }
            }

            string commandInput = Console.ReadLine();

            while (commandInput != "End")
            {
                string[] tokens = commandInput.Split();
                string command = tokens[0];
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);


                if (!isValidCell(matrix, row, col))
                {
                    commandInput = Console.ReadLine();
                    continue;
                }
                if (command == "Add")
                {
                    matrix[row][col] += value;
                }
                else
                {
                    matrix[row][col] -= value;
                }
                commandInput = Console.ReadLine();
            }

            for (int row = 0; row < rows; row++)
            {
                Console.WriteLine(string.Join(" ", matrix[row]));
            }
        }

        static bool isValidCell(double[][] matrix, int row, int col)
        {

            return (row >= 0 && row < matrix.Length && col >= 0 && col < matrix[row].Length); 

        }

    }
}
