using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Games_Collection
{
    internal class GameView
    {
        public void printOut(string whatToPrint)
        {
            Console.Write(whatToPrint);
            Console.Write("\n");
        }
        public string getInfo()
        {
            return Console.ReadLine();
        }

        public string printOptions()
        {
            Console.Write("\n");
            Console.WriteLine("Please make a selection:"); //prompt
            Console.WriteLine("1: Add Game"); //prompt
            Console.WriteLine("2: See list"); //prompt
            Console.WriteLine("3: End app"); //prompt
            Console.Write("Selection: "); //prompt
            string userInput = Console.ReadLine();
            Console.Write("\n");
            return userInput;
        }
    }
}
