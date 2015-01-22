//Problem 3. Divide by 7 and 5

//    Write a Boolean expression that checks for given integer if it can be divided (without remainder) 
// by 7 and 5 at the same time.

//Examples:
//n 	Divided by 7 and 5?
//3 	false
//0 	false
//5 	false
//7 	false
//35 	true
//140 	true

using System;

class isDivisibleBy7and5
{
    static void Main(string[] args)
    {
    
    int[] samples = new int[6]{3,0,5,7,35,140};  //will check these numbers
    bool[] results = new bool[6];                //will store the results in this array

    //print the header before the loop
    Console.WriteLine("n\tCan be divided by 7 and 5?");
    Console.WriteLine("------------------------------");
       

    //loop throug the samples array
    for (int i = 0; i < samples.Length; i++)
    {


        //result nr set to true if test nr is divisible by 7*5 , and false if nr is 0
        results[i] = (samples[i] == 0) ? false : (samples[i] % 35 == 0);

        //print the result
        Console.WriteLine("{0}\t{1}", samples[i], results[i]);
    }
       
   
    }
}
