/*8. Digit as Word

    Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
        Print “not a digit” in case of invalid input.
        Use a switch statement.
*/

using System;


class DigitAsWord
{
    static void Main(string[] args)
    {

        Console.WriteLine("//Digit as word:");
        Console.Write("Please enter digit [0 - 9]: ");
        int digit = int.Parse(Console.ReadLine());
        string digitAsWord = "N/A";

        switch (digit)
        {

            case 0: digitAsWord = "zero"; break;
            case 1: digitAsWord = "one"; break;
            case 2: digitAsWord = "two"; break;
            case 3: digitAsWord = "three"; break;
            case 4: digitAsWord = "four"; break;
            case 5: digitAsWord = "five"; break;
            case 6: digitAsWord = "six"; break;
            case 7: digitAsWord = "seven"; break;
            case 8: digitAsWord = "eight"; break;
            case 9: digitAsWord = "nine"; break;

            default: digitAsWord = "not a digit"; break;
        }

        Console.WriteLine("Digit \"{0}\" is \"{1}\". ", digit, digitAsWord);
    
    }
}