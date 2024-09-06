using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Games_Collection
{
    internal class GameController
    {

        public GameController()
        {
            GameView gameView = new GameView();
            GameModel gameModel = new GameModel();


            // get and set game genere and age range
            gameView.printOut("Game Genere: ");
            string gameGenereIn = gameView.getInfo();
            gameView.printOut("Game Age Range: ");
            string ageRangeIn = gameView.getInfo();

            gameModel.setGenere(gameGenereIn, ageRangeIn);

            Boolean run = true;

            while (run)
            {
                string op = gameView.printOptions();
                if (op == "1")
                {
                    //add new student to list
                    gameView.printOut("Game Name: ");
                    string nameIn = gameView.getInfo();
                    gameView.printOut("Time to play game: ");
                    string tTPG = gameView.getInfo();
                    gameModel.addGame(nameIn, tTPG);

                }
                else if (op == "2")
                {
                 

                  gameView.printOut(gameModel.genereToString(gameModel.getGenere()));
                  foreach (Game g in gameModel.getGameList())
                    {
                        gameView.printOut(gameModel.gameToString(g));
                    }
                                       
                }
                else if (op == "3")
                {
                    gameView.printOut("Ending program...");
                    run = false;
                }
                else
                {
                    gameView.printOut("Error in reading input, please try again!");
                }
            }

        }
    }
}
