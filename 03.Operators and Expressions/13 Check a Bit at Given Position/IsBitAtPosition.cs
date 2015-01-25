/*
 * Problem 13. Check a Bit at Given Position

    Write a Boolean expression that returns if the bit at position p 
   (counting from 0, starting from the right) in given integer number n, has value of 1.

Examples:
n 	binary representation of n 	p 	bit @ p == 1
5 	    00000000 00000101 	    2 	true
0 	    00000000 00000000 	    9 	false
15 	    00000000 00001111 	    1 	true
5343 	00010100 11011111 	    7 	true
62241 	11110011 00100001 	    11 	false
  
 */

using System;

class IsBitAtPosition
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());  // 5343;  //set by user
        Console.Write("Enter bit position: ");
        int p = int.Parse(Console.ReadLine());  //7;      //set by user

        int mask = 1 << p;
        int bitAtIndex = (n & mask) >> p;
        bool bitIs1 = (bitAtIndex == 1 )? true : false;
        Console.WriteLine("n\t\tbinary\t\t\tp\tbit @ p == 1");
        Console.WriteLine("{0}\t\t{1}\t\t{2}\t{3}", n, Convert.ToString(n, 2), p, bitIs1);
   
    
    }


}
