using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace GameCart.Klasses
{
    class Game
    {
        public int Winner { get; private set; }
        public AllPlayers Players { get; private set; }
        public DeskOfCards DeskOfCards { get; set; }
        public Game()
        {
            DeskOfCards = new DeskOfCards();
            Players = new AllPlayers(4);            // сам здивувався, гра не ламається коли (2,3,4) гравця
            Winner = -1;
        }
        public void StartGame()
        {
            View.ViewCent("Start Game", "\n", ConsoleColor.Green);
            Thread.Sleep(500);
            View.ViewCent("Deal cards", "\n", ConsoleColor.Cyan);
            Thread.Sleep(1000);
            View.StartGame();
            Thread.Sleep(500);
            Players.GetCardsFromDesk(DeskOfCards);          // роздаєм карти
            Players.Play();                                 // починаєм
            Winner = Players.PlayerMaxPoint();              // переможець
            Console.WriteLine();
            View.ViewCent($"Winner {Winner + 1} player", "\n", ConsoleColor.Red);
        }
    }
}
