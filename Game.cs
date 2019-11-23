using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Threading;

namespace Ascend
{
    class Game
    {
        public List<Platform> Platforms { get; set; }
        public Player CurrentPlayer;
        public List<Player> Players;
        DispatcherTimer GameTimer;

        public Game()
        {
            // Set up start of game
            // Once setup is finished,

            Platforms = new List<Platform>();
            CurrentPlayer = new Player();
            Players = new List<Player>();
            Players.Add(CurrentPlayer);


            GameTimer = new DispatcherTimer();
            GameTimer.Interval = new TimeSpan(0, 0, 0, 0, 20);
            GameTimer.Tick += HandleGameTick;
            GameTimer.Start();
            // Make Timer start game once countdown is finished
            // Once game is started, Timer moves all objects on-screen downwards until player dies, as well as increasing score over time
        }

        public void HandleGameTick(object sender, EventArgs e) {
            foreach(Player p in Players) {
                p.HandleGameTick();
            }
            foreach(Platform p in Platforms) {
                p.HandleGameTick();
            }

        }
    }
}
