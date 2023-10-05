using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Westeros_Map
{
    internal partial class Program
    {
        public class Menu
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
            public List<Location> Neighbors = new();
        }

        public class GameState
        {
            public Location CurrentLocation;
            public List<Menu> CurrentMenus;
            public Menu LastMenu => CurrentMenus[^1];
        }
    }
}
