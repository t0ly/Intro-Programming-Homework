//Problem 4. Rectangles

//    Write an expression that calculates rectangle’s perimeter and area by given width and height.

//Examples:
//width 	height 	perimeter 	area
//3 	4 	14 	12
//2.5 	3 	11 	7.5
//5 	5 	20 	25


using System;

class Rectangles
{
    static void Main(string[] args)
    {
        double width = 2.5;
        double height = 3;
        double perimiter = width * 2 + height * 2;
        double area = width * height;

        Console.WriteLine("Rectangle {0} wide and {1} high has perimeter {2} and area {3}.", width, height, perimiter, area);
    
    }
}
