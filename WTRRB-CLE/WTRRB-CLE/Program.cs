using System;

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
            Game.AutoText("此小说内容均非事实，清甄别现实与虚拟。", 5000);
            Game.AutoText("--序言--", 1000);
            Game.AutoText("公元2420年，美国对外宣布本国能源耗尽。因此，各国能源进口转向中，俄等国家和地区。", 3000);
            Game.AutoText("2422年2月，中国宣布不再对外出口能源；\n同年5月，俄罗斯也宣布不再对外出口能源。", 3000);
            Game.AutoText("2430年5月至11月，日本能源匮乏，进军日本海至白令海峡之间的海域及陆地。\n6月，美，俄对日宣战，太平洋战争爆发。\n7月，加拿大对日宣战。", 3000);
            Game.AutoText("2431年1月，日本控制日本海及白令海峡周围地区。\n4月，欧盟重组，与地中海各国结成欧洲-北非同盟。", 3000);
            Game.AutoText("2432年11月，欧洲-北非同盟改组为欧洲民主共和国联盟。中东社会主义共和国成立，包括中东，阿拉伯半岛及高加索地区。非洲联盟成立，包括非洲撒哈拉沙漠以南地区。", 3000);
            Game.AutoText("2433年底，俄罗斯收复被日本侵占的领土及阿拉斯加，引起了美，加的不满。", 3000);
            Game.AutoText("2435年7月，日本发动侵华战争，占领了库页岛，外兴安岭以南及中国东北地区，中，俄对日宣战。\n9月，日本占领东南亚及南亚地区。", 3000);
            Game.AutoText("", 3000);
        }
    }
}
