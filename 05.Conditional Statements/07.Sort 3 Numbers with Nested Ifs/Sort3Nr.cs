/*7. Sort 3 Numbers with Nested Ifs

    Write a program that enters 3 real numbers and prints them sorted in descending order.
        Use nested if statements.

Note: Don’t use arrays and the built-in sorting functionality.
 */

using System;

class Sort3Nr
{
    static void Main(string[] args)
    {
        Console.WriteLine("Sorts three numbers.");
        Console.Write("first number = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("second number = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("third number = ");
        double c = double.Parse(Console.ReadLine());

        double smallest = a;
        double middle = b;
        double largest = c;
        double temp = 0;

        if (smallest.CompareTo(largest) < 0)                        //when outer numbers are a < c
        {
            if (smallest.CompareTo(middle) > 0)
            {
                temp = smallest; smallest = middle; middle = temp;  //swap mid and smallest if necessary
            }
            if (largest.CompareTo(middle) < 0)
            {
                temp = largest; largest = middle; middle = temp;     //swap largest and middle if neceessary
            }
        }
        else
        {
            temp = smallest; smallest = largest; largest = temp;        //swap outer numbers since a > c

            if (smallest.CompareTo(middle) > 0)
            {
                temp = smallest; smallest = middle; middle = temp;      //swap mid and smallest if necessary
            }
            if (largest.CompareTo(middle) < 0)
            {
                temp = largest; largest = middle; middle = temp;        //swap mid and largest if necessary
            }
        }


        Console.WriteLine(largest + " " + middle + " " + smallest);
    }
}