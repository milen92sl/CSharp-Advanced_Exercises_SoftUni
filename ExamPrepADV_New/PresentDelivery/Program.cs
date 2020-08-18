using System;
using System.Linq;

namespace PresentDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPresents = int.Parse(Console.ReadLine());
            int neighbourhoodSize = int.Parse(Console.ReadLine());

            char[,] hood = new char[neighbourhoodSize, neighbourhoodSize];
            int santaRow = -1;
            int santaCol = -1;
            int niceKidsCounter = 0;

            for (int i = 0; i < neighbourhoodSize; i++)
            {
                var line = Console.ReadLine()
                    .Split()
                    .Select(char.Parse)
                    .ToArray();

                for (int j = 0; j < line.Length; j++)
                {
                    hood[i, j] = line[j];

                    if (hood[i, j] == 'S')
                    {
                        santaRow = i;
                        santaCol = j;
                    }

                    if (hood[i,j] == 'V')
                    {
                        niceKidsCounter++;
                    }
                }

            }

            string command = Console.ReadLine();
            while (command != "Christmas morning")
            {
                
                hood[santaRow, santaCol] = '-';
                switch (command)
                {
                    case "up":
                        santaRow--;
                        break;
                    case "down":
                        santaRow++;
                        break;
                    case "left":
                        santaCol--;
                        break;
                    case "right":
                        santaCol++;
                        break;
                }

                if (hood[santaRow, santaCol] == 'V')
                {
                    countOfPresents--;
                }

                else if (hood[santaRow, santaCol] == 'C')
                {
                    if (hood[santaRow - 1, santaCol] != '-')
                    {
                        countOfPresents--;
                        hood[santaRow - 1, santaCol] = '-';
                    }
                    if (hood[santaRow + 1, santaCol] != '-')
                    {
                        countOfPresents--;
                        hood[santaRow + 1, santaCol] = '-';
                    }

                    if (hood[santaRow, santaCol - 1] != '-')
                    {
                        countOfPresents--;
                        hood[santaRow, santaCol - 1] = '-';
                    }
                    if (hood[santaRow, santaCol + 1] != '-')
                    {
                        countOfPresents--;
                        hood[santaRow, santaCol + 1] = '-';
                    }
                }

                if (countOfPresents <= 0)
                {
                    Console.WriteLine("Santa ran out of presents!");
                    break;
                }

                command = Console.ReadLine();
            }

            hood[santaRow, santaCol] = 'S';

            int niceKidWithNoPresents = 0;
            for (int row = 0; row < neighbourhoodSize; row++)
            {
                for (int col = 0; col < neighbourhoodSize; col++)
                {
                    Console.Write(hood[row, col] + " ");
                    if (hood[row,col] == 'V')
                    {
                        niceKidWithNoPresents++;
                    }
                }
                Console.WriteLine();
            }

            if (niceKidWithNoPresents == 0)
            {
                Console.WriteLine($"Good job, Santa! {niceKidsCounter} happy nice kid/s.");
            }
            else
            {
                Console.WriteLine($"No presents for {niceKidWithNoPresents} nice kid/s.");
            }
        }
    }
}
