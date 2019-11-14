using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Ascend
{
    class Game
    {
        public List<Platform> Platforms { get; set; }

        public Player CurrentPlayer = new Player();

        Timer GameBeginTimer;

        public Game()
        {
            // Set up start of game
            // Once setup is finished,

            // Make Timer start game once countdown is finished
            // Once game is started, Timer moves all objects on-screen downwards until player dies, as well as increasing score over time
        }

        public void StartGame()
        {
            // Code to start a game sequence
        }

        public void FinishGame()
        {

        }

        public void UpdateScreen()
        {
            // Update where the objects are on-screen
        }
    }
}
