/*
 * 10. Fibonacci Numbers

    Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
    (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 
 */

using System;


class Fibonnaci
{
    static void Main(string[] args)
    {
        Console.WriteLine("This program prints N Fibonnaci numbers.");
        Console.WriteLine("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        int f0 = 0;
        int f1 = 1;

        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(" {0}, {1},", f0, f1);
            f0 = f0 + f1;
            f1 = f0 + f1;
        }    
    }
}