/* 6. The Largest of Five Numbers

    Write a program that finds the biggest of five numbers by using only five if statements.

 */

using System;

class LargestOf5
{
    static void Main(string[] args)
    {

        Console.WriteLine("Finds the largest of five numbers.");
        Console.Write("first number = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("second number = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("third number = ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("fourth number = ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("fifth number = ");
        double e = double.Parse(Console.ReadLine());

        double max = 0;

        //option 1: check each if it's  a > b > c > d > e
        // Need to use double.Compareto(double) because of the float comparison problem
        if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0 && a.CompareTo(b) > 0 && a.CompareTo(e) > 0)
        {
            max = a;
        }
        if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0 && b.CompareTo(d) > 0 && b.CompareTo(e) > 0)
        {
            max = b;
        }
        if (c.CompareTo(a) > 0 && c.CompareTo(b) > 0 && c.CompareTo(d) > 0 && c.CompareTo(e) > 0)
        {
            max = c;
        }
        if (d.CompareTo(a) > 0 && d.CompareTo(b) > 0 && d.CompareTo(c) > 0 && d.CompareTo(e) > 0)
        {
            max = d;
        }
        if (e.CompareTo(a) > 0 && e.CompareTo(b) > 0 && e.CompareTo(c) > 0 && e.CompareTo(d) > 0)
        {
            max = e;
        }

        Console.WriteLine("The largest number by method 1 is {0}", max);
      


        //option 2: assign largest number to a dynamic variable - uses 4 IFs! :)
        double largest = a;

        if (b.CompareTo(largest) > 0)
        {
            largest = b;
        }
        if (c.CompareTo(largest) > 0)
        {
            largest = c;
        }
        if (d.CompareTo(largest) > 0)
        {
            largest = d;
        }
        if (e.CompareTo(largest) > 0)
            largest = e;

        Console.WriteLine("The largest number by method 2 is {0}", largest);
    }
}