namespace Fundamentals___Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<string> characterNames = new List<string>();
            characterNames.Add("Jazlyn");
            characterNames.Add("Theron");
            characterNames.Add("Dayana");
            characterNames.Add("Rolando");

            int orcHP = DiceRollSimulator(2, 8, 6);
            int orcDC = 10;

            int azerHP = DiceRollSimulator(6, 8, 12);
            int azerDC = 18;

            int trollHP = DiceRollSimulator(8, 10, 40);
            int trollDC = 16;

            SimulateCombat(characterNames, "troll", trollHP, trollDC);

        }

        static int DiceRollSimulator(int numberOfRolls, int diceSides, int fixedBonus = 0)
        {
            var random = new Random();
            int result = 0;

            for (int i = 0; i < numberOfRolls; i++)
            {
                result += random.Next(1, diceSides + 1);
            }

            result += fixedBonus;

            return result;
        }

        static void SimulateCombat(List<string> characterNames, string monsterName, int monsterHP, int savingThrowDC)
        {
            var random = new Random();;

            Console.WriteLine($"A {monsterName} with {monsterHP} appears!");

            while (monsterHP > 0)
            {
                for (int i = 0; i < characterNames.Count; i++)
                {
                    int damage = DiceRollSimulator(2, 6);

                    monsterHP -= damage;

                    if (monsterHP < 0)
                    {
                        monsterHP = 0;
                        Console.WriteLine($"{characterNames[i]} hits the {monsterName} for {damage} damage. The {monsterHP} has {monsterHP} HP left.");
                        break;
                    }
                    Console.WriteLine($"{characterNames[i]} hits the basilisk for {damage} damage. {monsterName} has {monsterHP} HP left.");
                }

                if (monsterHP == 0)
                {
                    break;
                }

                int target = random.Next(characterNames.Count);

                Console.WriteLine($"The {monsterName} uses its petrifying gaze on {characterNames[target]}!");

                int constitutionSave = DiceRollSimulator(1, 20, 3);

                if (constitutionSave < savingThrowDC)
                {
                    Console.WriteLine($"{characterNames[target]} rolls a {constitutionSave} and fails to be saved. {characterNames[target]} is knocked out.");
                    characterNames.RemoveAt(target);
                }
                else
                {
                    Console.WriteLine($"{characterNames[target]} rolls a {constitutionSave} and is saved from the attack.");
                }

                if (characterNames.Count == 0)
                {
                    break;
                }

            }

            if (characterNames.Count == 0)
            {
                Console.WriteLine($"The party has failed and the {monsterName} roams free.");
            }
            else if (monsterHP == 0)
            {
                Console.WriteLine($"The {monsterName} collapses and the heroes celebrate their victory!");
            }
        }
    }
}