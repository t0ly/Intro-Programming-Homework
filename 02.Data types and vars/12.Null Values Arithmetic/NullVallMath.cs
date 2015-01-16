//Problem 12. Null Values Arithmetic

//    Create a program that assigns null values to an integer and to a double variable.
//    Try to print these variables at the console.
//    Try to add some number or the null literal to these variables and print the result.


using System;



class NullVallMath
{
    static void Main(string[] args)
    {
        Nullable<int> i = null;     //Nullable the hard way
        double? d = null;           //easy way

        Console.WriteLine("They made me print my nulls! int null ({0}) and precious double null ({1})", i, d);        
        
        Console.WriteLine("Null stays null: null i + 1 = {0} , and null d + null = {1}!", i++, d + null);
    }
}
