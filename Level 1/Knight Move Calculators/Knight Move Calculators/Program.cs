using System;

namespace Knight_Move_Calculators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Change dimensions of the board as needed.
            int width = 10000;
            int height = 10000;

            var random = new Random();
            int[,] chessBoard = new int[width, height];

            // Set the knight's starting position, marked as 0. Good test to see if it's right is to set all 3 to the same starting position.
            int startingY = random.Next(height);
            int startingX = random.Next(width);

            /* Breadth-First then Depth-First
            Console.WriteLine("Breadth-First then Depth-First:");
            chessBoard = new int[width,height];

            KnightChessMoves(chessBoard, startingX, startingY);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Console.Write($"{chessBoard[x, y],4}");
                }
                Console.WriteLine();
            }
            */

            Console.WriteLine();

            /* Breadth-First, scanning the chessboard each time.
            Console.WriteLine("Breadth-First, chessboard scan:");
            chessBoard = new int[width, height];

            KnightChessBreadthFirst(chessBoard, startingX, startingY);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Console.Write($"{chessBoard[x, y],4}");
                }
                Console.WriteLine();
            }
            */

            Console.WriteLine();

            // Breadth-First, creating a list to order the squares to fill.
            Console.WriteLine("Breadth-First, To-Do List:");
            chessBoard = new int[width, height];

            KnightChessBreadthList(chessBoard, startingX, startingY);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Console.Write($"{chessBoard[x, y],4}");
                }
                Console.WriteLine();
            }
        }

        // Mixed breadth-first, then depth-first search. Rough maximum board size before heavy slow-downs: 100x100.
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

        // Breadth-first search, filling out boxes by order of moves, checking the board to see if all the spaces that require n moves have been filled before filling in the n + 1 moves. Rough maximum board size before heavy slow-downs: 2000x2000.
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

        /* Breadth-first search by creating a list of spaces in the order they should be filled out in. Rough maximum board size before heavy slow-downs: 200x200. Using .Any() to verify if a coordinate class
           has already been inputted probably causes a lot of slow down, and there's probably a better way to make that check OR a better condition to make sure no space is overwritten that I don't know yet. */

        /* Nevermind. I got up at 2 AM because I realized that I can just check for zeroes and make sure to exclude the origin point since that's the only one I don't want overwritten anyways.
           New maximum board size before heavy slow-downs: 10,000x10,000. The .Any() REALLY slowed it down. */

        /* Tested performance for including an exception for the starting position in the if condition VS. just changing the start position back to 0 when the method is done. Reverting the position took 22 seconds
           while keeping it in the if condition took 21 seconds. It's more likely that I just did a bad job using the diagnostic tools though. */
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

            void UpdateMoves(int i, int beginningX, int beginningY, int x, int y, int moves)
            {
                if (beginningX + x >= 0 && beginningX + x < width && beginningY + y >= 0 && beginningY + y < height && chessBoard[beginningX + x, beginningY + y] == 0 && (beginningX + x != startingX || beginningY + y != startingY))
                {
                    orderOfPlacement.Add(new Coordinates { x = beginningX + x, y = beginningY + y });
                    chessBoard[beginningX + x, beginningY + y] = chessBoard[orderOfPlacement[i].x, orderOfPlacement[i].y] + 1;
                }
            }
        }
    }
}