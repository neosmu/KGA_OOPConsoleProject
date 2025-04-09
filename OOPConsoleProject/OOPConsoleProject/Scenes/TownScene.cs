using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public class TownScene : Scene
    {
        private ConsoleKey input;
        public TownScene()
        {
            name = "Town";
        }
        public override void Render()
        {
            Console.WriteLine("사람들이 북적이는 마을이다.");
            Console.WriteLine("어디로 이동하시겠습니까?");
            Console.WriteLine();
            Console.WriteLine("1. 필드로 나간다.");
            Console.WriteLine("2. 상점으로 간다.");
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
                    Console.WriteLine("마을 밖으로 나갑니다.");
                    Game.ChangeScene("Forest");
                    break;
                case ConsoleKey.D2:
                    Util.PressAnyKey("상점으로 갑니다.");
                    Game.ChangeScene("Shop");
                    break;
            }
        }
    }
}
