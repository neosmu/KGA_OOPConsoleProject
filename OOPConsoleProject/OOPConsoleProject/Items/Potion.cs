using OOPConsoleProject.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPConsoleProject.Items
{
    public class Potion : Item
    {
        public Potion(Vector2 position)
            : base('P', position)
        {
            name = "포션";
            description = "체력을 회복하는 아이템";
        }
        public override void Use()
        {
            if(Game.Player.CurHP == Game.Player.MaxHP)
            {
                Util.PressAnyKey("이미 체력이 가득차 있습니다.");
                return;
            }
            else
            {
                Game.Player.Heal(30);
                Util.PressAnyKey("포션을 사용하여 체력 30을 회복하였습니다.");
                return;
            }
        }
    }
}
