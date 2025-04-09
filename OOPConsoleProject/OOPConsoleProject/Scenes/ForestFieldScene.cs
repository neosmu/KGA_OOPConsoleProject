using OOPConsoleProject.Objects;
using OOPConsoleProject.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public class ForestFieldScene : FieldScene
    {
        public ForestFieldScene()
        {
            name = "Forest";
        mapData = new string[]
            {
                 "##########",
                 "#  ##    #",
                 "#  ##    #",
                 "#        #",
                 "####   # #",
                 "#  ### # #",
                 "#      # #",
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
            gameObjects.Add(new Place("Nomal", 'N', new Vector2(8, 6)));
            gameObjects.Add(new HiddenKey(new Vector2(1, 6)));
            gameObjects.Add(new MonsterObject("Battle01", new Vector2(3, 6)));
        }
        public override void Enter()
        {
            Util.PressAnyKey("당신은 숲속에 들어갑니다.");
            if (Game.prevSceneName == "Town")
            {
                Game.Player.position = new Vector2(1, 1);
            }
            else if (Game.prevSceneName == "Nomal")
            {
                Game.Player.position = new Vector2(8, 6);
            }
            Game.Player.map = map;
        }
    }
}
