//Problem 2. Float or Double?

//    Which of the following values can be assigned to a variable of type float 
//    and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
//    Write a program to assign the numbers in variables and print them to ensure no precision is lost.



using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

class FloatDoubleVar
{
    static void Main(string[] args)
        {

            float floatVar1 = 12.345f;
            float floatVar2 = 3456.091f;
            double doubleVar1 = 34.567839023;
            double doubleVar2 = 8923.1234857;


            Console.WriteLine("float floatVar1 12.345f is {0}",floatVar1);
            Console.WriteLine("float floatVar2 3456.091f is {0}", floatVar2);
            Console.WriteLine("double doubleVar1 34.567839023 is  {0}", doubleVar1);
            Console.WriteLine("double doubleVar2 8923.1234857  is {0}", doubleVar2);
        }
}