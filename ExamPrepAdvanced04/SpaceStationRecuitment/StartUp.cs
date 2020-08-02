using System;

namespace SpaceStationRecuitment
{
    public class StartUp
    {
        private const int MIN_STAR_POWER_NEEDED = 50;

        private static char[][] galaxy;

        private static int playerRow;

        private static int playerCol;

        private static int collectedEnergy;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            galaxy = new char[n][];
            bool found = false;
            for (int row = 0; row < n; row++)
            {
                char[] currentRow = Console.ReadLine()
                    .ToCharArray();
                if (!found)
                {
                    for (int col = 0; col < currentRow.Length; col++)
                    {
                        if (currentRow[col] == 'S')
                        {
                            playerRow = row;
                            playerCol = col;

                            found = true;
                            break;
                        }
                    }
                }

                galaxy[row] = currentRow;
            }

            while (collectedEnergy < MIN_STAR_POWER_NEEDED)
            {
                string direction = Console.ReadLine();
                int nextRow = playerRow;
                int nextCol = playerCol;
                if (direction == "up")
                {
                    if (playerRow - 1 >= 0)
                    {
                        nextRow = playerRow - 1;
                        nextCol = playerCol;
                        ProceedMove(nextRow, nextCol, n);
                    }
                    else
                    {
                        break;
                    }


                }
                else if (direction == "down")
                {
                    if (playerRow + 1 < n)
                    {
                        nextRow = playerRow + 1;
                        nextCol = playerCol;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (direction == "left")
                {
                    if (playerCol - 1 >= 0)
                    {
                        nextRow = playerRow;
                        nextCol = playerCol - 1;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (direction == "right")
                {
                    if (playerCol + 1 < n)
                    {
                        nextRow = playerRow;
                        nextCol = playerCol + 1;
                    }
                    else
                    {
                        break;
                    }
                }

                bool isOutsideOfTheGalaxy = nextRow < 0 || nextRow >= n || nextCol < 0 || nextCol >= n;

                if (isOutsideOfTheGalaxy)
                {
                    galaxy[playerRow][playerCol] = '-';
                    break;
                }

                ProceedMove(n, nextRow, nextCol);
            }

            if (collectedEnergy >= MIN_STAR_POWER_NEEDED)
            {
                Console.WriteLine("Good news!");
            }
            else
            {
                Console.WriteLine("Bad news!");
            }

            Console.WriteLine($"Star power collected: {collectedEnergy}");

            for (int row = 0; row < n; row++)
            {
                Console.WriteLine(String.Join("", galaxy[row]));
            }
        }

        private static void ProceedMove(int nextRow, int nextCol, int n)
        {
            char nextSymbol = galaxy[nextRow][nextCol];

            if (char.IsDigit(nextSymbol))
            {
                int starEnergy = (int)(nextSymbol) - 48;

                collectedEnergy += starEnergy;
            }
            else if (nextSymbol == 'O')
            {
                galaxy[nextRow][nextCol] = '-';
                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        char iterSymbol = galaxy[row][col];

                        if (iterSymbol == 'O')
                        {
                            nextRow = row;
                            nextCol = col;
                        }
                    }
                }
            }

            galaxy[nextRow][nextCol] = 'S';
            galaxy[playerRow][playerCol] = '-';

            playerRow = nextRow;
            playerCol = nextCol;
        }
    }
}