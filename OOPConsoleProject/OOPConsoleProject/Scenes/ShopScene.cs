using OOPConsoleProject.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public class ShopScene : Scene
    {
        private ConsoleKey input;
        public ShopScene()
        {
            name = "Shop";
        }
        public override void Render()
        {
            Console.WriteLine("== 상점에 오신 걸 환영합니다 ==");
            Console.WriteLine("어떤 물건을 구매하실건가요?");

            switch (Game.Player.name)
            {
                case "전사":
                    Console.WriteLine("1. 대검 (공격력 +50)");
                    break;
                case "궁수":
                    Console.WriteLine("1. 수정활 (공격력 +50)");
                    break;
                case "탱커":
                    Console.WriteLine("1. 강철 방패 (공격력 +50)");
                    break;
            }
            Console.WriteLine("2. 갑옷 (체력 +50)");

            Console.WriteLine("3. 나가기");
            Console.WriteLine();
            Console.Write("구매할 항목을 선택하세요: ");
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
                    Game.Player.attack += 50;
                    
                    // 선택한 캐릭터마다 무기가 다르게 나오게
                    switch (Game.Player.name)
                    {
                        case "전사":
                            Util.PressAnyKey("대검을 구매하였습니다! (공격력 +50)");
                            break;
                        case "궁수":
                            Util.PressAnyKey("수정활를 구매하였습니다! (공격력 +50)");
                            break;
                        case "탱커":
                            Util.PressAnyKey("강철 방패를 구매하였습니다! (공격력 +50)");
                            break;
                    }
                    break;
                case ConsoleKey.D2:
                    Game.Player.MaxHP += 50;
                    Game.Player.CurHP += 50;
                    Util.PressAnyKey("갑옷을 구매하였습니다! (체력 +50)");
                    break;
                case ConsoleKey.D3:
                    Util.PressAnyKey("상점을 나갑니다.");
                    Game.ChangeScene("Town");
                    break;
            }
        }
    }
}
