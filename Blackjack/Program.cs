using System.Globalization;

namespace Blackjack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String lastWinner = "Play a game first muppet!";
            bool quit = false;
            ConsoleKey choice;
            while (!quit)
            {
                //Menu goes here!

                choice = Meny.BlackjackMeny();
                switch (choice)
                {
                    case ConsoleKey.D1: // Start game
                        lastWinner = GameSystem.Game();
                        Console.WriteLine(lastWinner + " vann.");
                        break;
                    case ConsoleKey.D2: // Show previous winner
                        Meny.LastContestant(lastWinner);
                        break;
                    case ConsoleKey.D3: //show rules?
                        Meny.Rules();
                        break;
                    case ConsoleKey.D4: //Exit;
                        quit = true;
                        break;
                }
            }
        }
    }
}