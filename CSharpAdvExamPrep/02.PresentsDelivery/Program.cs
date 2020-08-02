using System;
using System.Linq;

namespace _02.PresentsDelivery
{
    public class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());

            char[,] field = new char[fieldSize, fieldSize];
            int snakeRow = -1;
            int snakeCol = -1;

            int foodsEaten = 0;

            for (int i = 0; i < fieldSize; i++)
            {
                char[] line = Console.ReadLine()
                    .ToCharArray();

                for (int j = 0; j < line.Length; j++)
                {
                    field[i, j] = line[j];
                    if (field[i, j] == 'S')
                    {
                        snakeRow = i;
                        snakeCol = j;
                        field[i, j] = '.';
                    }

                    else if (field[i, j] == '*')
                    {
                        foodsEaten++;
                        field[i, j] = '.';
                    }
                    
                    
                }
            }

            string command = Console.ReadLine();

            while (true)
            {

                switch (command)
                {
                    case "up":
                        if (snakeRow - 1 >= 0)
                        {
                            snakeRow--;
                            field[snakeRow, snakeCol] = '.';
                        }
                        else
                        {
                            Console.WriteLine("Game over!");
                            return;
                        }

                        break;
                    case "down":
                        if (snakeRow + 1 < fieldSize)
                        {
                            snakeRow++;
                            field[snakeRow, snakeCol] = '.';
                        }
                        else
                        {
                            Console.WriteLine("Game over!");
                            return;
                        }
                        break;
                    case "left":
                        if (snakeCol - 1 >= 0)
                        {
                            snakeCol--;
                            field[snakeRow, snakeCol] = '.';
                        }
                        else
                        {
                            Console.WriteLine("Game over!");
                            return;
                        }
                        break;
                    case "right":
                        if (snakeCol + 1 < fieldSize)
                        {
                            snakeCol++;
                            field[snakeRow, snakeCol] = '.';
                        }
                        else
                        {
                            Console.WriteLine("Game over!");
                            return;
                        }
                        break;
                }





                command = Console.ReadLine();

                if (foodsEaten >= 10)
                {
                    Console.WriteLine("You won! You fed the snake.");
                    break;
                }

            }

            field[snakeRow, snakeCol] = 'S';

            Console.WriteLine($"Food eaten: {foodsEaten}");

            Console.WriteLine(string.Join("", field).Reverse());

            for (int row = 0; row < fieldSize; row++)
            {
                for (int col = 0; col < fieldSize; col++)
                {
                    Console.Write(field[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
