/*
 * 1. Sum of 3 Numbers

    Write a program that reads 3 real numbers from the console and prints their sum.
*/

using System;

class Sum3
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter 3 numbers to sum them:");
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("Sum is {0}", a + b + c);
    }
}