/* 
 * 9. Sum of n Numbers
    Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. 
 *  Note: You may need to use a for-loop.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SumN
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write any number of digits to sum, separated by a space: ");
        double[] input = Console.ReadLine().Split(' ').Select(x => double.Parse(x)).ToArray();

        double sum = 0;

        foreach (var x in input)
        {
            sum = sum + x;
        }

        Console.WriteLine("Sum of the {0} numbers is {1}", input.Length, sum);
    
    }
}