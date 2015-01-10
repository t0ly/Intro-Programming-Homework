using System;

class AgeAfter10Years
{
    static void Main(string[] args)
    {
        
        //Ask user for DOB
        Console.WriteLine("What is your date of birth (MM/DD/YYYY)?");
        string DOBunparsed = Console.ReadLine();
        DateTime DOBparsed;
        DateTime.TryParse(DOBunparsed, out DOBparsed);
        Console.WriteLine(DOBparsed);
        
        Console.WriteLine("Your age now is " + (System.DateTime.Now.Date - DOBparsed));

    }
}
