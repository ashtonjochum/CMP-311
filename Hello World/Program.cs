// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");
Console.WriteLine("This is cool!");

Console.Write("What is your name? ");
string userName = Console.ReadLine();
Console.WriteLine("Hello " + userName + "!");

int theNum;
do
{
    Console.Write("Please enter a number (1-10): ");
    theNum = Int32.Parse(Console.ReadLine());
    if (theNum < 1 || theNum > 10)
        Console.WriteLine("Invalid Number");
} while ((theNum < 1) || (theNum > 10));
Console.WriteLine("The number is " + theNum);