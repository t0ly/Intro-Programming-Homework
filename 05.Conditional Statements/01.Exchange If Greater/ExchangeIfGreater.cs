/*
 * 1. Exchange If Greater

    Write an if-statement that takes two double variables a and b 
 *  and exchanges their values if the first one is greater than the second one. 
 *  As a result print the values a and b, separated by a space.
*/

using System;

class ExchangeIfGreater
{
    static void Main(string[] args)
    {
        Console.Write("Exchange the value of variables if first one is larger than the second\na = ");
        double a = double.Parse(Console.ReadLine());
        
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        
        double c = 0;

        if (a - b > 0 )
        {
            c = a;
            a = b;
            b = c;                       
        }
 
        Console.WriteLine(a + " " + b);
  

    }
}