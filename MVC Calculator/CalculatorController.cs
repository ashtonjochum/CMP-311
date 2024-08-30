namespace Calculator
{
    class CalcController
    {
        public CalcController()
        {
            CalculatorView calcView = new CalculatorView();
            CalculatorModel calcModel = new CalculatorModel();

            bool run = true;

            while (run)
            {
                calcView.printString("Input first number: ");
                calcModel.Number1 = calcView.getDoubleFromUser();
                string tempOp = calcView.printOptions();
                calcView.printString("Input second number: ");
                calcModel.Number2 = calcView.getDoubleFromUser();
                double result = calcModel.doOperation(tempOp);
                if (double.IsNaN(result))
                {
                    calcView.printString("An error has occured and the operation could not be performed.\n\n");
                }
                else
                {
                    calcView.printResult(result);
                }

                run = calcView.keepRun();
            }
            
            

        }
    }
}