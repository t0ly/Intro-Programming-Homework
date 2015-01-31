using System;


class NrCombinations
{
    /// <summary>
    /// Problem 7. Calculate N! / (K! * (N-K)!)
    /// In combinatorics, the number of ways to choose k different members out of a group of n different elements 
    /// (also known as the number of combinations) is calculated by the following formula: 
    /// formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
    /// Your task is to write a program that calculates 
    /// n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). 
    /// Try to use only two loops.
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        int n = 1;
        int k = 1;
        decimal nfactorial = 1m;
        decimal kfactorial = 1m;
        decimal nkfactorial = 1m;
        decimal combinations = 0;

        Console.WriteLine("Calculate number of combinations = n! / (k! * (n-k)!), given 1 < k < n < 100");
        while (true)
        {
            Console.Write("n: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("k: ");
            k = int.Parse(Console.ReadLine());
            if (k < n && n < 100)
            {
                break;
            }
            Console.WriteLine("Sorry, try again! 1 < k < n < 100");
        }

        //n! / (k! * (n-k)!)

        //using just 1 loop!

        for (int i = 1; i <= n; i++)
        {
            nfactorial *= i;

            //k!
            if (i <= k)
            {
                kfactorial *= i;
            }

            //(n-k)!
            if (i <= (n - k))
            {
                nkfactorial *= i;
            }

        }

        checked { combinations = nfactorial / (kfactorial * nkfactorial); }

        Console.Write("{0} / ({1} * {2}) = {3}", nfactorial, kfactorial, nkfactorial, combinations);
        Console.WriteLine();

    }

}