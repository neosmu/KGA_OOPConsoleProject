using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public class TitleScene : Scene
    {
        public TitleScene()
        {
            name = "Title";
        }
        public override void Render()
        {
            Console.WriteLine("********************");
            Console.WriteLine("*   몬스터 사냥    *");
            Console.WriteLine("********************");
            Console.WriteLine();
            Console.WriteLine("계속하려면 아무키나 누르세요...");
        }
        public override void Input()
        {
            Console.ReadKey(true);
        }
        public override void Update()
        {
            
        }
        public override void Result()
        {
            
        }
    }
}
