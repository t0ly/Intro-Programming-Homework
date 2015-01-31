using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Catalan_Numbers
{
    class CatalanNr
    {
        /// <summary>
        /// 8. Catalan Numbers
        /// 
        ///  In combinatorics, the Catalan numbers are calculated by the following formula: 
        ///  catalan = (2n)! / ( (n + 1)! * n! )
        ///  Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100). 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int n = 1;
            decimal n2factorial = 1m;
            decimal nplus1factorial = 1m;
            decimal nfactorial = 1m;
            decimal catalan = 0;

            Console.WriteLine("Calculate Catalan number, given 0 ≤ n ≤ 100");
            while (true)
            {
                Console.Write("n: ");
                n = int.Parse(Console.ReadLine());              
                if ( 0 <= n && n <= 100)
                {
                    break;
                }
                Console.WriteLine("Sorry, try again! 0 ≤ n ≤ 100");
            }

            for (int i = 1; i <= 2 * n ; i++)
            {

                n2factorial *= i;

                //n!
                if (i <= n)
                {
                    nfactorial *= i;
                }

                //(n + 1)!
                if (i <= (n + 1))
                {
                    nplus1factorial *= i;
                }

            }


            checked { catalan = n2factorial / (nplus1factorial * nfactorial); }

            Console.Write("{0} / ({1} * {2}) = {3}", n2factorial, nplus1factorial, nfactorial, catalan);
            Console.WriteLine();

        }
    }
}
