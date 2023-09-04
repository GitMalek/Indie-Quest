namespace Fundamentals___Algorithm_Design_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fractal();

            /*
            List<string> party = new List<string>() {"Jazlyn", "Theron", "Dayana", "Rolando"};
            Console.WriteLine("The heroes in the party are: " + JoinWithAnd(party));

            party.Remove("Jazlyn");
            Console.WriteLine("The heroes in the party are: " + JoinWithAnd(party));

            party.Remove("Theron");
            Console.WriteLine("The heroes in the party are: " + JoinWithAnd(party));

            party.Remove("Dayana");
            Console.WriteLine("The heroes in the party are: " + JoinWithAnd(party));

            party = new List<string>() { "Jazlyn", "Theron", "Dayana", "Rolando" };
            Console.WriteLine("The heroes in the party are: " + JoinWithAnd(party, false));

            party.Remove("Jazlyn");
            Console.WriteLine("The heroes in the party are: " + JoinWithAnd(party, false));

            party.Remove("Theron");
            Console.WriteLine("The heroes in the party are: " + JoinWithAnd(party, false));

            party.Remove("Dayana");
            Console.WriteLine("The heroes in the party are: " + JoinWithAnd(party, false)); */

            /*
            List<int> testOrdinals = new List<int>() { 1, 2, 3, 4, 10, 11, 12, 13, 21, 101, 111, 121 };
            foreach (int ordinal in testOrdinals)
            {
                Console.WriteLine(OrdinalNumber(ordinal));
            } */

            Matrix();
        }

        static void Fractal()
        {
            for (int y = -10; y <= 10; y++)
            {
                for (int x = 1; x <= 80; x++)
                {
                    double r = 0;
                    double i = 0;
                    int k = -1;

                    while ((r * r) + (i * i) < 11 && k < 112)
                    {
                        double t = r;
                        r = (t * t) - (i * i) - 2.3 + x / 24.5;
                        i = 2 * t * i + y / 8.5;
                        k++;
                    }

                    int c = k % 16;
                    Console.BackgroundColor = (ConsoleColor)c;

                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }

        static string JoinWithAnd(List<string> items, bool useSerialComma = true)
        {
            int count = items.Count();

            if (count == 0)
            {
                return "";
            }
            else if (count == 1)
            {
                return items[0];
            }
            else if (count == 2)
            {
                return items[0] + " and " + items[1]; 
            }
            else
            {
                List<string> itemsCopy = new List<string>(items);

                if (useSerialComma)
                {
                    itemsCopy[itemsCopy.Count - 1] = "and " + itemsCopy[itemsCopy.Count - 1];

                    return string.Join(", ", itemsCopy);
                }
                else
                {
                    itemsCopy[itemsCopy.Count - 2] = itemsCopy[itemsCopy.Count - 2] + " and " + itemsCopy[itemsCopy.Count - 1];
                    itemsCopy.RemoveAt(itemsCopy.Count - 1);

                    return string.Join(", ", itemsCopy);
                }
            }
        }

        static string OrdinalNumber(int number)
        {
            int lastDigit = number % 10;

            if (number > 10)
            {
                int secondToLastDigit = (number / 10) % 10;
                if (secondToLastDigit == 1)
                {
                    return $"{number}th";
                }
            }

            switch (lastDigit)
            {
                case 1:
                    return $"{number}st";
                case 2:
                    return $"{number}nd";
                case 3:
                    return $"{number}rd";
                default:
                    return $"{number}th";
            }
        }

        static void Matrix()
        {
            var random = new Random();
            List<int> streams = new List<int>();
            string symbols = "!@#$%^&*()_+-=[];',.\\/~{}:|<>?";

            for (int i = 0; i < 10; i++)
            {
                streams.Add(random.Next(80));
            }

            Console.ForegroundColor = ConsoleColor.DarkGreen;

            while (true)
            {
                for (int x = 0; x < 80; x++)
                {
                    Console.Write(streams.Contains(x) ? symbols[random.Next(symbols.Length)] : ' ');
                }

                Console.WriteLine();
                Thread.Sleep(100);

                if (random.Next(3) == 0)
                {
                    streams.RemoveAt(random.Next(streams.Count)); 
                }
                if (random.Next(3) == 0)
                {
                    streams.Add(random.Next(80));
                }
            }
        }
    }
}