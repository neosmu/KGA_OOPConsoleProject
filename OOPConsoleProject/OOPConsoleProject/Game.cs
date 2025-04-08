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

        // 게임 동작
        public static void Run()
        {
            Start();
            while (gameOver == false)
            {
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

            curScene = sceneDic["Title"];
        }

        private static void End()
        {

        }
    }
}
