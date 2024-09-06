using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Games_Collection
{
    internal class GameModel
    {

        private GameGenere gG;
        private List<Game> gameList;
        


        public GameModel()
        {
            gG = new GameGenere();
            gameList = new List<Game>();
            
        }

        public void setGenere(string genere, string ageRange)
        {
            gG.Genere = genere;
            gG.AgeRange = ageRange;
        }

        public GameGenere getGenere()
        {
            return gG;
        }

        public void addGame(string name, string timeToPlay)
        {
            gameList.Add(new Game(name, timeToPlay));
            
        }

        public string genereToString(GameGenere gameGenere)
        {
            return gameGenere.ToString();
        }
        public string gameToString(Game game)
        {
            return game.ToString();
        }

        public List<Game> getGameList()
        {
            return gameList;
        }
    }
}
