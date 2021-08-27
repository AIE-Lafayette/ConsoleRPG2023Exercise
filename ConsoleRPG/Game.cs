using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleRPG
{
    class Game
    {
        private bool _gameOver;

        public void Start()
        {
            
        }

        public void Update()
        {

        }

        public void End()
        {

        }

        public void Run()
        {
            Start();

            while (!_gameOver)
            {
                Update();
            }

            End();
        }

    }
}
