namespace Fundamentals___Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BasiliskSim();
        }

        static void GenerateAbilityScores()
        {
            var random = new Random();
            List<int> statRoll = new List<int>();
            List<int> allStats = new List<int>();

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 4;  j++)
                {
                    statRoll.Add(random.Next(1, 7));
                }
                statRoll.Sort();

                allStats.Add(statRoll[1] + statRoll[2] + statRoll[3]);

                Console.WriteLine("You rolled " + string.Join(", ", statRoll) + $". The ability score is {allStats[i]}");

                statRoll.Clear();
            }

            allStats.Sort();

            Console.WriteLine("Your ability scores are " + string.Join(", ", allStats) + ".");
        }

        static void BasiliskSim()
        {
            var random = new Random();
            List<string> partyNames = new List<string>();

            partyNames.Add("Jazlyn");
            partyNames.Add("Theron");
            partyNames.Add("Dayana");
            partyNames.Add("Rolando");

            int basiliskHp = 16;

            for (int i = 0; i < 8; i++)
            {
                basiliskHp += random.Next(1, 9);
            }

            Console.WriteLine($"A basilisk with {basiliskHp} appears!");

            while (basiliskHp > 0)
            {
                for (int i = 0; i < partyNames.Count; i++)
                {
                    int damage = random.Next(1, 5);

                    basiliskHp -= damage;

                    if (basiliskHp < 0)
                    {
                        basiliskHp = 0;
                        Console.WriteLine($"{partyNames[i]} hits the basilisk for {damage} damage. Basilisk has {basiliskHp} HP left.");
                        break;
                    }
                    Console.WriteLine($"{partyNames[i]} hits the basilisk for {damage} damage. Basilisk has {basiliskHp} HP left.");
                }

                int target = random.Next(partyNames.Count);

                Console.WriteLine($"The basilisk uses its petrifying gaze on {partyNames[target]}!");

                int constitutionSave = random.Next(1, 21) + 3;

                if (constitutionSave < 12)
                {
                    Console.WriteLine($"{partyNames[target]} rolls a {constitutionSave} and fails to be saved. {partyNames[target]} is turned into stone.");
                    partyNames.RemoveAt(target);
                }
                else
                {
                    Console.WriteLine($"{partyNames[target]} rolls a {constitutionSave} and is saved from the attack.");
                }

                if (partyNames.Count == 0)
                {
                    break;
                }

            }

            if (partyNames.Count == 0)
            {
                Console.WriteLine("The party has failed and the basilisk continues to turn unsuspecting adventurers to stone.");
            }
            else if (basiliskHp == 0)
            {
                Console.WriteLine("The basilisk collapses and the heroes celebrate their victory!");
            }
        }
    }
}