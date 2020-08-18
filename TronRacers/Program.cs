using System;

namespace TronRacers
{
    class Program
    {
        static char[][] battleField;
        private static int firsPlayerRow;
        private static int firsPlayerCol;

        private static int secondPlayerRow;
        private static int secondPlayerCol;
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            battleField = new char [rows][];

            Initializer();

            while (true)
            {
                string[] direction = Console.ReadLine().Split();

                string firstPlayerDirection = direction[0];
                string secondPlayerDirection = direction[1];

                if (firstPlayerDirection == "down")
                {
                    firsPlayerRow++;
                    if (firsPlayerRow == battleField.Length)
                    {
                        firsPlayerRow = 0;
                    }
                }
                else if (firstPlayerDirection == "up")
                {
                    firsPlayerRow--;
                    if (firsPlayerRow < 0)
                    {
                        firsPlayerRow = battleField.Length-1;
                    }
                }
                else if (firstPlayerDirection == "left")
                {
                    firsPlayerCol--;
                    if (firsPlayerCol < 0)
                    {
                        firsPlayerCol = battleField[firsPlayerRow].Length - 1;
                    }
                }
                else if (firstPlayerDirection == "right")
                {
                    firsPlayerCol++;
                    if (firsPlayerCol == battleField[firsPlayerRow].Length)
                    {
                        firsPlayerCol = 0;
                    }
                }

                if (battleField[firsPlayerRow][firsPlayerCol] == 's')
                {
                    battleField[firsPlayerRow][firsPlayerCol] = 'x';
                    End();
                }
                else
                {
                    battleField[firsPlayerRow][firsPlayerCol] = 'f';
                }

                if (secondPlayerDirection == "down")
                {
                    secondPlayerRow++;
                    if (secondPlayerRow == battleField.Length)
                    {
                        secondPlayerRow = 0;
                    }
                }
                else if (secondPlayerDirection == "up")
                {
                    secondPlayerRow--;
                    if (secondPlayerRow < 0)
                    {
                        secondPlayerRow = battleField.Length-1;
                    }
                }
                else if (secondPlayerDirection == "left")
                {
                    secondPlayerCol--;
                    if (secondPlayerCol < 0)
                    {
                        secondPlayerCol = battleField[secondPlayerRow].Length - 1;
                    }
                }
                else if (secondPlayerDirection == "right")
                {
                    secondPlayerCol++;
                    if (secondPlayerCol == battleField[secondPlayerRow].Length)
                    {
                        secondPlayerCol = 0;
                    }
                }

                if (battleField[secondPlayerRow][secondPlayerCol] == 'f')
                {
                    battleField[secondPlayerRow][secondPlayerCol] = 'x';
                    End();
                }
                else
                {
                    battleField[secondPlayerRow][secondPlayerCol] = 's';
                }
            }
        }

        private static void End()
        {
            for (int row = 0; row < battleField.Length; row++)
            {
                for (int col = 0; col < battleField.Length; col++)
                {
                    Console.Write(battleField[row][col]);
                }

                Console.WriteLine();
            }
            Environment.Exit(0);
        }

        private static void Initializer()
        {
            for (int row = 0; row < battleField.Length; row++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                battleField[row] = new char [input.Length];

                for (int col = 0; col < input.Length; col++)
                {
                    battleField[row][col] = input[col];
                    if (battleField[row][col] == 'f')
                    {
                        firsPlayerRow = row;
                        firsPlayerCol = col;
                    }
                    else if (battleField[row][col] == 's')
                    {
                        secondPlayerRow = row;
                        secondPlayerCol = col;
                    }
                }
            }
        }
    }
}
