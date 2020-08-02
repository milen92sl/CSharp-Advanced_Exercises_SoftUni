using System;
using System.Linq;
using System.Threading;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split().Select(int.Parse)
                 .ToArray();

            int rows = dimentions[0];
            int cols = dimentions[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] rowValues = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }
            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] tokens = command.Split();

                if (tokens[0] != "swap" || tokens.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                int rowOne = int.Parse(tokens[1]);
                int colOne = int.Parse(tokens[2]);
                int rowTwo = int.Parse(tokens[3]);
                int colTwo = int.Parse(tokens[4]);

                bool isValidFirstCoordinates = ValidateCell(matrix, rowOne, colOne);
                bool isValidSecondCoordinates = ValidateCell(matrix, rowTwo, colTwo);

                if (!isValidFirstCoordinates || !isValidSecondCoordinates)
                {
                    command = Console.ReadLine();
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                string temp = matrix[rowOne, colOne];
                matrix[rowOne, colOne] = matrix[rowTwo, colTwo];
                matrix[rowTwo, colTwo] = temp;

                Print(matrix);

                command = Console.ReadLine();
            }
        }

        private static void Print(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static bool ValidateCell(string[,] matrix, int row, int col)
        {

            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
        }
    }
}
