using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCart.Klasses
{
    class DeskOfCards
    {
        public List<Card> Cards { get; private set; }
        private void Swap(int index_1, int index_2)
        {
            if (index_1 != index_2)
            {
                if (index_1 < Cards.Count && index_2 < Cards.Count)
                {
                    Card tmp = Cards[index_1];
                    Cards[index_1] = Cards[index_2];
                    Cards[index_2] = tmp;
                }
            }
        }
        public DeskOfCards()
        {
            Cards = new List<Card>
            {
                new Card(SizeCard.Six, Suit.Heard),
                new Card(SizeCard.Six, Suit.Club),
                new Card(SizeCard.Six, Suit.Diamond),
                new Card(SizeCard.Six, Suit.Spade),
                new Card(SizeCard.Seven, Suit.Heard),
                new Card(SizeCard.Seven, Suit.Club),
                new Card(SizeCard.Seven, Suit.Diamond),
                new Card(SizeCard.Seven, Suit.Spade),
                new Card(SizeCard.Eight, Suit.Heard),
                new Card(SizeCard.Eight, Suit.Club),
                new Card(SizeCard.Eight, Suit.Diamond),
                new Card(SizeCard.Eight, Suit.Spade),
                new Card(SizeCard.Nine, Suit.Heard),
                new Card(SizeCard.Nine, Suit.Club),
                new Card(SizeCard.Nine, Suit.Diamond),
                new Card(SizeCard.Nine, Suit.Spade),
                new Card(SizeCard.Ten, Suit.Heard),
                new Card(SizeCard.Ten, Suit.Club),
                new Card(SizeCard.Ten, Suit.Diamond),
                new Card(SizeCard.Ten, Suit.Spade),
                new Card(SizeCard.Jack, Suit.Heard),
                new Card(SizeCard.Jack, Suit.Club),
                new Card(SizeCard.Jack, Suit.Diamond),
                new Card(SizeCard.Jack, Suit.Spade),
                new Card(SizeCard.Queen, Suit.Heard),
                new Card(SizeCard.Queen, Suit.Club),
                new Card(SizeCard.Queen, Suit.Diamond),
                new Card(SizeCard.Queen, Suit.Spade),
                new Card(SizeCard.King, Suit.Heard),
                new Card(SizeCard.King, Suit.Club),
                new Card(SizeCard.King, Suit.Diamond),
                new Card(SizeCard.King, Suit.Spade),
                new Card(SizeCard.Ase, Suit.Heard),
                new Card(SizeCard.Ase, Suit.Club),
                new Card(SizeCard.Ase, Suit.Diamond),
                new Card(SizeCard.Ase, Suit.Spade)
            };
            Shuffle();
        }
        public void Shuffle()
        {
            if (!(Cards is null) && Cards.Count > 0)
            {
                for (int j = 0; j < 3; j++)             // думаю 3 разів пересвапити всю колоду вистачить
                {
                    for (int i = 0; i < 36; i++)
                    {
                        Swap(i, MyRand.GetRand(0, 35)); // List немає Swap, то ж прийшлось написати свій
                    }
                }
            }
        }
        public Card GetCard()
        {
            if (Cards.Count > 0)
            {
                Card tmp = Cards[0];
                Cards.RemoveAt(0);
                return tmp;
            }
            else throw new Exception("Desk of cards are empty");
        }
    }
}
