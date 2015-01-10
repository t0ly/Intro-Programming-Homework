//Problem 16.* Print Long Sequence

//    Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
//    You might need to learn how to use loops in C# (search in Internet).


using System;

class PrintLongSequence
{
    static void Main()
    {

        Console.WriteLine("How many members of the sequence: 2, -3, 4, -5, 6, -7, … do you want?");
        Console.Write("Enter a number:");
        long len = long.Parse(Console.ReadLine());        
        
        Console.WriteLine();
        Console.WriteLine("Writing the first " + len + " members of the sequence:");


        for (int i = 2; i < len + 2 ; i++)
        {
            if ((i % 2) == 0)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine(-i);
            }
        }
    }

}