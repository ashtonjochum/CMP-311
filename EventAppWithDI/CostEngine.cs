using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAppWithDI
{
    public class CostEngine
    {
        public double modifyCost(double cost, string op)
        {
            if (op == "l" || op == "L")
            {
                return cost * 1.1;
            }
            else if (op == "e" || op == "E")
            {
                return cost * 0.75;
            }
            else if (op == "f" || op == "F")
            {
                return cost * 0.0;
            }
            else if (op == "d" || op == "D")
            {
                return cost * 0.9;
            }
            else
            {
                return cost;
            }
        }
    }
}
