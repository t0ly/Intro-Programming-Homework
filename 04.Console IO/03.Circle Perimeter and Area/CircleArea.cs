/*
 * Problem 3. Circle Perimeter and Area

    Write a program that reads the radius r of a circle 
 * and prints its perimeter 
 * and area formatted with 2 digits after the decimal point.

Examples:
r 	perimeter 	area
2 	12.57 	12.57
3.5 	21.99 	38.48
 */

using System;

class CircleArea
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter radius of the circle: ");            
            double r;
            bool rIsNumber = double.TryParse(Console.ReadLine(), out r);
            Console.WriteLine("Area of circle = {0:##.##} and perimiter = {1:##.##}", r * r * Math.PI, 2 * Math.PI * r);

        }
    }

