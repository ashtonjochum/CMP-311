using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventUnitTestExcercise
{
    public class PricingEngine
    {
       public double PriceChange(string letter, double Cost)
        {
           if(letter == "d" || letter == "D")
            {
                Cost = Cost * .9;
                Console.WriteLine("Discount price is: $" + Cost);
                return Cost;
            }
           else if(letter == "l" || letter == "L")
            {
                Cost = Cost * 1.1;
                Console.WriteLine("Late price is: $" + Cost);
                return Cost;
            }
           else if(letter == "e" ||  letter == "E")
            {
                Cost = Cost * .75;
                Console.WriteLine("Employee price is: $" + Cost);
                return Cost;
            }
           else if( letter == "f" || letter == "F")
            {
                Cost = Cost * 0;
                Console.WriteLine("Free price is: $" + Cost);
                return Cost;
            }
            else
            {
                Console.WriteLine("No price change. Your price is: $" + Cost);
                return Cost;
            }
            
        }
    }
}
