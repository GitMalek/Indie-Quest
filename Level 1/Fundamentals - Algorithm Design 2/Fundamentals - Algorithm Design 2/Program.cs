namespace Fundamentals___Algorithm_Design_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            List<string> participants = new List<string>() { "Allie", "Ben", "Claire", "Dan", "Eleanor"};

            Console.WriteLine("Signed-up participants: " + string.Join(", ", participants));

            Console.WriteLine();

            Console.WriteLine("Generating starting order...");

            Console.WriteLine();

            ShuffleList(participants);

            Console.WriteLine("Starting order: " + string.Join(", ", participants)); */

            /*
            int[] testFactorials = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            foreach (int factorial in testFactorials)
            {
                Console.WriteLine($"{factorial}! = " + Factorial(factorial));
            } */

            List<string> participants = new List<string>() { "Allie", "Ben", "Claire" };

            Console.WriteLine("Signed-up participants: " + string.Join(", ", participants));

            Console.WriteLine();

            Console.WriteLine("Starting orders:");

            List<string> permuations = WriteAllPermutations(participants);

            for (int i = 0; i < permuations.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {permuations[i]}");
            }

        }

        static void ShuffleList(List<string> items)
        {
            var random = new Random();

            for (int i = 0; i < items.Count - 2; i++)
            {
                int j = random.Next(i, items.Count);

                string nameHolder = items[i];
                items[i] = items[j];
                items[j] = nameHolder;
            }
        }

        static int Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }

        static List<string> WriteAllPermutations(List<string> items)
        {
            List<string> permutations = new List<string>();

            if (items.Count == 2)
            {
                permutations.Add($"{items[0]}, {items[1]}");
                permutations.Add($"{items[1]}, {items[0]}");
                return permutations;
            }

            for (int i = 0; i < Factorial(items.Count); i++)
            {
                bool match = false;
                while (!match)
                {
                    ShuffleList(items);

                    if (i == 0)
                    {
                        permutations.Add(string.Join(", ", items));
                        match = true;
                    }
                    else if (!permutations.Contains(string.Join(", ", items)))
                    {
                        permutations.Add(string.Join(", ", items));
                        match = true;
                    }
                }
            }
            return permutations;
        }
    }
}