/*
 * Problem 14. Modify a Bit at Given Position

    We are given an integer number n, a bit value v (v=0 or 1) and a position p.
    Write a sequence of operators (a few lines of C# code) that 
    modifies n to hold the value v at the position p from the binary representation of n 
    while preserving all other bits in n.

Examples:
n 	binary representation of n 	p 	v 	binary result 	    result
5    	00000000 00000101   	2 	0 	00000000 00000001 	1
0 	    00000000 00000000 	    9 	1 	00000010 00000000 	512
15 	    00000000 00001111    	1 	1 	00000000 00001111 	15
5343 	00010100 11011111   	7 	0 	00010100 01011111 	5215
62241 	11110011 00100001 	    11 	0 	11110011 00100001 	62241
 */
using System;

class ModifyBitAtPosition
{
    static void Main(string[] args)
    {
        int n = 0;  
        int p = 9;  // will be set by user
        int v = 1;  // will be set by user
        
        int mask = (1 << p);
        int m = (v == 0) ? n & ~mask : n | mask; 

        Console.WriteLine("n\tbin n\tp\tv\tbin result\t\tresult");
        Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t\t{5}", n, Convert.ToString(n, 2), p, v, Convert.ToString(m, 2), m);
    }
}