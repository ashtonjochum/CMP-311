using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAppWithDI
{
    public class WeddingEvent : Event, IEvent
    {
        public WeddingEvent(string id, string description, double cost) : base(id, description, cost)
        {
        }

        public double modifiedCost(string op)
        {
            CostEngine costEngine = new CostEngine();
            double returnValue = costEngine.modifyCost(this.Cost, op);
            return returnValue;
        }
    }
}
