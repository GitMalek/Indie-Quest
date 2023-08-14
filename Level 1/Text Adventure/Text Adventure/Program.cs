using System.Net.Quic;
using static System.Net.Mime.MediaTypeNames;

namespace Text_Adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrawFirstScreen();
            var input = Console.ReadKey().Key;

            while (input != ConsoleKey.Enter && input != ConsoleKey.Escape)
            {
                input = Console.ReadKey().Key;
            }
            if (input == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
            else if (input == Console.ReadKey().Key)
            {
                Console.Clear();
                int classChoice = ClassSelection();
            }
        }

        static void DrawFirstScreen()
        {

            Console.WriteLine("                 ________________          ___");
            Console.WriteLine("                / ___________  \\ \\        // /     ________________                                                                               ________________");
            Console.WriteLine("               / / /         \\  \\ \\      / / /    / _____________\\ \\                                                                             / _____________\\ \\   ____              ____");
            Console.WriteLine("              / / /           \\  | |    / / /    / / __________   \\ \\                                                 ____                      / / __________   \\ \\  \\ \\ \\            / / /                 _____");
            Console.WriteLine("             / / /             | | |   / / /    / / /          \\   | |     ________________________                  / /_/_____________        / / /          \\   | |  \\ \\ \\          / / /                 /    /");
            Console.WriteLine("            / / /              | | |  / / /    / / |            |  | |    / / /________________\\ \\ \\                / /______________/ /      / / |            |  | |   \\ \\ \\        / / /                 /____/    ____________");
            Console.WriteLine("           / / /              / / /  / / /    / /  |            |  | |   / / /\\                /\\ \\ \\              / / /____________/ /      / /  |            |  | |    \\ \\ \\      / / /                           / / _______  \\");
            Console.WriteLine("          / /_/______________/_/_/  / / /    / /   \\           /  / /   / / /\\ \\              / /\\ \\ \\            / / /          / / /      / /   \\           /  / /      \\ \\ \\    / / /                  ____     / / /     \\ \\  \\");
            Console.WriteLine("         / / /------------------   / / /    / / \\   \\_________/  / /   | | |  \\ \\            / / | | |           / / /          / / /      / / \\   \\_________/  / /        \\ \\ \\__/ / /                  / / /    / / /       \\ \\  \\");
            Console.WriteLine("        / / /                     / / /    / / /\\\\______________/_/    | | |   \\ \\          / /  | | |          / / /          / / /      / / /\\\\______________/_/          | |    | |                  / / /     | | |        \\ \\  \\");
            Console.WriteLine("       / / /                     / / /    / / / -----------------      | | |    \\ \\        / /   | | |         / / /          / / /      / / / -----------------           / / ___ \\ \\                 / / /       \\\\_\\         | | |");
            Console.WriteLine("      / / /                     / / /    / / /                         | | |     \\ \\      / /    | | |        / / /          / / /      / / /                             / / /   \\ \\ \\               / / /           __________| | |   ");
            Console.WriteLine("     / / /                     / / /     \\ \\ \\                         | | |      \\ \\_/\\_/ /     | | |       / / /          / / /       \\ \\ \\                            / / /     \\ \\ \\             / / /           / /   ___      |");
            Console.WriteLine("    / / /                     / / /       \\ \\ \\                        \\ \\ \\       \\/ /\\ \\/      / / /      / / /          / / /         \\ \\ \\                          / / /       \\ \\ \\           / / /           / /   /   \\     |");
            Console.WriteLine("   / / /                     / / /         \\ \\ \\                        \\ \\ \\______/ /\\/\\ \\_____/ / /      / / /          / / /           \\ \\ \\                        / / /         \\ \\ \\         / / /           | |    \\   /     |");
            Console.WriteLine("  / /_/                     / /_/           \\ \\_\\                        \\ \\ \\       \\  /      / / /      / /_/          / /_/             \\ \\_\\                      / /_/           \\_\\ \\       / /_/            | |     |_|      |");
            Console.WriteLine(" /_/                       /_/               \\_\\                          \\ \\ \\___/\\__\\/__/\\__/ / /      /_/            /_/                 \\_\\                      /_/                 \\_\\     /_/                \\_\\_____________/");
            Console.WriteLine("//                        //                  \\\\                           \\_\\_\\_____________/_/_/      //             //                    \\\\                     //                     \\\\   //                  ");

            for (int i = 0; i < 100; i++)
            {
                Console.Write(" ");
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("         ___________");
            Console.WriteLine();
            Console.Write(" ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            for (int i = 0; i < 100; i++)
            {
                Console.Write("_");
            }
            Console.Write("_______");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("//");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("____O____");
            Console.ForegroundColor= ConsoleColor.DarkYellow;
            Console.Write("\\\\");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("_______");
            for (int i = 0; i < 100; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine();
            Console.Write("{");
            for (int i = 0; i < 100; i++)
            {
                Console.Write("_");
            }
            Console.Write("______");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("||");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("__________");
            Console.ForegroundColor= ConsoleColor.DarkYellow;
            Console.Write("||");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("______");
            for (int i = 0; i < 100; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine("_}");
            Console.Write(" ]");
            for (int i = 0; i < 100; i++)
            {
                Console.Write(" ");
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("      \\\\        //       ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            for (int i = 0; i < 100; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("]");
            Console.Write("[");
            for (int i = 0; i < 100; i++)
            {
                Console.Write("_");
            }

            Console.Write("________");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\\\\");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("______");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("//");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("________");

            for (int i = 0; i < 100; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine("_]");
            for (int i = 0; i < 100; i++)
            {
                Console.Write(" ");
            }
            Console.Write("[__]      ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\\\\_/\\_//      ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("[__]");
            for (int i = 0; i < 100; i++)
            {
                Console.Write(" ");
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("           \\//\\\\/");
            for (int i = 0; i < 100; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("      _____//\\/\\\\_____");
            for (int i = 0; i < 100; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("      \\ /\\_ \\  / _/\\ /");
            for (int i = 0; i < 100; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("       \\\\/ \\/\\/\\/ \\//");
            for (int i = 0; i < 100; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("        \\\\_/    \\_//");
            for (int i = 0; i < 217; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("         \\ \\    / /");
            for (int i = 0; i < 100; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("          \\ \\  / / ");
            for (int i = 0; i < 100; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("           \\ \\/ / ");
            for (int i = 0; i < 100; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("            \\  / ");
            for (int i = 0; i < 100; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("             \\/");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < 75; i++)
            {
                Console.Write(" ");
            }


            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("What was it you were doing when you first heard the tip? Do you even remember?");
            for (int i = 0; i < 85; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("Does it matter...? The Lewran Agency was hiring, discreetly.");
            for (int i = 0; i < 70; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("You got in touch with a contact and informed them of your skills. You were hired on the spot.");
            for (int i = 0; i < 100; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("What did you have to offer?");

            Console.WriteLine();

            for (int i = 0; i < 90; i++)
            {
                Console.Write(" ");
            }

            Console.WriteLine("Press ENTER to continue, and ESCAPE to quit the game");
        }

        static int ClassSelection()
        {
            int classChoice = 0;



            return classChoice;
        }
    }
}