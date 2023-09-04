using System;
using System.ComponentModel;
using System.Diagnostics.Tracing;

namespace Fundamentals___Arrays_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part 1
            // 1.
            string[] daysOfWeek = new string[] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };

            Console.WriteLine("Days of the week are: " + string.Join(", ", daysOfWeek));

            Console.WriteLine();

            // 2.
            string[] daysOfSeptember = new string[30];
            int index = 4;

            for (int i = 0; i < daysOfSeptember.Length; i++)
            {
                if (index % 7 == 0)
                {
                    index = 0;
                }
                daysOfSeptember[i] = $"{i + 1}: {daysOfWeek[index]}";

                index++;
            }

            Console.WriteLine("Days this month are: " + string.Join(", ", daysOfSeptember));

            Console.WriteLine();

            // 3.
            var random = new Random();

            double[] doubles = new double[random.Next(5, 11)];

            for (int i = 0; i < doubles.Length; i++)
            {
                doubles[i] = random.Next(1, 11);
            }

            Console.WriteLine($"{doubles.Length} random numbers are: " + string.Join(", ", doubles));

            Console.WriteLine();

            // 4.
            double[] interpolatedDoubles = new double[doubles.Length + (doubles.Length - 1)];
            index = 0;
            double[] halves = new double[doubles.Length - 1];
            int halvesIndex = 0;

            for (int i = 1; i <= halves.Length; i++)
            {
                halves[i - 1] = (doubles[i] + doubles[i - 1]) / 2;
            }

            for (int i = 0; i < interpolatedDoubles.Length; i++)
            {
                if (i % 2 == 0)
                {
                    interpolatedDoubles[i] = doubles[index];
                    index++;
                }
                else
                {
                    interpolatedDoubles[i] = halves[halvesIndex];
                    halvesIndex++;
                }
            }

            Console.WriteLine($"Interpolated numbers are: " + string.Join(", ", interpolatedDoubles));

            Console.WriteLine();

            // Part 2
            // 1.
            int width = random.Next(2, 6);
            int height = random.Next(2, 6);
            int[][] integers = new int[height][];

            for (int i = 0; i < integers.Length; i++)
            {
                integers[i] = new int[width];

                for (int j = 0; j < width; j++)
                {
                    integers[i][j] = random.Next(10);
                }
            }

            foreach (int[] i in integers)
            {
                Console.WriteLine(string.Join("", i));
            }

            Console.WriteLine();

            // 2.
            int[][] transposedIntegers = new int[width][];

            for (int i = 0; i < transposedIntegers.Length; i++)
            {
                transposedIntegers[i] = new int[height];

                for (int j = 0; j < height; j++)
                {
                    transposedIntegers[i][j] = integers[j][i];
                }
            }

            foreach (int[] i in transposedIntegers)
            {
                Console.WriteLine(string.Join("", i));
            }

            Console.WriteLine();

            // 3.
            index = 1;
            int[][] multiplicationTable = new int[10][];

            for (int i = 0; i < multiplicationTable.Length; i++)
            {
                multiplicationTable[i] = new int[10];

                for (int j = 0; j < multiplicationTable[i].Length; j++)
                {
                    multiplicationTable[i][j] = (j + 1) * index;
                }
                index++;
            }

            foreach (int[] i in multiplicationTable)
            {
                for (int j = 0; j < i.Length; j++)
                {
                    Console.Write(i[j]);
                    if (i[j] < 10)
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // 4.
            width = 8;
            height = 8;
            int startingY = random.Next(height);
            int startingX = random.Next(width);

            int[,] chessBoard = new int[width, height];

            KnightChessBreadthFirst(chessBoard, startingX, startingY);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Console.Write($"{chessBoard[x, y],4}");
                }
                Console.WriteLine();
            }


            Console.WriteLine();

            // 5.
            char[,] tictactoeBoard = new char[width, height];
            bool end = false;
            bool win = false;
            string victoryCheck = "";

            int turnCounter = 0;

            do
            {
                bool placed = false;

                int randomX;
                int randomY;

                while (!placed)
                {
                    randomX = random.Next(3);
                    randomY = random.Next(3);

                    if (tictactoeBoard[randomX, randomY] == '\0')
                    {
                        tictactoeBoard[randomX, randomY] = turnCounter % 2 == 0 ? 'X' : 'O';
                        turnCounter++;
                        victoryCheck = tictactoeVictoryCheck(tictactoeBoard, randomX, randomY);

                        win = turnCounter > 4 && victoryCheck != null ? true : false;
                        end = turnCounter > 4 && victoryCheck != null ? true : false;

                        placed = true;
                    }
                }
                if (turnCounter == 9)
                {
                    end = true;
                }

            } while (!end);

            for (int y = 0; y < 3; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    if (tictactoeBoard[x, y] == '\0')
                    {
                        tictactoeBoard[x, y] = ' ';
                    }
                    Console.Write(tictactoeBoard[x, y]);
                }
                Console.WriteLine();
            }

            Console.WriteLine(win ? victoryCheck : "The game is a tie");

            Console.WriteLine();

            // Part 3
            // 1.
            char[][] daysInYear = new char[12][];
            char[] days = new char[] { 'S', 'M', 'T', 'W', 'T', 'F', 'S' };

            int daysIndex = 0;

            for (int i = 0; i < 12; i++)
            {
                switch (i)
                {
                    case 0:
                    case 2:
                    case 4:
                    case 6:
                    case 7:
                    case 9:
                    case 11:
                        daysInYear[i] = new char[31];
                        break;
                    case 1:
                        daysInYear[i] = new char[28];
                        break;
                    default:
                        daysInYear[i] = new char[30];
                        break;
                }

                for (int y = 0; y < daysInYear[i].Length; y++)
                {
                    if (daysIndex % 7 == 0)
                    {
                        daysIndex = 0;
                    }
                    daysInYear[i][y] = days[daysIndex];
                    daysIndex++;
                }
            }

            for (int y = 0; y < daysInYear.Length; y++)
            {
                for (int x = 0; x < daysInYear[y].Length; x++)
                {
                    Console.Write(daysInYear[y][x]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // 2.
            int numberOfPeople = random.Next(15, 26);
            int numberOfTeams = random.Next(3, 8);
            int evenSplit = numberOfPeople / numberOfTeams;
            int remainder = numberOfPeople % numberOfTeams;
            int nameIndex = 65;

            char[][] teams = new char[numberOfTeams][];

            for (int i = 0; i < numberOfTeams; i++)
            {
                teams[i] = remainder > 0 ? new char[evenSplit + 1] : new char[evenSplit];
                remainder = remainder > 0 ? remainder - 1 : remainder;

                for (int j = 0; j < teams[i].Length; j++)
                {
                    teams[i][j] = (char)nameIndex;
                    nameIndex++;
                }
            }

            for (int y = 0; y < teams.Length; y++)
            {
                Console.Write($"TEAM {y + 1}: ");
                for (int x = 0; x < teams[y].Length; x++)
                {
                    Console.Write(string.Join(", ", teams[y][x]));
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // 3.   
            char[] contestants = new char[numberOfTeams];

            for (int i = 0; i < numberOfTeams; i++)
            {
                int randomMember = random.Next(teams[i].Length);
                contestants[i] = teams[i][randomMember];
            }

            Console.WriteLine("CONTESTANTS: " + string.Join(", ", contestants));

            Console.WriteLine();

            // 4.
            int fieldWidth = random.Next(3, 6);
            int fieldHeight = random.Next(3, 6);

            char[][,] allFields = new char[numberOfTeams][,];

            for (int i = 0; i < numberOfTeams; i++)
            {
                allFields[i] = new char[fieldWidth, fieldHeight];

                for (int y = 0; y < fieldHeight; y++)
                {
                    for (int x = 0; x < fieldWidth; x++)
                    {
                        allFields[i][x, y] = '.';
                    }
                }

                for (int j = 0; j < teams[i].Length; j++)
                {
                    bool placed = false;


                    while (!placed)
                    {
                        int positionX = random.Next(fieldWidth);
                        int positionY = random.Next(fieldHeight);

                        if (allFields[i][positionX, positionY] == '.')
                        {
                            allFields[i][positionX, positionY] = teams[i][j];
                            placed = true;
                        }
                    }
                }
            }

            for (int i = 0; i < numberOfTeams; i++)
            {
                Console.WriteLine($"TEAM {i}:");
                for (int y = 0; y < fieldHeight; y++)
                {
                    for (int x = 0; x < fieldWidth; x++)
                    {
                        Console.Write(allFields[i][x, y]);
                    }
                    Console.WriteLine();
                }
            }

            Console.WriteLine();

            // 5.
            bool[,] placedOnField = new bool[fieldWidth, fieldHeight];

            for (int i = 0; i < numberOfTeams; i++)
            {
                for (int y = 0; y < fieldHeight; y++)
                {
                    for (int x = 0; x < fieldWidth; x++)
                    {
                        if (allFields[i][x, y] != '.')
                        {
                            placedOnField[x, y] = true;
                        }
                    }
                }
            }

            Console.WriteLine("LOCATIONS OF PLAYERS ON THE FIELD:");

            for (int y = 0; y < fieldHeight; y++)
            {
                for (int x = 0; x < fieldWidth; x++)
                {
                    Console.Write(placedOnField[x, y] ? '#' : '.');
                }
                Console.WriteLine();
            }
        }

            


        static string tictactoeVictoryCheck(char[,] tictactoeBoard, int lastX, int lastY)
        {
            // Vertical win check.
            if (tictactoeBoard[lastX, 0] == tictactoeBoard[lastX, 1] && tictactoeBoard[lastX, 2] == tictactoeBoard[lastX, 1])
            {
                return $"{tictactoeBoard[lastX, lastY]} wins on collumn {lastX + 1}!";
            } 

            // Horizontal win check.
            if (tictactoeBoard[0, lastY] == tictactoeBoard[1, lastY] && tictactoeBoard[2, lastY] == tictactoeBoard[1, lastY])
            {
                return $"{tictactoeBoard[lastX, lastY]} wins on row {lastY + 1}!";
            }

            // Diagonal win check.
            if (tictactoeBoard[1,1] != '\0' && tictactoeBoard[1,1] == tictactoeBoard[0,0] && tictactoeBoard[1,1] == tictactoeBoard[2,2])
            {
                return $"{tictactoeBoard[lastX, lastY]} wins on the downward diagonal!";
            }
            if (tictactoeBoard[1, 1] != '\0' && tictactoeBoard[1, 1] == tictactoeBoard[2, 0] && tictactoeBoard[1, 1] == tictactoeBoard[0, 2])
            {
                return $"{tictactoeBoard[lastX, lastY]} wins on the upward diagonal!";
            }

            return null;
        }

        static void KnightChessMoves(int[,] chessBoard, int startingX, int startingY, int moves = 0)
        {
            int width = chessBoard.GetLength(0);
            int height = chessBoard.GetLength(1);

            bool[] possibleMoves = new bool[8];
            int[,] offsets =
            {
                { -2, 1 },
                { -1, 2 },
                { 1, 2 },
                { 2,1 },
                { 2,-1 },
                { 1,-2 },
                { -1,-2 },
                { -2,-1 },
            };

            if (moves == 0)
            {
                chessBoard[startingX, startingY] = -1;

                KnightChessMoves(chessBoard, startingX, startingY, 1);

                chessBoard[startingX, startingY] = 0;
                return;
            }

            void UpdateMoves(int i, int x, int y)
            {
                if (startingX + x >= 0 && startingX + x < width && startingY + y >= 0 && startingY + y < height && (chessBoard[startingX + x, startingY + y] == 0 || chessBoard[startingX + x, startingY + y] > moves))
                {
                    chessBoard[startingX + x, startingY + y] = moves;
                    possibleMoves[i] = true;
                }
            }

            for (int i = 0; i < 8; i++)
            {
                UpdateMoves(i, offsets[i, 0], offsets[i, 1]);
            }

            for (int i = 0; i < 8; i++)
            {
                if (possibleMoves[i])
                {
                    KnightChessMoves(chessBoard, startingX + offsets[i, 0], startingY + offsets[i, 1], moves + 1);
                }
            }
        }

        static void KnightChessBreadthFirst(int[,] chessBoard, int startingX, int startingY)
        {
            int width = chessBoard.GetLength(0);
            int height = chessBoard.GetLength(1);
            bool placed = true;

            int[,] offsets =
            {
                { -2, 1 },
                { -1, 2 },
                { 1, 2 },
                { 2,1 },
                { 2,-1 },
                { 1,-2 },
                { -1,-2 },
                { -2,-1 },
            };

            chessBoard[startingX, startingY] = -1;
            int moves = 1;

            for (int i = 0; i < 8; i++)
            {
                UpdateMoves(startingX, startingY, offsets[i, 0], offsets[i, 1]);
            }

            while (placed)
            {
                placed = false;

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        if (chessBoard[x, y] == moves)
                        {
                            moves++;
                            for (int i = 0; i < 8; i++)
                            {
                                UpdateMoves(x, y, offsets[i, 0], offsets[i, 1]);
                            }
                            moves--;
                            placed = true;
                        }
                    }
                }
                moves++;
            }

            chessBoard[startingX, startingY] = 0;

            void UpdateMoves(int startingX, int startingY, int x, int y)
            {
                if (startingX + x >= 0 && startingX + x < width && startingY + y >= 0 && startingY + y < height && chessBoard[startingX + x, startingY + y] == 0)
                {
                    chessBoard[startingX + x, startingY + y] = moves;
                }
            }
        }

        public class Coordinates
        {
            public int x;
            public int y;
        }

        static void KnightChessBreadthList(int[,] chessBoard, int startingX, int startingY)
        {
            int width = chessBoard.GetLength(0);
            int height = chessBoard.GetLength(1);
            List<Coordinates> orderOfPlacement = new List<Coordinates>()
            {
                new Coordinates {x =  startingX, y = startingY}
            };
            List<int> moveCounts = new List<int>() { 1 };

            int[,] offsets =
            {
                { -2, 1 },
                { -1, 2 },
                { 1, 2 },
                { 2,1 },
                { 2,-1 },
                { 1,-2 },
                { -1,-2 },
                { -2,-1 },
            };

            int moves = 0;

            for (int i = 0; i < orderOfPlacement.Count; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    UpdateMoves(i, orderOfPlacement[i].x, orderOfPlacement[i].y, offsets[j, 0], offsets[j, 1], moves);
                }
            }

            void UpdateMoves(int i, int startingX, int startingY, int x, int y, int moves)
            {
                if (startingX + x >= 0 && startingX + x < width && startingY + y >= 0 && startingY + y < height && !orderOfPlacement.Any(p => p.x == startingX + x && p.y == startingY + y))
                {
                    orderOfPlacement.Add(new Coordinates { x = startingX + x, y = startingY + y});
                    chessBoard[startingX + x, startingY + y] = chessBoard[orderOfPlacement[i].x, orderOfPlacement[i].y] + 1;
                }
            }
        }
    }
}