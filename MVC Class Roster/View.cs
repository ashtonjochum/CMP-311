using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Class_Roster
{
    class rosterView
    {
        public void printOut (string whatToPrint)
        {
            Console.Write(whatToPrint);
            Console.Write("\n");
        }


        public string getInfo()
        {
            return Console.ReadLine();
        }

        public string printFirstOptions()
        {
            Console.Write("\n");
            Console.WriteLine("Please make a selection:"); //prompt
            Console.WriteLine("1: Add student"); //prompt
            Console.WriteLine("2: See list"); //prompt
            Console.WriteLine("3: End app"); //prompt
            Console.Write("Selection: "); //prompt
            string userInput = Console.ReadLine();
            Console.Write("\n");
            return userInput;
        }
        public string printSecondOptions()
        {
            Console.Write("\n");
            Console.WriteLine("Please make a selection on"); //prompt
            Console.WriteLine("how to sort the list: "); //promp
            Console.WriteLine("a: As entered"); //prompt
            Console.WriteLine("b: By student last name"); //prompt
            Console.WriteLine("c: By student class rank"); //prompt
            Console.Write("Selection: "); //prompt
            Console.Write("\n");
            string userInputTwo = Console.ReadLine().ToLower();
            return userInputTwo;
        }
    }
}