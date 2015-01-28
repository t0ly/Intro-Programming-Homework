/*
 * 5. The largest of 3 Numbers

    Write a program that finds the largest of three numbers.
*/

using System;


class LargestOf3
{
    static void Main(string[] args)
    {
        Console.WriteLine("Finds the largest of the three numbers.");
        Console.Write("first number = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("second number = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("third number = ");
        double c = double.Parse(Console.ReadLine());


        double largest = a;

        if (largest.CompareTo(b) < 0)
        {
            largest = b;
        }
        if (largest.CompareTo(c) < 0)
        {
            largest = c;
        }
        Console.WriteLine("Largest number is {0}", largest);
    }
}