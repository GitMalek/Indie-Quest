using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using static Westeros_Map.Program;

namespace Westeros_Map
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Location winterfell = new Location() { Name = "Winterfell", Description = "the capital of the Kingdom of the North" };
            Location pyke = new Location() { Name = "Pyke", Description = "the stronghold and seat of House Greyjoy" };
            Location riverrun = new Location() { Name = "Riverrun", Description = "a large castle located in the central-western part of the Riverlands" };
            Location theTrident = new Location() { Name = "The Trident", Description = "one of the largest and most well-known rivers on the continent of Westeros" };
            Location highgarden = new Location() { Name = "Highgarden", Description = "the capital, and largest city, of the Seven Kingdoms" };
            Location kingsLanding = new Location() { Name = "King's Landing", Description = "the capital, and largest city, of the Seven Kingdoms" };

            GameState gameState = new GameState() { CurrentLocation = winterfell };

            Option travelToWinterfell = new Option { DisplayText = winterfell.Name, Run = () => gameState.CurrentLocation = winterfell };
            Option travelToPyke = new Option { DisplayText = pyke.Name, Run = () => gameState.CurrentLocation = pyke };
            Option travelToRiverrun = new Option { DisplayText = riverrun.Name, Run = () => gameState.CurrentLocation = riverrun };
            Option travelToTheTrident = new Option { DisplayText = theTrident.Name, Run = () => gameState.CurrentLocation = theTrident };
            Option travelToKingsLanding = new Option { DisplayText = kingsLanding.Name, Run = () => gameState.CurrentLocation = kingsLanding };
            Option travelToHighgarden = new Option { DisplayText = highgarden.Name, Run = () => gameState.CurrentLocation = highgarden };

            

            winterfell.Options = new List<Option> { travelToPyke, travelToTheTrident };
            pyke.Options = new List<Option> { travelToWinterfell, travelToRiverrun, travelToHighgarden };
            theTrident.Options = new List<Option> { travelToWinterfell, travelToRiverrun, travelToKingsLanding };
            riverrun.Options = new List<Option> { travelToPyke, travelToTheTrident, travelToHighgarden, travelToKingsLanding };
            highgarden.Options = new List<Option> { travelToPyke, travelToRiverrun, travelToKingsLanding };
            kingsLanding.Options = new List<Option> { travelToTheTrident, travelToRiverrun, travelToHighgarden };

            while(true)
            {
                TravelMenu travelMenu = new TravelMenu()
                {
                    Run = () =>
                    {
                        Console.WriteLine($"You are in {gameState.CurrentLocation.Name}, {gameState.CurrentLocation.Description}. Where would you like to go next?");
                        Console.WriteLine();

                        for (int i = 0; i < gameState.CurrentLocation.Options.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. " + gameState.CurrentLocation.Options[i].DisplayText);
                        }

                        int input = int.Parse(Console.ReadKey().KeyChar.ToString());

                        gameState.CurrentLocation.Options[input - 1].Run();

                        Console.Clear();
                    }
                };

                travelMenu.Run();
            }
        }

        

        public class TravelMenu
        {
            public Action Run;
        }

        public class Option
        {
            public string DisplayText;
            public Action Run;
        }

        public class Location
        {
            public string Name;
            public string Description;
            public List<Option> Options = new();
        }

        public class GameState
        {
            public Location CurrentLocation;
        }
    }
}