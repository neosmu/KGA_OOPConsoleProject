using OOPConsoleProject.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Items
{
    public class HiddenKey : Item
    {
        public HiddenKey(Vector2 position)
            : base('K', position)
        {
            name = "열쇠";
            description = "비밀방을 열 수 있는 열쇠입니다.";
        }
        public override void Use()
        {
            Game.hasKey = true;
            Util.PressAnyKey("열쇠를 획득했습니다! 이제 비밀방을 열 수 있습니다.");
        }
    }
}
