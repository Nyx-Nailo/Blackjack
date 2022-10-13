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
                        Game();
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
        static String Game()
        {
            List<int> player = new List<int>();
            List<int> bank = new List<int>();
            for(int i = 0; i < 2; i++)
            {
                player.Add(DealCard());
                bank.Add(DealCard());
            }
            bool draKort = true;
            while (draKort)
            {
                Console.WriteLine("Dra Kort");
                if (Bust(player))
                {
                    Console.WriteLine("Busted");
                    return "Banken vann!";
                }else if (TwentyOne(player))
                {
                    Console.WriteLine("victory");
                    return "Spelaren vann!";
                }
                else
                {
                    bool inputCheck = true;
                    while (inputCheck)
                    {
                        Console.WriteLine("Dra ett till kort? j/n");
                        switch (Console.ReadKey().Key)
                        {
                            case ConsoleKey.J:
                                player.Add(DealCard());
                                inputCheck = false;
                                break;
                            case ConsoleKey.N:
                                inputCheck = false;
                                draKort = false;
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            Console.WriteLine("End");

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