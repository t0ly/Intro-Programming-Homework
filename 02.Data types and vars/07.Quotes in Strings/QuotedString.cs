﻿
//Problem 7. Quotes in Strings

//    Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
//    Do the above in two different ways - with and without using quoted strings.
//    Print the variables to ensure that their value was correctly defined.

using System;

class QuotedString
{
    static void Main(string[] args)
    {
        string strVar1 = "The \"use\" of quotations causes difficulties.";
        string strVar2 = @"The ""use"" of quotations causes difficulties.";
       
        Console.WriteLine("strVar1 = {0}", strVar1);
        Console.WriteLine("strVar2 = {0}", strVar2);
        
        //string strVar3 = @"
        //   *
        //  * *
        // *   *
        //* * * *
        //   *    "
        //                ;
        //Console.WriteLine(strVar3);

    }
}
