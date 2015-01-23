/**
* Problem 10. Point Inside a Circle & Outside of a Rectangle

Write an expression that checks for given point (x, y) 
if it is within the circle K({1, 1}, 1.5) 
and out of the rectangle R(top=1, left=-1, width=6, height=2).

Examples:
x 	y 	inside K & outside of R
1 	2 	yes
2.5 	2 	no
0 	1 	no
2.5 	1 	no
2 	0 	no
4 	0 	no
2.5 	1.5 	no
2 	1.5 	yes
1 	2.5 	yes
-100 	-100 	no
*/

using System;




class PtInCircleRectangle
{
    static void Main(string[] args)
    {
        //Define point
        Console.WriteLine("Enter the coordinate of the number to check whether it is \ninside circle K({1, 1}, 1.5) \nand out of the rectangle R(top=1, left=-1, width=6, height=2).");
        Console.Write("x coordinate of the point: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("y coordinate of the point: ");
        double y = double.Parse(Console.ReadLine());

        //Formula for the circle is (x-k)^2 + (y-k)^2 = r^2
        bool inCircle = (x - 1)*(x - 1)  + (y-1)*(y - 1) <= 1.5*1.5;
        Console.WriteLine("inCircle = " + inCircle);
        

        //rectangle coordinates left: -1; right:5; top: 1; bottom: -1; 
        //                      (x < -1) && (x > 5) && (y < -1) && (y > 1)
        bool outsideRectangle = (x + 1 < 0) && (x - 5 > 0) && (y + 1 < 0) && (y - 1 > 0);
        Console.WriteLine("outsideRectangle = " + outsideRectangle);

        bool inCircleOutsideRectangle = inCircle && outsideRectangle;

        Console.WriteLine("Is point with coordinates {0},{1} inside the circle but outside rectangle? {2}", x, y, inCircleOutsideRectangle ? "Yes!" : "No!");
        

    }
}
