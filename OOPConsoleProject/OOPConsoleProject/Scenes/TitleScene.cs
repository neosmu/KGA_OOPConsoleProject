using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public class TitleScene : Scene
    {
        private ConsoleKey input;
        public TitleScene()
        {
            name = "Title";
        }
        public override void Render()
        {
            Console.WriteLine("********************");
            Console.WriteLine("*   몬스터 사냥    *");
            Console.WriteLine("********************");
            Console.WriteLine();
            Console.WriteLine("1. 게임 시작");
            Console.WriteLine("2. 게임 종료");
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
                    Game.ChangeScene("Choice");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("게임을 종료합니다.");
                    Game.End();
                    break;
            }
            
        }
    }
}
