using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoster
{
    internal class Student : Person
    {
        private string classRank;

        public Student() : base()
        {
            classRank = "";
        }

        public Student(string first, string last, string classLevel) : base(first, last)
        {
            classRank = classLevel;
        }

        public string ClassRank
        {
            get { return classRank; }
            set { classRank = value; }
        }

        public override string ToString()
        {
            return "Student: " + this.FirstName + " " + this.LastName + " " + this.ClassRank;
        }


    }
}
