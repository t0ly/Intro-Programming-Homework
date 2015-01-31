using System;


class HexToDec
{

    /// <summary>
    /// 15. Hexadecimal to Decimal 
    /// Using loops write a program that converts a hexadecimal integer number to its decimal form
    /// The input is entered as string. The output should be a variable of type long
    /// Do not use the built-in .NET functionality.
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        long decNr = 0;

        Console.WriteLine("converts a hexadecimal integer number to its decimal form.");
        Console.Write("Enter hex integer: ");


        string input = Console.ReadLine().Trim();

        for (int i = 0; i < input.Length; i++)
        {

            decNr += DeHex(input[i].ToString()) * (long)Math.Pow(16, input.Length - (i + 1));

        }

        Console.WriteLine("hex {0} = decimal {1}", input, decNr);
    }

    
    static int DeHex(string hexnumber)
    {

        int decimalnr = 0;

        switch (hexnumber)
        {
            case "0": decimalnr = 0; break;
            case "1": decimalnr = 1; break;
            case "2": decimalnr = 2; break;
            case "3": decimalnr = 3; break;
            case "4": decimalnr = 4; break;
            case "5": decimalnr = 5; break;
            case "6": decimalnr = 6; break;
            case "7": decimalnr = 7; break;
            case "8": decimalnr = 8; break;
            case "9": decimalnr = 9; break;
            case "A": 
            case "a": 
                decimalnr = 10; break;
            case "B": 
            case "b": 
                decimalnr = 11; break;
            case "C":
            case "c": 
                decimalnr = 12; break;
            case "D":
            case "d": 
                decimalnr = 13; break;
            case "E":
            case "e": 
                decimalnr = 14; break;
            case "F":
            case "f": 
                decimalnr = 15; break;

            default: break;
        }
        return decimalnr;

    }
}