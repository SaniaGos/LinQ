using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCart.Klasses
{
    enum Suit
    {
        Heard, Diamond, Club, Spade
    }
    enum SizeCard
    {
        Six = 6, Seven, Eight, Nine, Ten, Jack, Queen, King, Ase
    }
    class Card
    {
        public Suit Suit { get; }
        public SizeCard SizeCard { get; private set; }
        public Card(SizeCard sizeCard, Suit suit)
        {
            SizeCard = sizeCard;
            Suit = suit;
        }
        public static bool operator >(Card first, Card second)
        {
            if (first.SizeCard > second.SizeCard)
                return true;
            else if (first.SizeCard == second.SizeCard)
                return first.Suit > second.Suit;
            else return false;
        }
        public static bool operator <(Card first, Card second)
        {
            return !(first > second);
        }
    }
}
