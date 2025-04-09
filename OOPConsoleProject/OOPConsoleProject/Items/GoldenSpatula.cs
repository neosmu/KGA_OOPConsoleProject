using OOPConsoleProject.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Items
{
    public class GoldenSpatula : Item
    {
        public GoldenSpatula(Vector2 position)
            : base('G', position)
        {
            name = "황금 뒤집개";
            description = "모든 능력치를 +50증가합니다.";
        }
        public override void Use()
        {
            Game.Player.Bonus(50, 50);
            Util.PressAnyKey("황금 뒤집개를 사용하여 능력치 50이 증가하였습니다.");
        }
    }
}
