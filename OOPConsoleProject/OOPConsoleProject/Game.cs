using OOPConsoleProject.Scenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public static class Game
    {
        private static Dictionary<string, Scene> sceneDic;
        private static Scene curScene;
        public static string prevSceneName;
        public static bool hasKey = false;      // 열쇠아이템 보유 여부
        private static bool gameOver;

        private static Player player;
        public static Player Player { get { return player; } set { player = value; } }

        // 게임 동작
        public static void Run()
        {
            Start();
            while (gameOver == false)
            {
                Console.Clear();
                curScene.Render();
                curScene.Input();
                curScene.Update();
                curScene.Result();
            }
            End();
        }
        // 게임 시작 설정
        private static void Start()
        {
            Console.CursorVisible = false;
            // 게임 설정
            gameOver = false;
            player = new Player("전사", 100, 100);
            // 씬 설정
            sceneDic = new Dictionary<string, Scene>();
            sceneDic.Add("Title", new TitleScene());
            sceneDic.Add("Choice", new PlayerChoiceScene());
            sceneDic.Add("Town", new TownScene());
            sceneDic.Add("Shop", new ShopScene());
            sceneDic.Add("Forest", new ForestFieldScene());
            sceneDic.Add("Nomal", new NomalFieldScene());
            sceneDic.Add("Hidden", new HiddenFieldScene());
            sceneDic.Add("Battle01", new BattleScene01(new Monster("고블린", 60, 150)));
            sceneDic.Add("Battle02", new BattleScene02(new Monster("오크", 90, 250)));

            curScene = sceneDic["Title"];
        }

        public static void ChangeScene(string sceneName)
        {
            prevSceneName = curScene.name;

            curScene = sceneDic[sceneName];
            curScene.Enter();
        }
        public static void GameOver(string reason)
        {
            Console.Clear();
            Console.WriteLine("**********************************");
            Console.WriteLine("*          You Died...           *");
            Console.WriteLine("**********************************");
            Console.WriteLine();
            Console.WriteLine(reason);

            gameOver = true;
        }

        public static void End()
        {
            gameOver = true;
        }
    }
}
