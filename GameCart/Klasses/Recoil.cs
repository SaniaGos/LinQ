using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCart.Klasses
{
    class Recoil
    {
        public List<Card> Cards { get; private set; }
        public Recoil()
        {
            Cards = new List<Card>();
        }
        public void Add(Card card)
        {
            if (card != null)
                Cards.Add(card);
        }
        public void AddRange(List<Card> cards)
        {
            if (cards != null)
                foreach (Card item in cards)
                {
                    Cards.Add(item);
                }
        }
    }
}
