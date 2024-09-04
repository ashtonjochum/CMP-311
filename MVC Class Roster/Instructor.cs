using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoster
{
    internal class Instructor : Person
    {
        private string contactInformation;

        public Instructor() : base()
        {
            contactInformation = "";
        }

        public Instructor(string first, string last, string contactInfo) : base(first, last)
        { 
            contactInformation = contactInfo;
        }

        public string ContactInfoformation
        {
            get { return contactInformation; }
            set { contactInformation = value; }
        }

        public override string ToString()
        {
            return "Instructor: " + this.FirstName + " " + this.LastName + " " + this.ContactInfoformation;
        }


    }   
}
