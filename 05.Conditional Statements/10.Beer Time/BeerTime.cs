/*10.* Beer Time

    A beer time is after 1:00 PM and before 3:00 AM.
    Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) 
    and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed. Note: You may need to learn how to parse dates and times.
*/

using System;
using System.Globalization;

class BeerTime
{


    static void Main(string[] args)
    {

        Console.Write("Enters a time in format hh:mm AM (or PM): ");
        DateTime inputTime = DateTime.Parse(Console.ReadLine());
       
        DateTime beerTimeStart = DateTime.Parse("1:00 PM");  
        DateTime beerTimeEnd =  DateTime.Parse("3:00 AM").AddDays(1);


        if (inputTime > beerTimeStart && inputTime < beerTimeEnd)
        {
            Console.WriteLine("beer time");
        }
        else
        {
            Console.WriteLine("non-beer time");
        }
    }
}