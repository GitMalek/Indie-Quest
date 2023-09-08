using System.ComponentModel.Design;
using System.Text.Json.Serialization;

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

            
            List<string> participants = new List<string>() { "A", "B", "C", "D", "E"};

            Console.WriteLine("Signed-up participants: " + string.Join(", ", participants));

            Console.WriteLine();

            Console.WriteLine("Starting orders:");

            List<string> permutations = WriteRecursionPermutations(participants);
            /*    
            WriteHeapsPermutations(participants.Count, participants, permutations); */

            for (int i = 0; i < permutations.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {permutations[i]}");
            }
        }

        static void ShuffleList(List<string> items)
        {
            var random = new Random();
            for (int i = 0; i < items.Count - 1; i++)
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

        static void WriteHeapsPermutations(int k,  List<string> items, List<string> results)
        {
            if (k == 1)
            {
                results.Add(string.Join(", ", items));
                return;
            }

            WriteHeapsPermutations(k - 1, items, results);

            for (int i = 0; i < k - 1; i++)
            {
                if (k % 2 == 0)
                {
                    (items[i], items[k - 1]) = (items[k - 1], items[i]);
                }
                else
                {
                    (items[0], items[k - 1]) = (items[k - 1], items[0]);
                }
                WriteHeapsPermutations(k - 1, items, results);
            }
        }

        static List<string> WriteRecursionPermutations(List<string> items)
        {
            List<string> results = new();
            List<string> pickedItems = new();

            void WriteRecursionPermutations()
            {
                if (items.Count == 0)
                {
                    results.Add(string.Join(", ", pickedItems));
                    return;
                }

                for (int remainingItemIndex = 0; remainingItemIndex < items.Count; remainingItemIndex++)
                {
                    string pickedItem = items[remainingItemIndex];
                    items.RemoveAt(remainingItemIndex);
                    pickedItems.Add(pickedItem);

                    WriteRecursionPermutations();

                    items.Insert(remainingItemIndex, pickedItem);
                    pickedItems.RemoveAt(pickedItems.Count - 1);
                }
            }

            WriteRecursionPermutations();

            return results;
        }
        
    }
}
