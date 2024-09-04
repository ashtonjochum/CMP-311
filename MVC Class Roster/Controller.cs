using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassRoster;

namespace MVC_Class_Roster
{
    class rosterController
    {
        public rosterController()
        {
            rosterView rosterViewTemp = new rosterView();
            rosterModel rosterModelTemp = new rosterModel();



            // get and set instructor information
            rosterViewTemp.printOut("Instructor First Name: ");
            string fN = rosterViewTemp.getInfo();
            rosterViewTemp.printOut("Instructor Last Name: ");
            string lN = rosterViewTemp.getInfo();
            rosterViewTemp.printOut("Instructor Contact Information: ");
            string cI = rosterViewTemp.getInfo();

            rosterModelTemp.setInstructor(fN, lN, cI);

            Boolean run = true;

            while(run)
            {
                string op = rosterViewTemp.printFirstOptions();
                if (op == "1")
                {
                    //add new student to list
                    rosterViewTemp.printOut("Student First Name: ");
                    string firNa = rosterViewTemp.getInfo();

                    string lasNa = "";

                    while (lasNa == "")
                    {
                        rosterViewTemp.printOut("Student Last Name: ");
                        lasNa = rosterViewTemp.getInfo();
                        if (lasNa == "")
                        {
                            rosterViewTemp.printOut("Error! Input valid last name!");
                        }
                    }

                    string claRa = "";

                    while (claRa == "")
                    {
                        rosterViewTemp.printOut("Student Class Rank: ");
                        claRa = rosterViewTemp.getInfo();
                        if (claRa == "")
                        {
                            rosterViewTemp.printOut("Error! Input valid class rank!");
                        }
                    }

                    rosterModelTemp.addStudent(firNa, lasNa, claRa);

                }
                else if (op == "2")
                {
                    //list view options/sorting
                    string opt = rosterViewTemp.printSecondOptions();
                    if (opt == "a")
                    {
                        rosterViewTemp.printOut(rosterModelTemp.personToString(rosterModelTemp.getInstructor()));
                        foreach (Student s in rosterModelTemp.getStudentList())
                        {
                            rosterViewTemp.printOut(rosterModelTemp.personToString(s));
                        }
                    }
                    else if (opt == "b")
                    {
                        rosterViewTemp.printOut(rosterModelTemp.personToString(rosterModelTemp.getInstructor()));
                        foreach (Student s in rosterModelTemp.sortedStudentList("last"))
                        {
                            rosterViewTemp.printOut(rosterModelTemp.personToString(s));
                        }
                    }
                    else if (opt == "c")
                    {
                        rosterViewTemp.printOut(rosterModelTemp.personToString(rosterModelTemp.getInstructor()));
                        foreach (Student s in rosterModelTemp.sortedStudentList("rank"))
                        {
                            rosterViewTemp.printOut(rosterModelTemp.personToString(s));
                        }
                    }
                    else
                    {
                        rosterViewTemp.printOut("Error in reading input, please try again!");
                    }
                }
                else if (op == "3")
                {
                    rosterViewTemp.printOut("Ending program...");
                    run = false;
                }
                else
                {
                    rosterViewTemp.printOut("Error in reading input, please try again!");
                }
            }
        }









    }
}
