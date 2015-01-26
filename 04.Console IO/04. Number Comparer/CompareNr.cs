/*
 * 
 * 4. Number Comparer

    Write a program that gets two numbers from the console and prints the greater of them.
    Try to implement this without if statements.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CompareNr
{
    static void Main(string[] args)
        {
            
            Console.WriteLine("Enter two numbers to compare separated by space:");

            int[] input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            int max = (input[0]  + input[1] + Math.Abs(input[0] - input[1])) / 2;

            Console.WriteLine("The larger of the two is {0}", max);

        }
}