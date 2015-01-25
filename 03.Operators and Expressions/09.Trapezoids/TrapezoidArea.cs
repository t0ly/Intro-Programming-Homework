//Problem 9. Trapezoids

//    Write an expression that calculates trapezoid's area by given sides a and b and height h.

//Examples:
//a 	b 	h 	area
//5 	7 	12 	72
//2 	1 	33 	49.5
//8.5 	4.3 	2.7 	17.28
//100 	200 	300 	45000
//0.222 	0.333 	0.555 	0.1540125


using System;

class TrapezoidArea
{
    static void Main(string[] args)
    {

        Console.Write("Please enter trapezoid top width: ");
        double a = double.Parse(Console.ReadLine());    // 8.5;
        Console.Write("Please enter trapezoid base width: ");
        double b = double.Parse(Console.ReadLine());    //4.3;
        Console.Write("Please enter trapezoid height: ");
        double h = double.Parse(Console.ReadLine());    //2.7;

        double area = (a + b) * h / 2;

        Console.WriteLine("Area of trapezoid with sides {0}, {1}, and height {2} is {3}.", a, b, h, area);
    
    }
}