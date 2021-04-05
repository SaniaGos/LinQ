using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCart.Klasses
{
    class Player
    {
        public List<Card> Cards { get; set; }
        public Recoil Recoil { get; private set; }
        public int Point { get; private set; }
        public Player()
        {
            Cards = new List<Card>();
            Recoil = new Recoil();
            Point = 0;
        }
        public void GetCard(DeskOfCards deskOfCards)
        {
            Cards.Add(deskOfCards.GetCard());
        }
        public Card PutCard()
        {
            if (Cards.Count != 0)
            {
                Card outCard = Cards[0];
                Cards.RemoveAt(0);
                return outCard;
            }
            else throw new Exception("The cards are over");
        }
        public void AddRecoilRange(List<Card> cards)
        {
            CountPoint(cards);
            Recoil.AddRange(cards);
        }
        public void CountPoint(List<Card> cards)
        {
            foreach (Card item in cards)
            {
                Point += Convert.ToInt32(item.SizeCard);
            }            
        }
    }
}
