//Problem 6. Four-Digit Number

//    Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//        Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//        Prints on the console the number in reversed order: dcba (in our example 1102).
//        Puts the last digit in the first position: dabc (in our example 1201).
//        Exchanges the second and the third digits: acbd (in our example 2101).

//The number has always exactly 4 digits and cannot start with 0.

//Examples:
//n 	sum of digits 	reversed 	last digit in front 	second and third digits exchanged
//2011 	4 	1102 	1201 	2101
//3333 	12 	3333 	3333 	3333
//9876 	30 	6789 	6987 	9786


using System;

class FourDigitNr
{

    static void Main(string[] args)
    {
        int myNumber = 0;
        string usrInput = null;


        //Get user input and some simple checks
        while (true)
        {
            Console.WriteLine("Enter a number exactly 4 digits long (not starting with 0):");
            usrInput = Console.ReadLine();

            myNumber = 0;
            bool lengthCheckOK = (usrInput.Length == 4) ? true : false;
            bool startsWith0 = usrInput.StartsWith("0");
            bool usrInputIsNumber = int.TryParse(usrInput, out myNumber);

            
            if (lengthCheckOK && !startsWith0 && usrInputIsNumber)
                break;

        }
        
        //Split the digits
        int d = myNumber % 10;
        int c = (myNumber / 10) % 10;
        int b = (myNumber / 100) % 10;
        int a = (myNumber / 1000);

        //        Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
        Console.WriteLine("Sum of digits in {0} is {1}", myNumber, a + b + c + d);

        //        Prints on the console the number in reversed order: dcba (in our example 1102).
        Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);

        //        Puts the last digit in the first position: dabc (in our example 1201).
        Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);

        //        Exchanges the second and the third digits: acbd (in our example 2101).
        Console.WriteLine("{0}{1}{2}{3}", a, c, b, d); 
    }
}