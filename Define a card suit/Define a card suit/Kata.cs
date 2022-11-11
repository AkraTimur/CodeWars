using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Define_a_card_suit
{
    public class Kata
    {
        public static string DefineSuit(string card)
        {
            if(card.Contains("♦")) return "diamonds";
            if(card.Contains("♥")) return "hearts";
            if (card.Contains("♠")) return "spades";

            return "clubs";
        }
    }
}
