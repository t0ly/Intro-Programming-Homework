//Problem 8. Isosceles Triangle

//    Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:

//   ©

//  © ©

// ©   ©

//© © © ©

//Note: The © symbol may be displayed incorrectly at the console so you may need to change the console character encoding to UTF-8 and assign a Unicode-friendly font in the console.

//Note: Under old versions of Windows the © symbol may still be displayed incorrectly, regardless of how much effort you put to fix it.

using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

class Triangle
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        
        // Triangle dimentions
        int height = 7;
        int width = 7;

        //Drawing elements
        char spacer = ' ';
        char copy = '\u00a9';

        //Draw the tip first
        string spaceOnSides = new String(spacer, (width - 1) / 2);
        Console.WriteLine(spaceOnSides + copy);

        //Draw the body
        //Outer loop for heght
        for (int i = 2; i < height - 1; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine();
            }
            else
            {
                string bodySpaceOnSides = new String(spacer, (width - i) / 2);
                string spaceMid = new String(spacer, i - 2);
                Console.WriteLine(bodySpaceOnSides + copy + spaceMid + copy); // + bodySpaceOnSides
            }
        }

        //Draw bottom
        Console.WriteLine();

        for (int j = 1; j <= width / 2; j++)
        {
            Console.Write(copy);
            Console.Write(spacer);
        }
        Console.WriteLine(copy);
    }
}