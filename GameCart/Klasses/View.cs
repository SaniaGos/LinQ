using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCart.Klasses
{
    internal static class View
    {
        public static void ViewCent(string str, string endLine = "", ConsoleColor color = ConsoleColor.Gray)
        {
            Console.ForegroundColor = color;
            int x = Console.WindowWidth / 2 - str.Length / 2;
            Console.CursorLeft = x;
            Console.WriteLine(str + endLine);
            Console.ResetColor();
        }
        public static void ViewLeft(string str, int left, ConsoleColor color = ConsoleColor.Gray)
        {
            Console.ForegroundColor = color;
            Console.CursorLeft = left;
            Console.WriteLine(str);
            Console.ResetColor();
        }
        public static void ViewPoint(List<Player> players, int playerGet)
        {
            
            for (int i = 0; i < players.Count; i++)
            {
                if (playerGet == i) Console.ForegroundColor = ConsoleColor.Red;
                else Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.CursorLeft = Console.WindowWidth / 2 - 16 + (11 * i);
                Console.Write(players[i].Point);
                Console.ResetColor();
            }
            Console.WriteLine();
        }
        public static void StartGame()
        {
            View.ViewCent("Points", "\n", ConsoleColor.Green);
            View.ViewCent("Player     Player     Player     Player", "", ConsoleColor.DarkGreen);
            View.ViewCent("   1          2          3          4  ", "", ConsoleColor.DarkGreen);
        }
    }
}
