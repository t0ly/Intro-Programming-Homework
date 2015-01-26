﻿/*
 * 5. Formatting Numbers

    Write a program that reads 3 numbers:
        integer a (0 <= a <= 500)
        floating-point b
        floating-point c
    The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
        The number a should be printed in hexadecimal, left aligned
        Then the number a should be printed in binary form, padded with zeroes
        The number b should be printed with 2 digits after the decimal point, right aligned
        The number c should be printed with 3 digits after the decimal point, left aligned.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Formatting_Numbers
{
    class FormattingNr
    {
        static void Main(string[] args)
        {

            Console.Write("Enter int a :");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter float b :");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Enter float c :");
            float c = float.Parse(Console.ReadLine());

            Console.WriteLine("0x{0,-10:X}|{1,10:D8}|{2,10:f2}|{3,-10:f3}", a, Convert.ToString(a, 2).PadLeft(8,'0'), b, c);
            


        }
    }
}
