namespace Calculator
{
    class CalculatorView
    {
        public void printString(string whatToPrint)
        {
            Console.Write(whatToPrint);
        }

        public string printOptions()
        {
            Console.WriteLine("Choose an operator from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");
            string op = Console.ReadLine();
            Console.WriteLine("\n");
            return op;
        }

        public double getDoubleFromUser()
        {
            string userNum = Console.ReadLine();
            double cleanNum = 0.0;
            while (!double.TryParse(userNum, out cleanNum))
            {
                Console.WriteLine("\n");
                Console.Write("This is not valid input. Please enter a numeric value: ");
                userNum = Console.ReadLine();
            }
            Console.WriteLine("\n");
            return cleanNum;
        }

        public void printResult(double result)
        {
            Console.WriteLine("The result is: " + result);
            Console.WriteLine("\n");
        }

        public Boolean keepRun()
        {
            Console.Write("Press y to do another calculation or any other key to exit: ");
            string runCheck = Console.ReadLine().ToLower();
            Console.WriteLine("\n");
            if (runCheck == "y")
            {
                return true;
            }
           else
            {
                return false;
            }
        }
    }//class
}//namespace