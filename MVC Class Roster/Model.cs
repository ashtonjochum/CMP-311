using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassRoster;

namespace MVC_Class_Roster
{
    class rosterModel
    {

        private Instructor teacher;
        private List<Student> studentList;
        private List<Student> studentListSortable;
        public rosterModel() 
        { 
            teacher = new Instructor();
            studentList = new List<Student>();
            studentListSortable = new List<Student>();
        }

        public void setInstructor(string firstName, string lastName, string contactInfo)
        {
            teacher.FirstName = firstName;
            teacher.LastName = lastName;
            teacher.ContactInfoformation = contactInfo;
        }

        public Person getInstructor()
        {
            return teacher;
        }

        public void addStudent(string firstName, string lastName, string classRank)
        {
            studentList.Add(new Student(firstName, lastName, classRank));
            studentListSortable.Add(new Student(firstName, lastName, classRank));
        }


        public string personToString(Person individual)
        {
            return individual.ToString();
        }

        public List<Student> getStudentList()
        {
            return studentList;
        }

        
        public List<Student> sortedStudentList(string sortOp)
        {
            if (sortOp == "last")
            {               
                studentListSortable.Sort((x, y) => string.Compare(x.LastName, y.LastName));
            }
            else if (sortOp == "rank")
            {
                studentListSortable.Sort((x, y) => string.Compare(x.ClassRank, y.ClassRank));    
            }
            return studentListSortable;
        }
        
    }
}