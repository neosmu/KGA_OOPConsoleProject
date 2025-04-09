using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public class BattleScene02 : Scene
    {
        private Monster monster;
        private ConsoleKey input;

        public BattleScene02(Monster monster)
        {
            this.monster = monster;
            name = "Battle02";
        }
        public override void Render()
        {
            Console.WriteLine("몬스터를 만났습니다.");
            Console.WriteLine("어떤 행동을 하실건가요?");
            Console.WriteLine("몬스터: {0} - 체력: {1}, 공격력: {2}", monster.name, monster.hp, monster.attack);
            Console.WriteLine("플레이어 체력: {0}/{1}, 공격력: {2}", Game.Player.CurHP, Game.Player.MaxHP, Game.Player.attack);
            Console.WriteLine();
            Console.WriteLine("1. 공격한다.");
            Console.WriteLine("2. 도망간다.");
            Console.WriteLine("I. 인벤토리 열기");
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
                    monster.hp -= Game.Player.attack;
                    Console.WriteLine("{0}에게 {1}의 피해를 입혔습니다!", monster.name, Game.Player.attack);

                    if (monster.hp <= 0)
                    {
                        Util.PressAnyKey($"{monster.name}을 쓰러뜨렸습니다!");
                        Game.ChangeScene("Nomal");
                        return;
                    }
                    Game.Player.CurHP -= monster.attack;
                    Util.PressAnyKey($"{monster.name}의 반격! {monster.attack}의 피해를 입었습니다.");

                    if (Game.Player.CurHP <= 0)
                    {
                        Game.GameOver("공격을 버티지 못하고 죽었습니다.");
                    }
                    break;
                case ConsoleKey.D2:
                    Util.PressAnyKey("무사히 도망쳤습니다.");
                    Game.ChangeScene("Nomal");
                    break;

                case ConsoleKey.I:
                    Game.Player.Inventory.Open();
                    Util.PressAnyKey("전투를 계속합니다.");
                    break;
            }
        }
    }
}
