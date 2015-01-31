using System;

class CalcSumNX
{
    /// <summary>
    /// Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
    /// Use only one loop. Print the result with 5 digits after the decimal point.

    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {


        decimal sum = 1;
        decimal factorial = 1m;

        Console.WriteLine("sum = 1 + 1!/x + 2!/x2 + … + n!/x^n");
        Console.Write("n: ");

        int n = int.Parse(Console.ReadLine());
        Console.Write("x: ");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write(" 1 + ");
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            checked { sum += factorial / (decimal)Math.Pow(x, i); }

            String sign = (i ==n)? " = " : " + ";
            Console.Write("{0} / {1} {2} ", factorial, x, sign);
        }

        Console.Write("{0,2:f5}", sum);
        Console.WriteLine();
    }
}