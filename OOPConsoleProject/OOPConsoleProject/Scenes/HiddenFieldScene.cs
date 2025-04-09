using OOPConsoleProject.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public class HiddenFieldScene : FieldScene
    {
        public HiddenFieldScene()
        {
            name = "Hidden";

            mapData = new string[]
            {
                "########",
                "#      #",
                "#      #",
                "#      #",
                "########"
            };
            map = new bool[5, 8];
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    map[y, x] = mapData[y][x] == '#' ? false : true;
                }
            }

            gameObjects = new List<GameObject>();
            gameObjects.Add(new Place("ForestField", 'F', new Vector2(1, 1))); 
        }

        public override void Enter()
        {
            Util.PressAnyKey("문을 열고 히든방으로 들어갑니다.");
            Game.Player.position = new Vector2(1, 1);
            Game.Player.map = map;
        }
    }
}
