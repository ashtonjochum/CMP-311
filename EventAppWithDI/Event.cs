using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EventAppWithDI
{
    public class Event
    {
        private string _id;
        private string _description;
        private double _cost;

        
        public Event(string id, string description, double cost)
        {
            _id = id;
            _description = description;
            _cost = cost;
        }

        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public double Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        public override string ToString()
        {
            return ("Id: " + _id + " " + "Event Description: " + _description + " " + "Unmodified Cost: $" + _cost);
        }
    }
}
