/*
 * 7. Sum of 5 Numbers
    Write a program that enters 5 numbers 
 * (given in a single line, separated by a space), 
 * calculates and prints their sum.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Sum5nr
{
    static void Main(string[] args)
    {

        Console.WriteLine("Write 5 numbers to sum, separated by a space: ");
        double[] input = Console.ReadLine().Split(' ').Select(x => double.Parse(x)).ToArray();

        double sum = 0;

        foreach (var x in input)
        {
            sum = sum + x;
        }

        Console.WriteLine("Sum of the numbers is {0}", sum);
    }
}