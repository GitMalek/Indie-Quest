using System.ComponentModel.Design;
using System.Reflection;

namespace Fundamentals___Methods_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part 1

            Console.WriteLine(Add(2, 3));

            Console.WriteLine(SafeDivision(4, 2));
            Console.WriteLine(SafeDivision(4, 0));

            Console.WriteLine(AreaOfCircle(4));

            Console.WriteLine(MaximumInteger(2, 8));

            List<int> intList = new List<int>() {3, 4, 2, 3};

            Console.WriteLine(AddIntegers(intList));

            Console.WriteLine(SmallestOfIntegers(intList));

            Console.WriteLine(string.Join(", ", SortIntegersDescending(intList)));

            Console.WriteLine(string.Join(", ", UniqueIntegers(intList)));

            List<int> secondIntList = new List<int>() {3, 9, 2};

            Console.WriteLine(string.Join(", ", JoinIntegers(intList, secondIntList)));

            Console.WriteLine(string.Join(", ", CreateRandomIntegers(10, 12, -3)));

            Console.WriteLine(Indent("Indent by 5", 5));

            List<string> firstNames = new List<string>() {"Lara", "Duke", "Sonic"};
            List<string> secondNames = new List<string>() { "Croft", "Nukem", "The Hedgehog" };

            List<string> zipNames = new List<string>() { "Mario", "Luigi", "Peach", "Bowser" };

            Console.WriteLine(string.Join(", ", CreateFullNames(firstNames, secondNames)));

            Console.WriteLine(string.Join(", ", ZipStrings(firstNames, zipNames)));

            List<string> commands = new List<string>() { "ADD", "DEL", "INC", "ADD", "JMP", "SUB", "DEC" };

            // Part 2

            Console.WriteLine("Add appears in the list " + CountStrings("ADD", commands) + " times.");

            Console.WriteLine(Power(4, 6));

            Console.WriteLine(Factorial(10));

            Console.WriteLine(Fibonacci(10));

            Console.WriteLine(string.Join(", ", CreateListOfDigits(12345)));

            Console.WriteLine(ConvertToBinary(10));

            List<int> ints = new List<int>() { -5, -2, 0, 3, 3, 7, 10 };

            Console.WriteLine(SmallestOfInts(ints));

            SelectionSort(ints);

            Console.WriteLine(string.Join(", ", ints));
        }

        // Part 1

        static int Add(int firstInt, int secondInt)
        {
            return firstInt + secondInt;
        }

        static int SafeDivision(int dividend,  int divisor)
        {
            if (divisor == 0)
            {
                return dividend;
            }
            else
            {
                return dividend / divisor;
            }
        }

        static double AreaOfCircle(double radius)
        {
            return (Math.PI * (radius * radius));
        }

        static int MaximumInteger(int firstInt, int secondInt)
        {
            if (secondInt < firstInt)
            {
                return firstInt;
            }
            else
            {
                return secondInt;
            }
        }

        static int AddIntegers(List<int> integers)
        {
            int result = 0;

            foreach (int i in integers)
            {
                result += i;
            }

            return result;
        }

        static int SmallestOfIntegers(List<int> integers)
        {
            integers.Sort();

            return integers[0];
        }

        static List<int> SortIntegersDescending(List<int> integers)
        {
            List<int> newList = new List<int>();
            integers.Sort();

            for (int i = integers.Count - 1; i >= 0; i--)
            {
                newList.Add(integers[i]);
            }

            return newList;
        }

        static List<int> UniqueIntegers(List<int> integers)
        {
            integers.Sort();
            List<int> uniqueList = new List<int>();

            for (int i = 0; i < uniqueList.Count; i++)
            {
                if (i > 0 && uniqueList[i] == uniqueList[i - 1])
                {
                    int nonUnique = integers[i];
                    while (uniqueList.Contains(nonUnique))
                    {
                        uniqueList.Remove(nonUnique);
                    }
                }
            }

            return uniqueList;
        }

        static List<int> JoinIntegers(List<int> firstIntegers, List<int> secondIntegers)
        {
            List<int> joinedIntegers = new List<int>();

            for (int i = 0; i < firstIntegers.Count; i++)
            {
                joinedIntegers.Add(firstIntegers[i]);
            }

            for (int i = 0; i < secondIntegers.Count; i++)
            {
                joinedIntegers.Add(secondIntegers[i]);
            }

            return joinedIntegers;
        }

        static List<int> CreateRandomIntegers(int count, int maximum, int minimum)
        {
            var random = new Random();
            List<int> randomIntegers = new List<int>();

            for (int i = 0; i < count; i++)
            {
                randomIntegers.Add(random.Next(minimum, maximum + 1));
            }

            return randomIntegers;
        }

        static string Indent(string text, int count)
        {
            string indented = string.Empty;

            for (int i = 0; i < count; i++)
            {
                indented += " ";
            }

            indented += text;

            return indented;
        }

        static List<string> CreateFullNames(List<string> firstNames, List<string> secondNames)
        {
            List<string> fullNames = new List<string>();

            for (int i = 0; i < firstNames.Count; i++)
            {
                fullNames.Add(firstNames[i] + " " + secondNames[i]);
            }

            return fullNames;
        }

        static List<string> ZipStrings(List<string> firstStrings, List<string> secondStrings)
        {
            List<string> zippedStrings = new List<string>();
            int largerCount = 0;

            if (firstStrings.Count > secondStrings.Count)
            {
                largerCount = firstStrings.Count;
            }
            else
            {
                largerCount = secondStrings.Count;
            }

            for (int i = 0; i < largerCount; i++)
            {
                if (i < firstStrings.Count)
                {
                    zippedStrings.Add(firstStrings[i]);
                }

                if (i < secondStrings.Count)
                {
                    zippedStrings.Add(secondStrings[i]);
                }
            }

            return zippedStrings;
        }

        static int CountStrings(string searchValue, List<string> strings)
        {
            int count = 0;

            while (strings.Contains(searchValue))
            {
                count++;
                strings.Remove(searchValue);
            }

            return count;
        }

        // Part 2

        static int Power(int a, int b)
        {
            if (b > 1)
            {
                return a * Power(a, b - 1);
            }
            else
            {
                return a;
            }
        }

        static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        static int Fibonacci(int n)
        {
            if (n == 1)
            {
                return 0;
            }
            else if (n == 2)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

        static List<int> CreateListOfDigits(int number)
        {
            List<int> digits = new List<int>();

            if (number < 10)
            {
                return new List<int> { number }; 
            }
            else
            {
                digits = CreateListOfDigits(number / 10);
                digits.Add(number % 10);
                return digits;
            }
        }
        
        static string ConvertToBinary(int integer)
        {
            if (integer <= 1)
            {
                return Convert.ToString(integer);
            }
            else
            {
                return ConvertToBinary(integer / 2) + integer % 2;
            }
        }

        static int SmallestOfInts(List<int> integers)
        {
            if (integers.Count == 1)
            {
                return integers[0];
            }
            else
            {
                int middle = integers.Count / 2;
                int minLeft = SmallestOfInts(integers.GetRange(0, middle));
                int minRight = SmallestOfInts(integers.GetRange(middle, integers.Count - middle));
                return Math.Min(minLeft, minRight);
            }
        }

        static void SelectionSort(List<int> integers)
        {
            if (integers.Count <= 1) return;

            int smallest = SmallestOfIntegers(integers);
            integers.Remove(smallest);
            SelectionSort(integers);
            integers.Insert(0, smallest);
        }
    }
}