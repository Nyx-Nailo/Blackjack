using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class Meny
    {
        public static ConsoleKey BlackjackMeny()
        {
            Console.Write("Welcome to 21. The ultimate experience.\n\n1 - Start the game\n2 - Last victorious contestant\n3 - Rules\n4 - Terminate\n");

            return Console.ReadKey().Key;
            
        }

        public static void Rules() 
        {
            Console.Write("\nI 21:an kommer du att spela mot datorn och försöka tvinga datorn att få över 21 poäng. Både du och\ndatorn får poäng genom att dra kort, varje kort är värt 1 – 10 poäng.När spelet börjar dras två kort till\nbåde dig och datorn.Därefter får du dra hur många kort som du vill tills du är nöjd med din\ntotalpoäng, du vill komma så nära 21 som möjligt utan att få mer än 21 poäng.När du inte vill dra fler\nkort så kommer datorn att dra kort tills den har mer eller lika många poäng som dig.\nDu vinner om datorn får mer än totalt 21 poäng när den håller på att dra kort.Datorn vinner om den\nhar mer poäng än dig när spelet är slut så länge som datorn inte har mer än 21 poäng.Om det skulle\nbli lika i poäng så vinner datorn.Om du får mer än 21 poäng när du drar kort så har du förlorat.\nVi kommer att bygga 21:an som ett menyprogram så att användaren får möjlighet att spela så många\ngånger hen vill utan att behöva starta om programmet.Innan vi sätter igång och kollar på hur man\nkan generera slumptal så kan du här se en körning av programmet där användaren spelar 21:an en\ngång och vinner mot datorn.\n\n");
            Console.ReadKey();
        }

        public static void LastContestant(string name)
        {
            Console.Write($"\n\nThe last contestant was {name}\n\n");
            Console.ReadKey();
        }

    }
}
