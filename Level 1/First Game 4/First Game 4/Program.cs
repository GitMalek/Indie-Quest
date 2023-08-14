namespace First_Game_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int tankDistance = random.Next(40, 71);
            // int shells = 5;
            bool directHit = false;
            bool defeat = false;

            Console.WriteLine("DANGER! A tank is approaching our position. Your artillery unit is our only hope!");
            Console.WriteLine("What is your name, commander?");
            string name = Console.ReadLine();
            Console.WriteLine();

            // add '&& shells > 0' to while loop condiitons and re-enable commented codes to turn on shells.

            while (!directHit)
            {
                Console.Clear();
                // Console.WriteLine(shells != 1 ? $"You have {shells} shells remaining" : $"You have {shells} shell remaining");
                Console.WriteLine("Here is a map of the battlefield:");

                for (int i = 0; i < 70; i++)
                {
                    if (i == 1 && tankDistance > 1)
                    {
                        Console.Write("/");
                    }
                    else if (i == 1 && tankDistance <= 1)
                    {
                        Console.Write("T");
                        defeat = true;
                    }
                    else if (i == tankDistance)
                    {
                        Console.Write("T");
                    }
                    else
                    {
                        Console.Write("_");
                    }
                }

                if (defeat)
                {
                    break;
                }
                Console.WriteLine();

                Console.WriteLine($"Aim your shot, {name}!");
                Console.Write("Enter distance: ");
                int distance = int.Parse(Console.ReadLine());

                for (int i = 0; i < 70; i++)
                {
                    if (i == distance + 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();

                if (distance + 1 == tankDistance)
                {
                    Console.WriteLine("Direct hit!");
                    directHit = true;
                }
                else if (distance + 1 > tankDistance)
                {
                    Console.WriteLine("Alas, the shell flies past the tank");
                    Console.ReadKey();
                    tankDistance -= random.Next(1, 15);

                    // shells--;
                }
                else
                {
                    Console.WriteLine("You undershot, and missed the tank");
                    Console.ReadKey();
                    tankDistance -= random.Next(1, 15);

                    // shells--;
                }
            }

            if (directHit)
            {
                Console.WriteLine();
                Console.WriteLine("You destroyed the tank!");
            }
            else if (defeat)
            {
                Console.WriteLine();
                Console.WriteLine("The tank reached the artillery cannon, you lost!");
            }
        }
    }
}