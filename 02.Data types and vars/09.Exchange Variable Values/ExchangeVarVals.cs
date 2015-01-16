﻿//Problem 9. Exchange Variable Values

//    Declare two integer variables a and b and assign them with 5 and 10 
//    and after that exchange their values by using some programming logic.
//    Print the variable values before and after the exchange.


using System;

class ExchangeVarVals
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Before exchange:");
        Console.Write("a = {0}", a);
        Console.Write(" and b = {0}", b);
        Console.WriteLine();


        int c = a;
        a = b;
        b = c;

        Console.WriteLine("After exchange:");
        Console.Write("a = {0}", a);
        Console.Write(" and b = {0}", b);
        Console.WriteLine();

    
    }
}

