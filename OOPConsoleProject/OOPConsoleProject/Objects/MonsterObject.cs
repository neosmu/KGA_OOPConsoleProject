using OOPConsoleProject.Scenes;
using OOPConsoleProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOPConsoleProject.Objects
{
    public class MonsterObject : GameObject
    {
        public string scene;

        public MonsterObject(string scene, Vector2 position)
            : base(ConsoleColor.Red, 'M', position, true)
        {
            this.scene = scene;
        }

        public override void Interact(Player player)
        {
            Game.ChangeScene(scene);
        }
    }
}