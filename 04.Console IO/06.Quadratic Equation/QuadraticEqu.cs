/*
 * 
 * 6. Quadratic Equation

    Write a program that reads the coefficients a, b and c 
    of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class QuadraticEqu
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the 3 coefficients of the quadratic equation ax^2 + bx + c = 0");
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        //Console.WriteLine();
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        //Console.WriteLine();
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("Equation {0}x^2+{1}x+{2}=0", a, b, c);


        double x1 = ((-b) - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
        double x2 = ((-b) + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);

        if (double.IsNaN(x1) || double.IsNaN(x2))
            Console.Write(" has no real roots!");
        else
            Console.Write(" has real roots x1 = {0:f2}, x2 = {1:f2}", x1, x2);

        Console.WriteLine();


        
    }
}