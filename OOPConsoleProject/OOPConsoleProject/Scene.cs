﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public abstract class Scene
    {
        public string name;

        public abstract void Render();
        public abstract void Input();
        public abstract void Update();
        public abstract void Result();
        public virtual void Enter() { }
    }
}
