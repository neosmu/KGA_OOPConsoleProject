using OOPConsoleProject.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public class NomalFieldScene : FieldScene
    {
        public NomalFieldScene()
        {
            name = "Nomal";
            mapData = new string[]
                {
                 "##########",
                 "#  ##  # #",
                 "#  ##  # #",
                 "#        #",
                 "####     #",
                 "#  #   # #",
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
            gameObjects.Add(new Place("Forest", 'F', new Vector2(1, 1)));
            gameObjects.Add(new LockPlace("Hidden", 'H', new Vector2(8, 1), true));
        }
        public override void Enter()
        {
            Util.PressAnyKey("당신은 광활한 들판으로 왔습니다.");
            if (Game.prevSceneName == "Forest")
            {
                Game.Player.position = new Vector2(1, 1);
            }
            Game.Player.map = map;
        }
    }
}
