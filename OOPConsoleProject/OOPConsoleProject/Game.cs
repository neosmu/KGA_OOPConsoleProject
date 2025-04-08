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
        private static bool gameOver;

        public static Player player;
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
            // 게임 설정
            gameOver = false;
            // 씬 설정
            sceneDic = new Dictionary<string, Scene>();
            sceneDic.Add("Title", new TitleScene());
            sceneDic.Add("Choice", new PlayerChoiceScene());

            curScene = sceneDic["Title"];
        }

        public static void ChangeScene(string sceneName)
        {
            curScene = sceneDic[sceneName];
        }

        public static void End()
        {
            gameOver = true;
        }
    }
}
