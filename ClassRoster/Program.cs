using System.ComponentModel.Design;
using ClassRoster;

class Program
{//github testing
    static void Main(string[] args)
    {
        Instructor teacher = new Instructor(); // makes a new blank Instructor
        Console.Write("Input instructor's first name: "); //prompt
        teacher.FirstName = Console.ReadLine();
        Console.Write("Input instructor's last name: "); //prompt
        teacher.LastName = Console.ReadLine();
        Console.Write("Input instructor's contact information: "); //prompt
        teacher.ContactInfoformation = Console.ReadLine();
        Console.Write("\n");
        Console.Write("\n");


        Boolean run = true; //presets a variable as true to start a later while loop

        List<Student> studentsList = new List<Student>(); //makes a list to be added to later
        List<Student> studentsListAsEnter = new List<Student>(); //makes a list to be added to later and never changed

        while (run)
        {
            Console.WriteLine("Please make a selection:"); //prompt
            Console.WriteLine("1: Add student"); //prompt
            Console.WriteLine("2: See list"); //prompt
            Console.WriteLine("3: End app"); //prompt
            Console.Write("Selection: "); //prompt
            string userInput = Console.ReadLine();
            Console.Write("\n");
            Console.Write("\n");


            if (userInput == "1") //if UI is 1 then run the following
            {
                Student student = new Student(); // makes a new blank Student
                Console.Write("Input student's first name: "); //prompt
                student.FirstName = Console.ReadLine();
                
                while (student.LastName == "") //line to keep running until student has a valid iput for a last name
                {
                    Console.Write("Input students's last name: "); //prompt
                    student.LastName = Console.ReadLine();
                    if (student.LastName == "")
                    {
                        Console.WriteLine("Please enter a valid last name!");
                    }
                }
                
                while (student.ClassRank == "") //line to keep running until student has a valid iput for a class rank
                {
                    Console.Write("Input student's class rank: "); //prompt
                    student.ClassRank = Console.ReadLine();
                    if (student.ClassRank == "")
                    {
                        Console.WriteLine("Please enter a valid class rank!");
                    }
                }
                
                studentsList.Add(student); //Adds the student to the list
                studentsListAsEnter.Add(student); //ditto
                Console.Write("\n");
                Console.Write("\n");
            }
            else if (userInput == "2") //if UI is 2 then run the following
            { //the following is a selection panel to allow the user to choose how the list is sorted
                Console.WriteLine("Please make a selection on"); //prompt
                Console.WriteLine("how to sort the list: "); //promp
                Console.WriteLine("a: As entered"); //prompt
                Console.WriteLine("b: By student last name"); //prompt
                Console.WriteLine("c: By student class rank"); //prompt
                Console.Write("Selection: "); //prompt
                string userInputTwo = Console.ReadLine().ToLower();
                Console.Write("\n");
                Console.Write("\n");

                if(userInputTwo == "a") //outputs the list as entered
                {
                    Console.WriteLine(teacher);
                    foreach (Student s in studentsListAsEnter)
                    {
                        Console.WriteLine(s);
                    }
                    Console.Write("\n");
                    Console.Write("\n");
                }
                else if(userInputTwo == "b")//outputs the list as sorted by last name
                {
                    studentsList.Sort((x, y) => string.Compare(x.LastName, y.LastName));
                    Console.WriteLine(teacher);
                    foreach (Student s in studentsList)
                    {
                        Console.WriteLine(s);
                    }
                    Console.Write("\n");
                    Console.Write("\n");
                }
                else if (userInputTwo == "c") //outputs the list as sorted by class rank
                {
                    studentsList.Sort((x, y) => string.Compare(x.ClassRank, y.ClassRank));
                    Console.WriteLine(teacher);
                    foreach (Student s in studentsList)
                    {
                        Console.WriteLine(s);
                    }
                    Console.Write("\n");
                    Console.Write("\n");
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    Console.Write("\n");
                    Console.Write("\n");
                }


            }
            else if (userInput == "3") //if UI is 3 then run the following
            {
                Console.WriteLine("Goodbye!");
                Console.Write("\n");
                Console.Write("\n");
                run = false; //changes the run variable to false to stop the while loop



            }
            else //if user input in not valid then run following
            {
                Console.WriteLine("Invalid Input");
                Console.Write("\n");
                Console.Write("\n");
            }
        }
    }
}