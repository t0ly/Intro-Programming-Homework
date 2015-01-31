using System;

class MatrixOfNr
{
    /// <summary>
    /// Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) 
    /// and prints a matrix like in the examples below. Use two nested loops.
    /// 
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {

        int n = 0;

        Console.WriteLine("Matrix of numbers, given a positive integer 0 ≤ n ≤ 20");
        while (true)
        {
            Console.Write("n: ");
            n = int.Parse(Console.ReadLine());
            if (0 <= n && n <= 20)
            {
                break;
            }
            Console.WriteLine("Sorry, try again! 0 ≤ n ≤ 20");
        }


        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j < n; j++)
            {

                Console.Write("{0,2}   ", i + j);

            }
            Console.WriteLine();

        }


    }
}