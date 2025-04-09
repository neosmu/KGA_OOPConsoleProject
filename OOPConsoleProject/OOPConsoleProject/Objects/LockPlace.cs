using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Objects
{
    public class LockPlace : Place
    {
        private bool requireKey;
        public LockPlace(string scene, char symbol, Vector2 position, bool requireKey)
            : base(scene, symbol, position)
        {
            this.requireKey = requireKey;
        }
        public override void Interact(Player player)
        {
            if (requireKey && Game.hasKey == false)
            {
                Util.PressAnyKey("문이 잠겨 있습니다. 열쇠가 필요합니다.");
                return;
            }
            if (requireKey)
            {
                Util.PressAnyKey("열쇠로 문을 열었습니다!");
            }
            Game.ChangeScene(scene);
        }
    }
}
