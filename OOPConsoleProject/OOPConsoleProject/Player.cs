using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public class Player
    {
        public string name;
        public int attack;
        public int hp;
        
        public Player(string name, int attack, int hp)
        {
            this.name = name;
            this.attack = attack;
            this.hp = hp;
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
