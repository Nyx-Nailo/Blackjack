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
                choice = Console.ReadKey().Key;
                switch (choice)
                {
                    case ConsoleKey.D1: // Start game
                        break;
                    case ConsoleKey.D2: // Show previous winner
                        break;
                    case ConsoleKey.D3: //show rules?
                        break;
                    case ConsoleKey.D4: //Exit;
                        quit = true;
                        break;
                }
            }
        }
        static String Game()
        {
            List<int> player = new List<int>();
            List<int> bank = new List<int>();

            return "player";
        }
        static int DealCard(int i = 10)
        {
            Random range = new Random();
            int card = range.Next(i + 1);
            return card;
        }
        static bool Bust(List<int> player)
        {
            if (player.Sum() <= 21)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static bool TwentyOne(List<int> player)
        {
            if (player.Sum() == 21)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}