namespace Fundamentals___Lists_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            // Part 1
            // 1.
            Console.WriteLine("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            // 2.
            List<int> randomIntegers = new List<int>();
            
            for (int i = 0; i < n; i++)
            {
                randomIntegers.Add(random.Next(99));
            }

            Console.WriteLine("Numbers are: " + string.Join(", ", randomIntegers));

            Console.WriteLine();

            // 3.
            int total = 0;

            foreach (int i in randomIntegers)
            {
                total += i;
            }

            Console.WriteLine($"The sum of the numbers is: {total}");

            Console.WriteLine();

            // 4.
            double average = (double)total / n;

            Console.WriteLine($"The average of the numbers is: {average}");

            Console.WriteLine();

            // 5.
            long product = 1;

            for (int i = 0; i < 10; i++)
            {
                product *= randomIntegers[i];
            }

            Console.WriteLine($"The product of the first 10 numbers is: {product}");

            Console.WriteLine();

            // 6.
            randomIntegers.Sort();

            Console.WriteLine($"Sorted numbers are: " + string.Join(", ", randomIntegers));

            Console.WriteLine();

            // 7.
            List<int> evenIntegers = new List<int>();

            for (int i = 0; i < randomIntegers.Count; i++)
            {
                if (randomIntegers[i] % 2 == 0)
                {
                    evenIntegers.Add(randomIntegers[i]);
                }
            }

            Console.WriteLine("Even numbers are: " + string.Join(", ", evenIntegers));

            Console.WriteLine();

            // 8.
            List<int> largestIntegers = new List<int>();

            for (int i  = randomIntegers.Count - 10; i < randomIntegers.Count; i++)
            {
                largestIntegers.Add(randomIntegers[i]);
            }

            Console.WriteLine("Largest 10 numbers are: " + string.Join(", ", largestIntegers));

            Console.WriteLine();

            // 9.
            List<int> largestUniqueIntegers = new List<int>();
            int index = n - 1;

            while (largestUniqueIntegers.Count < 10 && index >= 0)
            {
                if (index == n - 1)
                {
                    if (randomIntegers[index - 1] != randomIntegers[index])
                    {
                        largestUniqueIntegers.Add(randomIntegers[index]);
                    }
                }
                else if (index != 0)
                {
                    if (randomIntegers[index + 1] != randomIntegers[index] && randomIntegers[index - 1] != randomIntegers[index])
                    {
                        largestUniqueIntegers.Add(randomIntegers[index]);
                    }
                }
                else if (randomIntegers[index] != randomIntegers[index + 1])
                {
                    largestUniqueIntegers.Add(randomIntegers[index]);
                }
                index--;
            }

            Console.WriteLine("Largest 10 unique numbers are: " + string.Join(", ", largestUniqueIntegers));

            Console.WriteLine();

            // 10.
            int uniqueIntegerTotal = 0;

            for (int i = n - 1; i >= 0; i--)
            {
                if (i == n - 1)
                {
                    if (randomIntegers[i - 1] != randomIntegers[i])
                    {
                        uniqueIntegerTotal++;
                    }
                }
                else if (i != 0)
                {
                    if (randomIntegers[i + 1] != randomIntegers[i] && randomIntegers[i - 1] != randomIntegers[i])
                    {
                        uniqueIntegerTotal++;
                    }
                }
                else if (randomIntegers[i] != randomIntegers[i + 1])
                {
                    uniqueIntegerTotal++;
                }
            }

            Console.WriteLine($"There are {uniqueIntegerTotal} unique numbers.");

            Console.WriteLine();

            // 11.
            List<int> missingIntegers = new List<int>();

            for (int i = 0; i <= 99; i++)
            {
                if (!randomIntegers.Contains(i))
                {
                    missingIntegers.Add(i);
                }
            }

            Console.WriteLine($"The missing numbers are: " + string.Join(", ", missingIntegers));

            Console.WriteLine();

            // 12.
            int[] histogram = new int[10];

            for (int i = 0; i < randomIntegers.Count; i++)
            {
                int barMarker = randomIntegers[i] / 10;

                histogram[barMarker]++;
            }

            Console.WriteLine("Histogram:");

            for (int y = 0; y < histogram.Length; y++)
            {
                if (y == 0)
                {
                    Console.Write("  ");
                }
                Console.Write($"{0 + (y * 10)} - {((y + 1) * 10) - 1}: ");
                for (int x = 0; x < histogram[y]; x++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // Part 2
            // 1.
            List<string> names = new List<string>() { "Allie", "Ben", "Claire", "Dan", "Eleanor"};

            Console.WriteLine(string.Join(", ", names));

            Console.WriteLine();

            // 2.
            names[0] = "Duke";

            Console.WriteLine(string.Join(", ", names));

            Console.WriteLine();

            // 3.
            names[3] = "Lara";

            Console.WriteLine(string.Join(", ", names));

            Console.WriteLine();

            // 4.
            names[names.Count - 1] = "Aaron";

            Console.WriteLine(string.Join(", ", names));

            Console.WriteLine();

            // 5.
            names.Sort();

            Console.WriteLine(string.Join(", ", names));

            Console.WriteLine();

            // 6.
            names.Reverse();

            Console.WriteLine(string.Join(", ", names));

            Console.WriteLine();

            // 7.
            Console.WriteLine(names.Contains("Duke"));

            Console.WriteLine();

            // 8.
            Console.WriteLine(names.IndexOf("Aaron"));

            Console.WriteLine();

            // 9. 
            names.Insert(0, "Mario");

            Console.WriteLine(string.Join(", ", names));

            Console.WriteLine();

            // 10.
            names.Insert(names.Count / 2, "Luigi");

            Console.WriteLine(string.Join(", ", names));

            Console.WriteLine();

            // 11.
            for (int i = 0; i < names.Count; i += 2)
            {
                names.Insert(i + 1, names[i]);
            }

            Console.WriteLine(string.Join(", ", names));

            Console.WriteLine();

            // 12.
            string nameHolder = names[0];
            names[0] = names[names.Count - 1];
            names[names.Count - 1] = nameHolder;

            Console.WriteLine(string.Join(", ", names));

            Console.WriteLine();

            // 13.
            names.RemoveAt(4);

            Console.WriteLine(string.Join(", ", names));

            Console.WriteLine();

            // 14.
            names.Remove("Mario");

            Console.WriteLine(string.Join(", ", names));

            Console.WriteLine();

            // 15. 
            Console.WriteLine(names.LastIndexOf("Claire"));

            Console.WriteLine();

            // 16.
            names.RemoveAt(names.LastIndexOf("Aaron"));

            Console.WriteLine(string.Join(", ", names));

            Console.WriteLine();

            // 17.
            for (int i = names.Count - 2; i >= 0; i--)
            {
                if (names[i] == names[i + 1])
                {
                    names.RemoveAt(i + 1);
                    names.RemoveAt(i);
                }
            }

            Console.WriteLine(string.Join(", ", names));

            Console.WriteLine();

            // 18.
            names.Clear();

            Console.WriteLine(string.Join(", ", names));

            Console.WriteLine();
        }
    }
}