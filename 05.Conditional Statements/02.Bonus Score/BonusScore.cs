/*
 * 2. Bonus Score

    Write a program that applies bonus score to given score in the range [1…9] by the following rules:
        If the score is between 1 and 3, the program multiplies it by 10.
        If the score is between 4 and 6, the program multiplies it by 100.
        If the score is between 7 and 9, the program multiplies it by 1000.
        If the score is 0 or more than 9, the program prints “invalid score”.
*/


using System;

class BonusScore
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter score [1-9] to calculate bonus score");
        int score = int.Parse(Console.ReadLine());
        int bonus = 0;

        //the if way
        if ((1 <= score) && (score <= 3 ))
        {
            bonus = score * 10;
        }
        else if ((4 <= score) && (score <= 6))
        {
            bonus = score * 100;
        }
        else if ((7 <= score) && (score <= 9))
        {
            bonus = score * 1000;
        }
        else
        {
            Console.WriteLine("Invalid Score! (\"if\" method)");
        }


        ////the switch way
        //switch (score)
        //{
        //    case 1:
        //    case 2:
        //    case 3:
        //        bonus = score * 10;
        //        break;
        //    case 4:
        //    case 5:
        //    case 6:
        //        bonus = score * 100;
        //        break;
        //    case 7:
        //    case 8:
        //    case 9:
        //        bonus = score * 1000;
        //        break;
        //    default:
        //        Console.WriteLine("Invalid Score! (\"switch\" method)");
        //        break;
        //}

        Console.WriteLine("Your score is {0}", bonus);
    }
}