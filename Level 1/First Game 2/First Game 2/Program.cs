namespace First_Game_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParsecConversion();
        }

        static void DiceRollGame()
        {
            var random = new Random();

            int randomInteger = random.Next(1, 7);
            int randomInteger2 = random.Next(1, 7);
            int randomInteger3 = random.Next(1, 7);

            int finalScore = 2 * (randomInteger + randomInteger2 + (3 * randomInteger3));

            Console.WriteLine($"Rolls: {randomInteger}, {randomInteger2}, {randomInteger3}");

            Console.WriteLine($"Your score is: {finalScore}");
        }

        static void BowlingGame()
        {
            var random = new Random();

            int firstRoll = random.Next(11);
            int secondRoll = random.Next(11 - firstRoll);

            int knockedPins = firstRoll + secondRoll;

            Console.WriteLine($"First roll: {firstRoll}");
            Console.WriteLine($"Second roll: {secondRoll}");
            Console.WriteLine($"Knocked pins: {knockedPins}");
        }

        static void HitAccuracy()
        {
            var random = new Random();
            int shots = random.Next(10, 21);
            int hits = random.Next(shots);
            double accuracy = ((double) hits / (double)shots) * 100;

            Console.WriteLine($"You fired {shots} shots");
            Console.WriteLine($"You hit the target {hits} times");

            Console.WriteLine($"Your accuracy is {accuracy}%");
            Console.WriteLine();
        }

        static void ParsecConversion()
        {
            double lightyears = 4.365;
            double parsecs = lightyears / 3.26;

            Console.WriteLine($"Alpha Centauri is {lightyears} lightyears away, or {parsecs} parsecs.");
        }
    }
}