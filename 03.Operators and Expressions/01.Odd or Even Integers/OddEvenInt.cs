//Problem 1. Odd or Even Integers

//    Write an expression that checks if given integer is odd or even.

//Examples:
//n 	Odd?
//3 	true
//2 	false
//-2 	false
//-1 	true
//0 	false


using System;


class OddEvenInt
{
    static void Main(string[] args)
    {

                     
        Console.WriteLine(@"//Problem 1. Odd or Even Integers
//    Write an expression that checks if given integer is odd or even.
//Examples:
//n 	Odd?
//3 	true
//2 	false
//-2 	false
//-1 	true
//0 	false
");
        Console.WriteLine("Number\tOdd");
        Console.WriteLine("--------------");

        int[] testnumbers = new int[] { 3, 2, -2, -1, 0 };

        foreach (int i in testnumbers)
        {
            bool isOdd = (i % 2 == 0) ? false : true;
            Console.WriteLine("{0}\t{1}", i, isOdd);

        }

    }
}