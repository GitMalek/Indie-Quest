using System;
using System.ComponentModel;

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
                        if (turnCounter % 2 == 0)
                        {
                            tictactoeBoard[randomX, randomY] = 'X';
                        }
                        else
                        {
                            tictactoeBoard[randomX, randomY] = 'O';
                        }
                        placed = true;
                    }
                }
                
                
            } while (end);
            

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