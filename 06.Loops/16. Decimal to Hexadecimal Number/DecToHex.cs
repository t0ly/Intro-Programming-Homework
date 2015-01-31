using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Decimal_to_Hexadecimal_Number
{
    class DecToHex
    {

        /// <summary>
        /// 16. Decimal to Hexadecimal Number
        /// Using loops write a program that converts an integer number to its hexadecimal representation.
        /// The input is entered as long. The output should be a variable of type string.
        /// Do not use the built-in .NET functionality.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            

            Console.WriteLine("Converts an integer number to its hexadecimal representation.");
            Console.Write("Enter integer: ");
            long input = long.Parse(Console.ReadLine().Trim());

            long dividend = input;
            string tmpHex = "";
            int counter = 0;

            while (dividend != 0)
            {
                tmpHex += ToHex(dividend % 16);
                dividend = dividend / 16;
                counter++;
            }

            Console.Write("decimal {0} = hex ", input);
            for (int i = counter - 1; i >= 0; i--)
            {
                Console.Write(tmpHex[i]);
            }
            Console.WriteLine();
        }


        static string ToHex(long decimalnr)
        {

            string hexdigit = "";

            switch (decimalnr)
            {
                case 0: hexdigit = "0"; break;
                case 1: hexdigit = "1"; break;
                case 2: hexdigit = "2"; break;
                case 3: hexdigit = "3"; break;
                case 4: hexdigit = "4"; break;
                case 5: hexdigit = "5"; break;
                case 6: hexdigit = "6"; break;
                case 7: hexdigit = "7"; break;
                case 8: hexdigit = "8"; break;
                case 9: hexdigit = "9"; break;
                case 10: hexdigit = "A"; break;
                case 11: hexdigit = "B"; break;
                case 12: hexdigit = "C"; break;
                case 13: hexdigit = "D"; break;
                case 14: hexdigit = "E"; break;
                case 15: hexdigit = "F"; break;

                default: break;
            }

            return hexdigit;

        }
    }
}
