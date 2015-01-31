using System;


class RandomInRange
{

    /// <summary>
    /// 11. Random Numbers in Given Range
    /// Write a program that enters 3 integers n, min and max (min != max) 
    /// and prints n random numbers from the range [min...max].
    /// 
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        int min, max, n = 1;

        Console.WriteLine("prints n random numbers from the range [min...max]");

        while (true)
        {
            Console.Write("min: ");
            min = int.Parse(Console.ReadLine());
            Console.Write("max: ");
            max = int.Parse(Console.ReadLine());
            Console.Write("n: ");
            n = int.Parse(Console.ReadLine());

            if (min < max && n > 0)
            {
                break;
            }

            Console.WriteLine("Wrong input! mint != max");
        }


        Random rnd = new Random();


        for (int i = 0; i <= n; i++)
        {
            Console.Write("{0,2}   ", rnd.Next(min, max));
        }

        Console.WriteLine();
    }
}