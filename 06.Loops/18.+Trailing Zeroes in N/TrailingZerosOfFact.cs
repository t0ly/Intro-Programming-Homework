using System;

using System.Numerics;


//http://msdn.microsoft.com/en-us/library/7314433t(v=vs.80).aspx
//    How to: Add and Remove References in Visual Studio (C#, J#)  
//    In Solution Explorer, select the project.
//    On the Project menu, choose Add Reference.
//    The Add Reference dialog box opens.
//    Select the tab indicating the type of component you want to reference.
//    In the top pane, select the component you want to reference, and then click the Select button. Press CTRL while clicking to select multiple components.



class TrailingZerosOfFact
{
    /// <summary>
    /// 18.* Trailing Zeroes in N!
    ///   Write a program that calculates with how many zeroes the factorial of a given number n has at its end.     
    ///     Your program should work well for very big numbers, e.g. n=100000.
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        int n = 1;
        BigInteger nfactorial = 1;


        Console.WriteLine("Calculates with how many zeroes the factorial of a given number n has at its end");
        while(true)
        {
            Console.Write("n: ");
            n = int.Parse(Console.ReadLine());

            if(0 < n && n < 100)
            {
                break;
            }
            Console.WriteLine("Sorry, try again! 0 < n < 1000");
        }


        for(int i = 1; i <= n; i++)
        {
            nfactorial *= i;
        }

        
        byte[] bytes = nfactorial.ToByteArray();
        Console.WriteLine(nfactorial.ToString().Length);

        for(int i = bytes.Length; i == 0; i--)
        {
            Console.WriteLine(bytes[i]);



        }

        //string myfactorial = nfactorial.ToString();

        //int counter = myfactorial.Length - 1;
        //int zeros = 0;


        //while(counter > 0)
        //{
        //    Console.WriteLine(myfactorial[counter] == 0);

        //    if(myfactorial[counter] == 0)
        //    {
        //        zeros++;
        //        counter--;
        //    }
        //    else
        //    {
        //        break;
        //    }

    }


    //Console.Write("n! = {0} has {1} trailing zeros ", nfactorial, zeros);
    //Console.WriteLine();

}