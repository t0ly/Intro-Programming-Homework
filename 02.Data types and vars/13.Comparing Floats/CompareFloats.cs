//Problem 13.* Comparing Floats

//    Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.

//Note: Two floating-point numbers a and b cannot be compared directly by a == b 
// because of the nature of the floating-point arithmetic. 
// Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.

using System;
using System.Globalization;


class CompareFloats
{
    static void Main(string[] args)
    {
        double a = 5.00000001;
        double b = 5.00000005;
        float precision = 0.000001f;
        bool isEqual = Math.Abs(a - b) < precision;

        if (isEqual)
            Console.WriteLine("{0} is equal to {1} with precision {2}.", a, b, precision.ToString("f6", CultureInfo.InvariantCulture));  
        else
            Console.WriteLine("{1} is not equal to {0} with precision {2}.", a, b, precision.ToString("f6", CultureInfo.InvariantCulture));

    }
}
