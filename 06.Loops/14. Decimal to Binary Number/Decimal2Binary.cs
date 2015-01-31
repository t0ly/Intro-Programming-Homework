using System;

class Decimal2Binary
{
    static void Main(string[] args)
    {

        string tmpbinary = "";

        int counter = 0;

        Console.WriteLine("converts an integer to its binary form.");
        Console.Write("Enter integer: ");

        long decimalinput = long.Parse(Console.ReadLine().Trim());

        long dividend = decimalinput;
        while (dividend != 0)
        {
            tmpbinary += dividend % 2;
            dividend = dividend / 2;
            counter++;
        }


        Console.Write("decimal {0} = binary ", decimalinput);
        for (int i = counter - 1; i >= 0; i--)
        {
            Console.Write(tmpbinary[i]);
        }
        Console.WriteLine();
    }
}