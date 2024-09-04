using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoster
{
    internal class Person
    {
        private string firstName;
        private string lastName;

        public Person()
        {
            firstName = "";
            lastName = "";
        }
        
        public Person(string first, string last)
        {
            firstName = first;
            lastName = last;
        }
        
        public string FirstName 
        {
            get {return firstName;} 
            set {firstName = value;} 
        }
        public string LastName 
        {
            get { return lastName;} 
            set {lastName = value;}
        }
    }
}
