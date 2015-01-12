//Problem 15.* Age after 10 Years
//    Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

using System;
using System.Globalization; //
using System.Threading;     //

class AgeAfter10Years
{
    static void Main(string[] args)
    {
        //Set the date format
        CultureInfo bg = new CultureInfo("bg-BG");
        Thread.CurrentThread.CurrentCulture = bg;





        //Ask user for DOB and save input into strings   
        Console.WriteLine("What is your date of birth? ");
        DateTime DOB = DateTime.Parse(Console.ReadLine());
        
        //Calculate birthdate
        int Age = DateTime.Now.Year - DOB.Year;
        //Check if birthday didn't pass
        if (DateTime.Now.Month < DOB.Month && DateTime.Now.Day < DOB.Day)
            Age--;
        
        //Tell the user her age
        Console.WriteLine("Your age now is {0}", Age);
        Console.WriteLine("Your age in 10 years will be {0}", (Age + 10));

    }
}
