using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class GameSystem
    {
        public static String Game()
        {
            List<int> player = new List<int>();
            List<int> bank = new List<int>();
            for (int i = 0; i < 2; i++)
            {
                player.Add(DealCard());
                bank.Add(DealCard());
            }
            Console.WriteLine("Banken har: " + bank.Sum());
            bool draKort = true;
            while (draKort)
            {
                Console.WriteLine("Du har: " + player.Sum());
                if (Bust(player))
                {
                    Console.WriteLine("Busted");
                    return "Banken";
                }
                /*else if (TwentyOne(player))
                {
                    Console.WriteLine("victory");
                    return "Spelaren vann!";
                }*/
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
            do
            {
                if (Bust(bank))
                {
                    return "Spelaren";
                }else if(bank.Sum() >= player.Sum())
                {
                    return "Banken";
                }
            } while (AI(bank));

            if(bank.Sum() >= player.Sum())
            {
                return "Banken";
            }
            else
            {
                return "Spelaren";
            }
        }
        static int DealCard(int i = 10)
        {
            Random range = new Random();
            int card = range.Next(1, i + 1);
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
        static bool AI(List<int> bank)
        {
            return false;
        }
    }
}
