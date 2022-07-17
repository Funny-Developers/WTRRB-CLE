using System;
using System.Threading;

namespace WTRRB_CLE
{
    public class Game
    {
        public static string text;
        public static ConsoleKey key;
        public static int time;

        public static void TextAppearance(string text)
        {
            Console.WriteLine(text);
            while (true)
            {
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    break;
                }
                else { }
            }
        }

        public static void GameStartMenu(string text, ConsoleKey key)
        {
            Console.WriteLine(text);
            while (true)
            {
                if (Console.ReadKey().Key == key)
                {
                    break;
                }
                else { }
            }
        }

        public static void AutoText(string text, int time)
        {
            Console.WriteLine(text);
            Thread.Sleep(time);
        }
    }
}
