using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Calculate_NfactorialDividedbyKfactorial
{
    class CalcNfacDivKfac
    {
        /// <summary>
        /// Problem 6. Calculate N! / K!
        /// Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
        /// Use only one loop.

        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int n = 1;
            int k = 1;
            decimal nfactorial = 1m;
            decimal kfactorial = 1m;

            Console.WriteLine("Calculate N! / K! (k < n)");
            while (true)
            {
                Console.Write("n: ");
                n = int.Parse(Console.ReadLine());
                Console.Write("k: ");
                k = int.Parse(Console.ReadLine());
                if (k < n && n < 100)
                {
                    break;
                }
                Console.WriteLine("Sorry, try again! 0 < k < n < 1000");
            }

            
            for (int i = 1, j = 1;  j <= n; i++, j++)
            {
                nfactorial *= j;
                
                if (i <= k)
                {
                    kfactorial *= i;
                } 
            }

            Console.Write("{0} / {1} = {2}", nfactorial, kfactorial, nfactorial / kfactorial);
            Console.WriteLine();

        }
    }
}
