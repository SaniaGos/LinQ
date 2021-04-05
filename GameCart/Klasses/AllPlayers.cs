using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace GameCart.Klasses
{
    class AllPlayers : IEnumerable<Player>
    {
        private void PutCard()
        {
            foreach (Player item in Players)
            {
                PlayArea.PutCard(item.PutCard());
            }
        }
        public int PlayerMaxPoint()
        {
            int maxPlayerPoint = 0;
            int playerPoint = Players[0].Point;
            for (int i = 1; i < Players.Count; i++)
            {
                if (playerPoint < Players[i].Point)
                {
                    playerPoint = Players[i].Point;
                    maxPlayerPoint = i;
                }
            }
            return maxPlayerPoint;
        }
        public List<Player> Players { get; private set; }
        public PlayArea PlayArea { get; set; }

        public AllPlayers(int numOfPlayer)
        {
            Players = new List<Player>();
            for (int i = 0; i < numOfPlayer; i++)
            {
                Players.Add(new Player());
            }
            PlayArea = new PlayArea();
        }

        public IEnumerator<Player> GetEnumerator()
        {
            return Players.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return Players.GetEnumerator();
        }

        public void GetCardsFromDesk(DeskOfCards deskOfCards)
        {
            while (deskOfCards.Cards.Count != 0)
            {
                foreach (Player item in Players)
                {
                    if (deskOfCards.Cards.Count != 0)
                        item.GetCard(deskOfCards);
                }
            }
        }
        public void Play()
        {
            int move = 1;
            int maxPlayerCard = 0;
            while (Players[0].Cards.Count > 0)
            {
                PutCard();                                                      // кладем по одній карті на стіл
                maxPlayerCard = PlayArea.MaxCard();
                Players[maxPlayerCard].AddRecoilRange(PlayArea.Cards);     // карти забирає гравець чия карта була найбільшою
                PlayArea.Cards.Clear();                                         // очищаєм стіл
                Thread.Sleep(1000);
                View.ViewLeft($"Move {move}", 10, ConsoleColor.Yellow);
                View.ViewPoint(Players, maxPlayerCard);
                move++;
            }
            PlayerMaxPoint();
        }
    }
}
