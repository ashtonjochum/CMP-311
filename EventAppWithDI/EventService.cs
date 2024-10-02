using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAppWithDI
{
    public class EventService
    {
            private readonly IEvent _event;
            public EventService(IEvent currentEvent)
            {
                _event = currentEvent;
            }
            public double modifiedCost(string op)
            {
               return _event.modifiedCost(op);
            }
    }
}
