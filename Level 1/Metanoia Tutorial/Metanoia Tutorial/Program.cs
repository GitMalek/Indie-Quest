namespace Metanoia_Tutorial
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            gameState.CurrentMenus.Add(CharacterCreation);

            while (true)
            {
                gameState.LastMenu.Run();
            }
        }
    }
}