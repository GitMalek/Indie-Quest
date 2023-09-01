using System.Reflection.Metadata.Ecma335;

namespace Fundamentals___Loops_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input a number: ");
            int n = int.Parse(Console.ReadLine());

            // Part 1

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.Write("#");
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int y = 0; y < n; y++)
            {
                for (int x = 0; x < n; x++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            int index = 1;

            for (int y = 0; y < n; y++)
            {
                for (int x = 0; x < index; x++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
                index++;
            }

            Console.WriteLine();
            index = n - 1;

            for (int y = 0; y < n; y++)
            {
                for (int x = 0; x < index; x++)
                {
                    Console.Write(" ");
                }
                for (int x = 0; x < n; x++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
                index--;
            }

            Console.WriteLine();
            index = n - 1;
            int reverseIndex = 1;

            for (int y = 0; y < n; y++)
            {
                for (int x = 0; x < index; x++)
                {
                    Console.Write(" ");
                }
                for (int x = 0; x < reverseIndex; x++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
                reverseIndex += 2;
                index--;
            }

            Console.WriteLine();

            for (int y = 0; y < n; y++)
            {
                for (int x = 0; x < n; x++)
                {
                    if (y % 2 == 0)
                    {
                        Console.Write("#");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int y = 0; y < n; y++)
            {
                for (int x = 0; x < n; x++)
                {
                    if (x % 2 == 0)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int y  = 0; y < n; y++)
            {
                for (int x = 0; x < n; x++)
                {
                    if (y % 2 == 0 || (y % 2 != 0 && x % 2 == 0))
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int y = 0; y < n; y++)
            {
                for (int x = 0; x < n; x++)
                {
                    if (y % 2 != 0 || (y % 2 == 0 && x % 2 != 0))
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int y = 0; y < n; y++)
            {
                for (int x = 0; x < n; x++)
                {
                    if (y % 2 == 0)
                    {
                        if (x % 2 == 0)
                        {
                            Console.Write("#");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        if (x % 2 != 0)
                        {
                            Console.Write("#");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            index = 1;

            while (index < 80)
            {
                for (int y = 0; y < n; y++)
                {
                    for (int x = 0; x < index; x++)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
                    index *= 2;
                }
            }

            Console.WriteLine();

            reverseIndex = 35;

            while (reverseIndex > 0)
            {
                for (int y = 0; y < n; y++)
                {
                    for (int x = 0; x < reverseIndex; x++)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
                    reverseIndex -= n;
                }
            }

            Console.WriteLine();

            reverseIndex = n;

            while (reverseIndex > 0)
            {
                for (int y = 0; y <= n - reverseIndex; y++)
                {
                    for (int x = 0; x < reverseIndex; x++)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
                }
                reverseIndex--;
            }

            Console.WriteLine();

            for (int y = 0; y < n; y++)
            {
                while (reverseIndex > 0)
                {
                    for (int x = 0; x < reverseIndex; x++)
                    {
                        Console.Write("#");
                    }
                    Console.Write(" ");
                    reverseIndex--;
                }
                Console.WriteLine();
                reverseIndex = n - y;
            }
            Console.Write("#");

            Console.WriteLine();
            Console.WriteLine();

            // Part 2

            for (int y = 0; y < 2; y++)
            {
                if (y == 0)
                {
                    for (int i = 0; i <= n * 10; i++)
                    {
                        if (i % 5 == 0)
                        {
                            Console.Write($"{i}");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                else
                {
                    for (int i = 0; i <= n * 10; i++)
                    {
                        if ((i % 5) == 0)
                        {
                            if (i > 5)
                            {
                                Console.Write("_");
                            }
                            Console.Write("|");
                        }
                        else
                        {
                            Console.Write("_");
                        }
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int x = 0; x < n + (n - 1);  x++)
            {
                if (x % 2 == 0)
                {
                    Console.Write("[^^^]");
                }
                else
                {
                    Console.Write(" ");
                }
            }


            Console.WriteLine();
            Console.Write(" ");

            for (int x = 0; x < n + (n - 1); x++)
            {
                if (x % 2 == 0)
                {
                    Console.Write("| |");
                }
                else
                {
                    Console.Write("___");
                }
            }

            Console.WriteLine();

            int middle = ((5 * n + (n - 1)) / 2) - 2;

            for (int y = 0; y < 2; y++)
            {
                Console.Write(" |");

                if (y == 0)
                {
                    for (int x = 0; x < (5 * n + (n - 1)) - 3; x++)
                    {
                        if (x != middle - 1)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("/|\\");
                            x += 3;
                        }
                    }
                }
                else if (y == 1)
                {
                    for (int x = 0; x < (5 * n + (n - 1)) - 3; x++)
                    {
                        if (x != middle - 1)
                        {
                            Console.Write("_");
                        }
                        else
                        {
                            Console.Write("|||");
                            x += 3;
                        }
                    }
                }
                Console.Write("|");
                Console.WriteLine();
            }

            for (int y = 0; y < 3; y++)
            {
                if (y == 0)
                {
                    switch (n)
                    {
                        case 0:
                        case 2:
                        case 3:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                            Console.Write(" _ ");
                            break;
                    }
                }
                if (y == 1)
                {
                    switch (n)
                    {
                        case 0:
                            Console.Write("| |");
                            break;
                        case 1:
                        case 7:
                            Console.Write("  |");
                            break;
                        case 2:
                        case 3:
                            Console.Write(" _|");
                            break;
                        case 5:
                        case 6:
                            Console.Write("|_ ");
                            break;
                        case 8:
                        case 9:
                        case 4:
                            Console.Write("|_|");
                            break;
                    }
                }
                if (y == 2)
                {
                    switch (n)
                    {
                        case 0:
                        case 6:
                        case 8:
                            Console.Write("|_|");
                            break;
                        case 1:
                        case 4:
                        case 7:
                            Console.Write("  |");
                            break;
                        case 2:
                            Console.Write("|_ ");
                            break;
                        case 3:
                        case 5:
                        case 9:
                            Console.Write(" _|");
                            break;
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            // Swedish Flag

            Console.Write("()");
            for (int x = 0; x < (3 * n) + 3; x++)
            {
                Console.Write("_");
            }

            Console.WriteLine();

            for (int y = 0; y < (2 * n) + 1; y++)
            {
                Console.Write("||");
                for (int x = 0; x < (3 * n) + 3; x++)
                {
                    if (x == n && y != n && y != 2 * n)
                    {
                        Console.Write("| |");
                        x += 2;
                    }
                    // Horizontal Flag Strip
                    else if ((y == n - 1 || y == n) && x != n)
                    {
                        Console.Write("_");
                    }
                    else if (y == n && x == n)
                    {
                        Console.Write("   ");
                        x += 2;
                    }
                    // Bottom Flag Border
                    else if (y == 2 * n && x != n)
                    {
                        Console.Write("_");
                    }
                    else if (y == 2 * n && x == n)
                    {
                        Console.Write("|_|");
                        x += 2;
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("|");
            }
            Console.WriteLine("||");
            Console.WriteLine();

            // UK Flag
            index = 0;
            reverseIndex = n - 1;

            Console.Write("()");
            for (int x = 0; x < ((2 * n) - 2) + 9; x++)
            {
                Console.Write("_");
            }

            Console.WriteLine();

            for (int y = 0; y < (2 * n) + 1; y++)
            {
                Console.Write("||");
                if (y < (((2 * n) + 1) / 2) - 1)
                {
                    for (int spaces = 0; spaces < index; spaces++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("\\ \\");
                    for (int spaces = 0; spaces < reverseIndex; spaces++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("| |");
                    for (int spaces = 0; spaces < reverseIndex; spaces++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("/ /");
                    for (int spaces = 0; spaces < index; spaces++)
                    {
                        Console.Write(" ");
                    }
                }
                else if (y == (((2 * n) + 1) / 2) - 1)
                {
                    for (int spaces = 0; spaces < index; spaces++)
                    {
                        Console.Write("_");
                    }
                    Console.Write("\\_\\");
                    for (int spaces = 0; spaces < reverseIndex; spaces++)
                    {
                        Console.Write("_");
                    }
                    Console.Write("| |");
                    for (int spaces = 0; spaces < reverseIndex; spaces++)
                    {
                        Console.Write("_");
                    }
                    Console.Write("/_/");
                    for (int spaces = 0; spaces < index; spaces++)
                    {
                        Console.Write("_");
                    }
                }
                else if (y == ((2 * n) + 1) / 2)
                {
                    for (int spaces = 0; spaces < (((2 * n) - 2) + 7) / 2; spaces++)
                    {
                        Console.Write("_");
                    }
                    Console.Write("   ");
                    for (int spaces = 0; spaces < (((2 * n) - 2) + 7) / 2; spaces++)
                    {
                        Console.Write("_");
                    }
                    index = -1;
                    reverseIndex = n;
                }
                else if (y > ((2 * n + 1) / 2) && y != 2 * n)
                {
                    for (int spaces = 0; spaces < reverseIndex; spaces++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("/ /");
                    for (int spaces = 0; spaces < index; spaces++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("| |");
                    for (int spaces = 0; spaces < index; spaces++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("\\ \\");
                    for (int spaces = 0; spaces < reverseIndex; spaces++)
                    {
                        Console.Write(" ");
                    }
                }
                else
                {
                    for (int spaces = 0; spaces < reverseIndex; spaces++)
                    {
                        Console.Write("_");
                    }
                    Console.Write("/_/");
                    for (int spaces = 0; spaces < index; spaces++)
                    {
                        Console.Write("_");
                    }
                    Console.Write("|_|");
                    for (int spaces = 0; spaces < index; spaces++)
                    {
                        Console.Write("_");
                    }
                    Console.Write("\\_\\");
                    for (int spaces = 0; spaces < reverseIndex; spaces++)
                    {
                        Console.Write("_");
                    }
                }
                index++;
                reverseIndex--;
                Console.WriteLine("|");
            }
            Console.Write("||");
            Console.WriteLine();

            // American Flag

            Console.Write("()");
            for (int x = 0; x < (2 * (n + (n - 1))); x++)
            {
                Console.Write("_");
            }

            Console.WriteLine();

            for (int y = 0; y < 2 * n; y++)
            {
                Console.Write("||");
                for (int x = 0; x < (2 * (n + (n - 1))); x++)
                {
                    if (y < n  && x < n + (n - 1) && x % 2 == 0 && y % 2 == 0)
                    {
                        Console.Write("*");
                    }
                    else if (y < n && x < n + (n - 1) && x % 2 != 0 && y % 2 == 0)
                    {
                        Console.Write(" ");
                    }
                    else if (y < n && x < n + (n - 1) && x % 2 != 0 && y % 2 != 0)
                    {
                        Console.Write("*");
                    }
                    else if (y < n && x < n + (n - 1) && x % 2 == 0 && y % 2 != 0)
                    {
                        Console.Write(" ");
                    }
                    else if (y % 2 != 0)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("|");
            }
            Console.WriteLine("||");
        }
    }
}