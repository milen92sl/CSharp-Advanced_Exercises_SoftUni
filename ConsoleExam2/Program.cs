using System;
using System.Linq;

namespace ConsoleExam2
{
    class Program
    {
        private static int PolinatedFlowersCount = 0;
        private static bool gotLost = false;
        static void Main(string[] args)
        {
            int territorySize = int.Parse(Console.ReadLine());

            char[,] territory = new char[territorySize, territorySize];
            int beeRow = -1;
            int beeCol = -1;
            int neededFlowers = 5;
            int flowersForPolinate = 0;



            for (int i = 0; i < territorySize; i++)
            {
                string line = Console.ReadLine();
                char[] charsLine = line.ToCharArray();

                for (int j = 0; j < charsLine.Length; j++)
                {
                    territory[i, j] = line[j];

                    if (territory[i, j] == 'B')
                    {
                        beeRow = i;
                        beeCol = j;
                    }

                    if (territory[i, j] == 'f')
                    {
                        flowersForPolinate++;
                    }
                }

            }
            string command = Console.ReadLine();
            int notPolinatedFlowers = 0;

            while (command != "End")
            {

                if (Moving(territory, command, territorySize, ref beeRow, ref beeCol)) break;

                command = Console.ReadLine();
            }

            if (PolinatedFlowersCount >= 5)
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {PolinatedFlowersCount} flowers!");
            }
            else
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {Math.Abs(neededFlowers - PolinatedFlowersCount)} flowers more");
            }

            if (gotLost)
            {
                territory[beeRow, beeCol] = '.';
                for (int row = 0; row < territorySize; row++)
                {
                    for (int col = 0; col < territorySize; col++)
                    {
                        Console.Write(territory[row, col]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                territory[beeRow, beeCol] = 'B';
                for (int row = 0; row < territorySize; row++)
                {
                    for (int col = 0; col < territorySize; col++)
                    {
                        Console.Write(territory[row, col]);
                    }
                    Console.WriteLine();
                }
            }

        }

        private static bool Moving(char[,] territory, string command, int territorySize, ref int beeRow, ref int beeCol)
        {


            territory[beeRow, beeCol] = '.';

            if (command == "up")
            {
                if (beeRow - 1 >= 0)
                {
                    beeRow--;
                    if (territory[beeRow, beeCol] == 'f')
                    {
                        PolinatedFlowersCount++;
                    }
                    if (territory[beeRow, beeCol] == 'O')
                    {
                        Moving(territory, command, territorySize, ref beeRow, ref beeCol);
                    }
                    territory[beeRow, beeCol] = '.';
                }
                else
                {

                    Console.WriteLine("The bee got lost!");
                    gotLost = true;
                    return true;

                }
            }

            if (command == "down")
            {
                if (beeRow + 1 <= territorySize - 1)
                {
                    beeRow++;
                    if (territory[beeRow, beeCol] == 'f')
                    {
                        PolinatedFlowersCount++;
                    }
                    if (territory[beeRow, beeCol] == 'O')
                    {
                        Moving(territory, command, territorySize, ref beeRow, ref beeCol);
                    }
                    territory[beeRow, beeCol] = '.';
                }
                else
                {

                    Console.WriteLine("The bee got lost!");
                    gotLost = true;
                    return true;
                }
            }

            if (command == "left")
            {
                if (beeCol - 1 >= 0)
                {
                    beeCol--;
                    if (territory[beeRow, beeCol] == 'f')
                    {
                        PolinatedFlowersCount++;
                    }
                    if (territory[beeRow, beeCol] == 'O')
                    {
                        Moving(territory, command, territorySize, ref beeRow, ref beeCol);
                    }
                    territory[beeRow, beeCol] = '.';
                }
                else
                {

                    Console.WriteLine("The bee got lost!");
                    gotLost = true;
                    return true;
                }
            }

            if (command == "right")
            {
                if (beeCol + 1 <= territorySize + 1)
                {
                    beeCol++;
                    if (territory[beeRow, beeCol] == 'f')
                    {
                        PolinatedFlowersCount++;
                    }
                    if (territory[beeRow, beeCol] == 'O')
                    {
                        Moving(territory, command, territorySize, ref beeRow, ref beeCol);
                    }
                    territory[beeRow, beeCol] = '.';
                }
                else
                {
                    Console.WriteLine("The bee got lost!");
                    gotLost = true;
                    return true;
                }
            }

            return false;
        }
    }
}
