using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metanoia_Tutorial
{
    internal partial class Program
    {
        static Option back = new Option()
        {
            DisplayText = "Back",
            Run = () =>
            {
                gameState.CurrentMenus.Remove(gameState.LastMenu);
            }
        };
        
    }
}
