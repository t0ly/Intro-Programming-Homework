/*
 * 4. Multiplication Sign

    Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
        Use a sequence of if operators.
*/

using System;

class MultiplicationSign
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculates the sign of the product of 3 real numbers");
        Console.Write("first number = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("second number = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("third number = ");
        double c = double.Parse(Console.ReadLine());

        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("0");
        }
        else if (a < 0 ^ b < 0 ^ c < 0)
        {
            Console.WriteLine("-");
        }
        else
        {
            Console.WriteLine("+");
        }
    
    }
}