using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPConsoleProject
{
    public class Player
    {
        public string name;
        public int attack;
        private int curHP;
        public int CurHP { get { return curHP; } set { curHP = value; } }
        private int maxHP;
        public int MaxHP { get { return maxHP; } set { maxHP = value; } }

        public Player(string name, int attack, int hp)
        {
            this.name = name;
            this.attack = attack;
            this.maxHP = hp;
            this.curHP = hp;
        }
        public void PrintStats()
        {
            Console.WriteLine("== 플레이어 정보 ==");
            Console.WriteLine("직업 : {0}", Game.Player.name);
            Console.WriteLine("체력 : {0} / {1}", Game.Player.CurHP, Game.Player.MaxHP);
            Console.WriteLine("공격력 : {0}", Game.Player.attack);
        }
        public Vector2 position;
        public bool[,] map;

        public void Print()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write('P');
            Console.ResetColor();
        }
        public void Action(ConsoleKey input)
        {
            switch (input)
            {
                case ConsoleKey.UpArrow:
                case ConsoleKey.DownArrow:
                case ConsoleKey.LeftArrow:
                case ConsoleKey.RightArrow:
                    Move(input);
                    break;
            }
        }
        private void Move(ConsoleKey input)
        {
            Vector2 targetPos = position;

            switch (input)
            {
                case ConsoleKey.UpArrow:
                    targetPos.y--;
                    break;
                case ConsoleKey.DownArrow:
                    targetPos.y++;
                    break;
                case ConsoleKey.LeftArrow:
                    targetPos.x--;
                    break;
                case ConsoleKey.RightArrow:
                    targetPos.x++;
                    break;
            }

            if (map[targetPos.y, targetPos.x] == true)
            {
                position = targetPos;
            }
        }
    }
    public class PlayerFactory
    {
        public Player Create(string name)
        {
            Player player;
            switch (name)
            {
                case "전사": player = new Player("전사", 100, 100); break;
                case "궁수": player = new Player("궁수", 120, 80); break;
                case "탱커": player = new Player("탱커", 70, 150); break;
                default: return null;
            }
            return player;
        }
    }
}
