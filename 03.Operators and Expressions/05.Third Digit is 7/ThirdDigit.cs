//Problem 5. Third Digit is 7?

//    Write an expression that checks for given integer if its third digit from right-to-left is 7.

//Examples:
//n 	Third digit 7?
//5 	false
//701 	true
//9703 	true
//877 	false
//777877 	false
//9999799 	true

using System;



class ThirdDigit
{
    static void Main(string[] args)
    {
        int digit = 5;
        int tmp = digit / 100;  //move the comma 2 digits left
        tmp = tmp % 10;         //move comma 1 digit (or coveted third digit) and remember it
        bool thirdDigitIs7 = tmp == 7;  //compare
        Console.WriteLine("{0} has 7 as its third digit? {1}", digit, thirdDigitIs7);
    }

}