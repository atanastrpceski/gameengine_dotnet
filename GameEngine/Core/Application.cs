﻿using GameEngine.OpenGL;
using System;
namespace GameEngine.Core
{
    public class Application : IDisposable
    {
        Window _window;
        private bool isRunning = true;

        public Application(WindowProp prop)
        {
            _window = new Window(prop);
        }
        public void Run()
        {
            while (isRunning)
            {
                Gl.glClearColor(1, 0, 1, 1);
                Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                _window.OnUpdate();
            }
        }

        public void Dispose()
        {
            _window.Dispose();
        }
    }
}