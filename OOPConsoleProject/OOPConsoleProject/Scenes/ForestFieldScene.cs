using OOPConsoleProject.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    class ForestFieldScene : FieldScene
    {
        public ForestFieldScene()
        {
            name = "Forest";
        mapData = new string[]
            {
                 "##########",
                 "#        #",
                 "#        #",
                 "#        #",
                 "#        #",
                 "#        #",
                 "#        #",
                 "##########"
            };

            map = new bool[8, 10];
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    map[y, x] = mapData[y][x] == '#' ? false : true;
                }
            }
            gameObjects = new List<GameObject>();
            gameObjects.Add(new Place("Town", 'T', new Vector2(1, 1)));
        }
        public override void Enter()
        {
            if (Game.prevSceneName == "Town")
            {
                Game.Player.position = new Vector2(1, 1);
            }
            Game.Player.map = map;
        }
    }
}
