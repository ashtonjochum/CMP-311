using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Games_Collection
{
    class Game
    {
        private string name;
        private string timeToPlay;

        public Game()
        {
            name = "";
            timeToPlay = "";
        }

        public Game(string nameIn, string timeToPlayIn)
        {
            name = nameIn;
            timeToPlay = timeToPlayIn;

        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string TimeToPlay
        {
            get { return timeToPlay; }
            set { timeToPlay = value; }
        }

        public override string ToString()
        {
            return "Game: " + this.Name + " takes " + this.TimeToPlay + " to play";
        }


    }
}
