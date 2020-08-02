using System;
using System.Linq;
using System.Numerics;

namespace _05.Square_with_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[size[0], size[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currentRow = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            int maxSum = int.MinValue;
            int maxSumRow = -1;
            int maxSumCol = -1;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int sum = matrix[row, col];
                    sum += matrix[row, col + 1];
                    sum += matrix[row + 1, col];
                    sum += matrix[row + 1, col + 1];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxSumCol = col;
                        maxSumRow = row;
                    }
                }
            }

            Console.WriteLine($"{matrix[maxSumRow,maxSumCol]} {matrix[maxSumRow, maxSumCol+1]}");
            Console.WriteLine($"{matrix[maxSumRow +1 ,maxSumCol]} {matrix[maxSumRow +1, maxSumCol+1]}");
            Console.Write(maxSum);
            
        }
    }
}
