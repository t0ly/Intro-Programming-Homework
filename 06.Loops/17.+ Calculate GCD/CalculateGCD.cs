using System;


class CalculateGCD
{
    /// <summary>
    /// 17.* Calculate GCD

    /// Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
    /// Use the Euclidean algorithm (find it in Internet).

    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
        {

 
        // our numbers
        int a = 1;
        int b = 1;
        
        
        //get input        
        Console.WriteLine("Calculates the greatest common divisor (GCD) of given two integers a and b.");
        while(true)
        {
            Console.Write("a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            b = int.Parse(Console.ReadLine());
            if(a != b && a > 0 && b > 0)
            {
               break; 
            }
        }

   
        if(a < b)  //put the larger first
        {
            int c = a;
            a = b;
            b = c;

            Console.WriteLine("a = {0}; b = {1}", a, b);
        }

        int remainder = 1;
 
        // our formula is 
        //a = quotent * b + remainder
        //
        //a = q0 b + r0
        //b = q1 r0 + r1
        //r0 = q2 r1 + r2
        //r1 = q3 r2 + r3

        Console.WriteLine("Calculating...");
        while( remainder != 0)
        {
            remainder = a % b;
            a = b;
            b = remainder;

        }


          Console.WriteLine("Greatest Common Denominator is {0}", a);
        }
}