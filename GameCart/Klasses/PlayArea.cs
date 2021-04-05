using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCart.Klasses
{
    class PlayArea
    {
        public List<Card> Cards { get; set; }
        public PlayArea()
        {
            Cards = new List<Card>();
        }
        public void PutCard(Card card)
        {
            Cards.Add(card);
        }
        public int MaxCard()
        {
            int max = 0;
            for (int i = 1; i < Cards.Count; i++)
            {
                if (Cards[i] > Cards[max]) max = i;
            }
            return max;
        }
    }
}
