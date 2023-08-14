using System;

namespace First_Game_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GelatinousCubeSimulation();
        }
        static void BowlingGame()
        {
            var random = new Random();

            int firstRoll = random.Next(11);
            int secondRoll = random.Next(11 - firstRoll);

            int knockedPins = firstRoll + secondRoll;

            if (firstRoll == 10)
            {
                Console.WriteLine($"First roll: X");
            }
            else if (firstRoll == 0)
            {
                Console.WriteLine("First roll: -");
            }
            else
            {
                Console.WriteLine($"First roll: {firstRoll}");
            }

            if (knockedPins == 10 && firstRoll != 10)
            {
                Console.WriteLine("Second roll: /");
            }
            else if (secondRoll == 0 && firstRoll != 10)
            {
                Console.WriteLine("Second roll: -");
            }
            else if (firstRoll != 10)
            {
                Console.WriteLine($"Second roll: {secondRoll}");
            }

            Console.WriteLine($"Knocked pins: {knockedPins}");
        }

        static void RegenerateSpell()
        {
            var random = new Random();
            int warriorHp = random.Next(101);

            Console.WriteLine($"Warrior HP: {warriorHp}");

            if (warriorHp < 50)
            {
                Console.WriteLine("The regeneration spell is cast!");

                while (warriorHp < 50)
                {
                    warriorHp += 10;
                    Console.WriteLine($"Warrior HP: {warriorHp}");
                }

                Console.WriteLine($"The regeneration spell is complete! The warrior has {warriorHp} health points.");
            }
        }

        static void RollTillSix()
        {
            var random = new Random();

            int roll = random.Next(1, 7);
            int score = roll;

            while (roll != 6)
            {
                Console.WriteLine($"Your roll: {roll}");
                roll = random.Next(1, 7);
                score += roll;
            }

            Console.WriteLine($"Your roll: {roll}");
            Console.WriteLine($"Your score is: {score}");
        }

        static void GelatinousCubeSimulation()
        {
            var random = new Random();
            int strength = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);

            int cubeHealth = GelatinousCubeSpawn();

            int cubeArmy = 0;

            for (int i = 0;  i < 100; i++)
            {
                cubeArmy += GelatinousCubeSpawn();
            }

            Console.WriteLine($"A character with {strength} strength was created.");
            Console.WriteLine($"A gelatinous cube with {cubeHealth} HP appears!");
            Console.WriteLine($"Dear gods, an army of 100 cubes descends upon us with a total of {cubeArmy} HP. We are doomed!");
        }

        static int GelatinousCubeSpawn()
        {
            var random = new Random();
            int cubeHealth = 0;

            for (int i = 0; i < 10; i++)
            {
                cubeHealth += random.Next(1, 11);
            }

            cubeHealth += 40;

            return cubeHealth;
        }
    }
}