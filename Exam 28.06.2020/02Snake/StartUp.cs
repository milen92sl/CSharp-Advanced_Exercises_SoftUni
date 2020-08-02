using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            int rowSnake = 0;
            int colSnake = 0;
            List<int> burrow = new List<int>(4);
            bool burrowB = false;
            //inputMatrix
            for (int row = 0; row < size; row++)
            {
                string line = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = line[col];
                    if (matrix[row, col] == 'S')
                    {
                        rowSnake = row;
                        colSnake = col;
                    }
                    else if (matrix[row, col] == 'B')
                    {
                        burrowB = true;
                        burrow.Add(row);
                        burrow.Add(col);
                    }
                }
            }
            //MoveSnake
            int firstBurrowRow = 0;
            int firstBurrowCol = 0;
            int secondBurrowRow = 0;
            int secondBurrowCol = 0;
            if (burrowB)
            {
                firstBurrowRow = burrow[0];
                firstBurrowCol = burrow[1];
                secondBurrowRow = burrow[2];
                secondBurrowCol = burrow[3];
            }

            int foodEaten = 0;
            bool outOfRange = false;
            while (!outOfRange)
            {
                if (foodEaten >= 10)
                {
                    break;
                }
                string command = Console.ReadLine();
                matrix[rowSnake, colSnake] = '.';
                switch (command)
                {
                    case "up":
                        int rowD = -1;
                        if (InRange(size, rowD, rowSnake))
                        {
                            rowSnake--;
                        }
                        else
                        {
                            outOfRange = true;
                            continue;
                        }
                        break;
                    case "down":
                        rowD = 1;
                        if (InRange(size, rowD, rowSnake))
                        {
                            rowSnake++;
                        }
                        else
                        {
                            outOfRange = true;
                            continue;
                        }
                        break;
                    case "left":
                        int colD = -1;
                        if (InRange(size, colD, colSnake))
                        {
                            colSnake--;
                        }
                        else
                        {
                            outOfRange = true;
                            continue;
                        }
                        break;
                    case "right":
                        colD = 1;
                        if (InRange(size, colD, colSnake))
                        {
                            colSnake++;
                        }
                        else
                        {
                            outOfRange = true;
                            continue;
                        }
                        break;
                }
                //check for Food

                if (matrix[rowSnake, colSnake] == '*')
                {
                    foodEaten++;
                }
                else if (matrix[rowSnake, colSnake] == 'B')
                {
                    matrix[rowSnake, colSnake] = '.';
                    if (rowSnake == firstBurrowRow)
                    {
                        rowSnake = secondBurrowRow;
                        colSnake = secondBurrowCol;
                    }
                    else
                    {
                        rowSnake = firstBurrowRow;
                        colSnake = firstBurrowCol;
                    }
                }
                matrix[rowSnake, colSnake] = 'S';
            }

            if (outOfRange)
            {
                Console.WriteLine("Game over!");
            }
            else
            {
                Console.WriteLine("You won! You fed the snake.");
            }

            Console.WriteLine($"Food eaten: {foodEaten}");
            PrintMatrix(matrix, size);
        }
        private static bool InRange(int size, int rowDorColD, int rowOrColPlayer)
        {
            return rowOrColPlayer + rowDorColD >= 0 && rowOrColPlayer + rowDorColD < size;
        }

        private static void PrintMatrix(char[,] matrix, int size)
        {
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}