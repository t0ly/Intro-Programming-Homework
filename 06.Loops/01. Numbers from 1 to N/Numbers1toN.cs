﻿using System;

    /// <summary>
    /// 1. Numbers from 1 to N
    /// Write a program that enters from the console a positive integer n 
    /// and prints all the numbers from 1 to n, on a single line, separated by a space.
    /// </summary>
class Numbers1toN
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter positive integer n: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {

            Console.Write(i + " ");

        }

        Console.WriteLine();

    }
}