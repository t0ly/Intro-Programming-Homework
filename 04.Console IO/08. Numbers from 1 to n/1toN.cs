/*
 * 8. Numbers from 1 to n

    Write a program that reads an integer number n from the console 
 * and prints all the numbers in the interval [1..n], 
 * each on a single line.
*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Numbers1toN
{
    static void Main(string[] args)
    {
        Console.WriteLine("Prints all the numbers in the interval [1..n]");
        Console.WriteLine("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    
    }
}