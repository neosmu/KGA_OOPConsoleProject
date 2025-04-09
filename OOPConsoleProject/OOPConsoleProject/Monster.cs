using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public class Monster
    {
        public string name;
        public int attack;
        public int hp;

        public Monster(string name, int attack, int hp)
        {
            this.name = name;
            this.attack = attack;
            this.hp = hp;
        }
    }
    public class MonsterFactory
    {
        public Monster Create(string name)
        {
            Monster monster;
            switch (name)
            {
                case "고블린": monster = new Monster("고블린", 60, 150); break;
                case "오크": monster = new Monster("오크", 90, 250); break;
                default: return null;
            }
            return monster;
        }
    }
}
