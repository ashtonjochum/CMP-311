using System.Runtime.CompilerServices;

namespace Calculator
{
    class CalculatorModel
    {
        private double num1;
        private double num2;

        public CalculatorModel()
        {
            num1 = 0.0;
            num2 = 0.0;
        }

        public double Number1
        {
            get { return num1; }
            set { num1 = value; }
        }

        public double Number2
        {
            get { return num2; }
            set { num2 = value; }
        }


        public double doOperation(string op)
        {
            double result = double.NaN;
            if (op == "a")
            {
                result = num1 + num2;
            }
            else if (op == "s")
            {
                result = num1 - num2;
            }
            else if (op == "m")
            {
                result = num1 * num2;
            }
            else if (op == "d")
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
            }
            return result;
        }
    }
}