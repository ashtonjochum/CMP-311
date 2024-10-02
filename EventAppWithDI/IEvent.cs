using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAppWithDI
{
    public interface IEvent
    {
        double modifiedCost(string op);
    }
}
