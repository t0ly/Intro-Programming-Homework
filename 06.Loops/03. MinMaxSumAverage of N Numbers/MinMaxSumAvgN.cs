using System;
using System.Collections.Generic;
using System.Linq;


class MinMaxSumAvgN
{
    /// <summary>
    /// 3. Min, Max, Sum and Average of N Numbers

    /// Write a program that reads from the console a sequence of n integer numbers and returns 
    /// the minimal, the maximal number, the sum and the average of all numbers 
    /// (displayed with 2 digits after the decimal point).
    /// The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
    /// The output is like in the examples below.

    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a sequence of n integers, separated by newline. End with a dot \".\": ");

        List<double> numbers = new List<double>();        //will collect the numbers

        while (true)
        {
            String input = Console.ReadLine();
            if (input == ".")    //notadigit.Matches(input) != null
            {
                break;
            }
            else
            {
                numbers.Add(double.Parse(input));
            }
        }


        Console.WriteLine();
        Console.WriteLine("Max is {0}", numbers.Max());
        Console.WriteLine("Min is {0}", numbers.Min());
        Console.WriteLine("Avg is {0}", numbers.Average());
        Console.WriteLine("Sum is {0}", numbers.Sum());
        Console.WriteLine("Chao Chao!");


    }
}