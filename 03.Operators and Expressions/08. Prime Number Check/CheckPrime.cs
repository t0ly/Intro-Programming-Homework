//Problem 8. Prime Number Check

//    Write an expression that checks if given positive integer number n (n <= 100) is prime 
//    (i.e. it is divisible without remainder only to itself and 1).
//    Note: You should check if the number is positive

//Examples:
//n 	Prime?
//1 	false
//2 	true
//3 	true
//4 	false
//9 	false
//97 	true
//51 	false
//-3 	false
//0 	false

//hint :   testing whether n is a multiple of any integer between 2 and sqrt(n)

using System;
using System.Collections.Generic;

class CheckPrime
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter a positive number to check whether it is a prime number:");

        int amIprime = 0;
        int.TryParse(Console.ReadLine(), out amIprime);
        
        int divisorcount = 0;       // simple solution
        
        List<int> divisors = new List<int>();           // advanced solution


        for (int i = 2; i <= Math.Sqrt(amIprime); i++)
        {
            if (amIprime % i == 0)
            {
                divisorcount++;       // simple solution
                divisors.Add(i);       //remember the divisors for the advanced solution

            }
        }
        
        //output simple solution 
        bool isPrime = divisorcount == 0;
        Console.WriteLine("{0} is {1} number!", amIprime, isPrime ? "a prime" : "not a prime");


        //output divisors for the advanced solution
        if (!isPrime)
        {
            Console.Write("It has the following devisors: 1, ");



            foreach (var item in divisors)
            {
                Console.Write(item + ", "); 
            }
            Console.Write(amIprime + ".");
            Console.WriteLine();
        }        
    }
}

