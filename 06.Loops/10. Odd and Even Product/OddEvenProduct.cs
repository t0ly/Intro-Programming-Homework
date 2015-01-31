using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Odd_and_Even_Product
{
    class OddEvenProduct
    {
        /// <summary>
        ///  10. Odd and Even Product
        ///  You are given n integers (given in a single line, separated by a space).
        ///  Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
        ///  Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            decimal producteven = 1;
            decimal productodd = 1;
          

            Console.WriteLine("Enter a sequence of n integers, separated by space: ");
            //String input = Console.ReadLine();

            //List<double> numbers = new List<double>();        //will collect the numbers
            string[] input = Console.ReadLine().Trim().Split(' ');
            foreach (string nr in input)
            {
                if (int.Parse(nr) % 2 == 0)
                {
                    producteven *= int.Parse(nr);
                }
                else
                {
                    productodd *= int.Parse(nr);
                }
            }
            string isequal = (productodd == producteven) ? "is equal" : "is NOT equal";
            Console.WriteLine("The product of even numbers {0} {1} the product of odd {2}", producteven, isequal, productodd);


        }
    }
}
