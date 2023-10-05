using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using static Westeros_Map.Program;

namespace Westeros_Map
{
    internal partial class Program
    {
        static GameState gameState;

        static void Main(string[] args)
        {


            Location winterfell = new Location() { Name = "Winterfell", Description = "the capital of the Kingdom of the North" };
            Location pyke = new Location() { Name = "Pyke", Description = "the stronghold and seat of House Greyjoy" };
            Location riverrun = new Location() { Name = "Riverrun", Description = "a large castle located in the central-western part of the Riverlands" };
            Location theTrident = new Location() { Name = "The Trident", Description = "one of the largest and most well-known rivers on the continent of Westeros" };
            Location highgarden = new Location() { Name = "Highgarden", Description = "the capital, and largest city, of the Seven Kingdoms" };
            Location kingsLanding = new Location() { Name = "King's Landing", Description = "the capital, and largest city, of the Seven Kingdoms" };


            connectLocations(winterfell, pyke);
            connectLocations(winterfell, riverrun);



            
 







            Menu travelMenu = new Menu()
            {
                Run = () =>
                {
                    Console.WriteLine($"You are in {gameState.CurrentLocation.Name}, {gameState.CurrentLocation.Description}. Where would you like to go next?");
                    Console.WriteLine();
                    List<Option> options = new List<Option>();

                    foreach (Location neighbor in gameState.CurrentLocation.Neighbors)
                    {
                        Option travelToNeighbor = new Option { DisplayText = neighbor.Name, Run = () => gameState.CurrentLocation = neighbor };
                        options.Add(travelToNeighbor);
                    }



                    for (int i = 0; i < options.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. " + options[i].DisplayText);
                    }

                    int input = int.Parse(Console.ReadKey().KeyChar.ToString());

                    options[input - 1].Run();

                    Console.Clear();
                }
            };


            gameState = new GameState() { CurrentLocation = winterfell };

            gameState.CurrentMenus.Add(travelMenu);


            while (true)
            {
                gameState.LastMenu.Run();
            }
        }

        static void connectLocations(Location a, Location b)
        {
            a.Neighbors.Add(b);
            b.Neighbors.Add(a);
        }


    }
}