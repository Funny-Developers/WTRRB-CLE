using System;
using System.Threading;

namespace WTRRB_CLE
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-------欢迎游玩 在那放射线绽放的地方 ！-------");
            Game.GameStartMenu("按下回车以开始", ConsoleKey.Enter);
            Console.WriteLine("--Game Start--");
            Console.Clear();
            Game.AutoText("", 3000);
        }
    }
}
