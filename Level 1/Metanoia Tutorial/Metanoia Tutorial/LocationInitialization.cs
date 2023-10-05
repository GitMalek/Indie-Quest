using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metanoia_Tutorial
{
    internal partial class Program
    {
        Location camp = new Location()
        {
            Name = "Camp",
            Description = "Your wagon's stopped here. You're surrounded by the forest's trees for cover- and plenty of sturdy ruin walls dot the area.",
            Neighbors = new List<Location>() { }
        };
    }
}
