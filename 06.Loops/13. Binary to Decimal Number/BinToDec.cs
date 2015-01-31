using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Binary_to_Decimal_Number
{
    class BinToDec
    {
        /// <summary>
        /// Using loops write a program that converts a binary integer number to its decimal form.
        /// The input is entered as string. The output should be a variable of type long.
        /// Do not use the built-in .NET functionality.

        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            long decimalresult = 0;

            Console.WriteLine("converts a binary integer number to its decimal form.");
            Console.Write("Enter binary integer: ");


            string input = Console.ReadLine().Trim();


            for (int i = 0; i < input.Length; i++)
            {
                decimalresult += long.Parse(input[i].ToString()) * (long)Math.Pow(2, input.Length - (i + 1));
                Console.WriteLine(long.Parse(input[i].ToString()) + "\t" + "2^" + (input.Length - (i + 1)) + " \t " + decimalresult);
            }

            Console.WriteLine("Binary {0} = decimal {1}", input, decimalresult);


        }
    }
}
