//Problem 7. Print First and Last Name
//    Create console application that prints your first and last name, each at a separate line.


using System;

class PrintFirstLastName
{
    static void Main()
    {
            Console.WriteLine("What is your FIRST name?");
            string FirstName = Console.ReadLine();
            Console.WriteLine("What is your LAST name?");
            string LastName = Console.ReadLine();

            Console.WriteLine("\r\nYour names are:");
            Console.WriteLine(FirstName);
            Console.WriteLine(LastName);
    }
}
