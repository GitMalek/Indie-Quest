using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metanoia_Tutorial
{
    internal partial class Program
    {
        static void OptionHandler(List<Option> options)
        {
            for (int i = 0; i < options.Count; i++)
            {
                Console.WriteLine($"{i + 1}. " + options[i].DisplayText);
            }

            int input = int.Parse(Console.ReadKey().KeyChar.ToString());

            options[input - 1].Run();

            Console.Clear();
        }

        static void ConnectLocations(Location a, Location b)
        {
            a.Neighbors.Add(b);
            b.Neighbors.Add(a);
        }

        static void CreateNeighborOptions(List<Option> options)
        {
            foreach (Location neighbor in gameState.CurrentLocation.Neighbors)
            {
                Option travelToNeighbor = new Option() { DisplayText = neighbor.Name, Run = () => gameState.CurrentLocation = neighbor };
                options.Add(travelToNeighbor);
            }
        }

        static void ReturnToMenu(Menu menu)
        {
            int menuIndex = gameState.CurrentMenus.IndexOf(menu);

            gameState.CurrentMenus.RemoveRange(menuIndex + 1, gameState.CurrentMenus.Count - menuIndex - 1);
        }
    }
}
