using System;

class Randomize1N
    {
    /// <summary>
    ///  Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
        {

        //get n from user        
        Console.WriteLine("prints the numbers 1, 2, …, n in random order");
        Console.Write("Enter integer n: ");
        int n = int.Parse(Console.ReadLine());

        //initialize the numbers array, sort array, and randomness
        int[] numbersArray = new int[n];       
        double[] sortArray = new double[n];    
        Random rnd = new Random();             

        //populate the two arrays
        for(int i = 0; i < n; i++)
            {
            sortArray[i] = rnd.NextDouble();
            numbersArray[i] = i + 1;
            }

        //this is what does the trick
        Array.Sort(sortArray, numbersArray);

        //output the random order
        foreach(var nr in numbersArray)
            {
            Console.Write("{0,2}   ", nr);
            }
        
        //clear the console
        Console.WriteLine();


        }
    }