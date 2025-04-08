using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public class PlayerChoiceScene : Scene
    {
        private ConsoleKey input;

        public PlayerChoiceScene()
        {
            name = "Choice";
        }
        public override void Render()
        {
            Console.WriteLine("플레이할 캐릭터를 선택해주세요");
            Console.WriteLine("1. 전사");
            Console.WriteLine("2. 궁수");
            Console.WriteLine("3. 탱커");
        }
        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }
        public override void Update()
        {
            
        }
        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Game.player = new Player("전사", 100, 100);
                    Util.PressAnyKey("전사를 선택하였습니다.");
                    break;
                case ConsoleKey.D2:
                    Game.player = new Player("궁수", 120, 80);
                    Util.PressAnyKey("궁수를 선택하였습니다.");
                    break;
                case ConsoleKey.D3:
                    Game.player = new Player("탱커", 70, 150);
                    Util.PressAnyKey("탱커를 선택하였습니다.");
                    break;
            }
        }
    }
}
