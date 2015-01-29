

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Number_as_Words
{

    /// <summary>
    /// 11.* Number as Words
    ///    Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.
    /// </summary>
    class NumbersAsWords
    {

        static void Main(string[] args)
        {
            Console.Write("Enter a number to spell it out: ");
            int number = int.Parse(Console.ReadLine());
            string words = "";

            if (number == 0)
            {
                words = "Zero";
            } 
            else if (number < 20)
            {
                words = ToWord(number);
            }        
            else if(number < 100)
            {
                words = ToWord((number / 10) * 10) + " " +  ToWord(number % 10);                 
            }
            else if (number < 1000)
            {
                words = ToWord(number / 100) + " Hundred " + ToWord((number%100 / 10) * 10) + " " + ToWord(number % 10);
            }
            else if (number < 1000000)
            {
                                               
                words = ToWord(number / 1000) + " Thousand " + ToWord(((number % 1000) / 100)) + 
                    " Hundred " + ToWord((number % 100 / 10) * 10) + " " + ToWord(number % 10);
            }
            else  {
                words = "Gaziloopon and thirty-three. No, really I don't know to count that high!";
            }

            Console.WriteLine(words);

        }

        public static string ToWord(int nr)
        {

            string word = "";

            switch (nr)
            {
                //case 0: word += "and"; break;
                case 1: word += "One"; break;
                case 2: word += "Two"; break;
                case 3: word += "Three"; break;
                case 4: word += "Four"; break;
                case 5: word += "Five"; break;
                case 6: word += "Six"; break;
                case 7: word += "Seven"; break;
                case 8: word += "Eight"; break;
                case 9: word += "Nine"; break;
                case 10: word += "Ten"; break;
                case 11: word += "Eleven"; break;
                case 12: word += "Twelve"; break;
                case 13: word += "Thirteen"; break;
                case 14: word += "Fourteen"; break;
                case 15: word += "Sixteen"; break;
                case 16: word += "Seventeen"; break;
                case 17: word += "Eighteen"; break;
                case 18: word += "Nineteen"; break;
                case 20: word += "Twenty"; break;
                case 30: word += "Thirty"; break;
                case 40: word += "Forty"; break;
                case 50: word += "Fifty"; break;
                case 60: word += "Sixty"; break;
                case 70: word += "Seventy"; break;
                case 80: word += "Eighty"; break;
                case 90: word += "Ninety"; break;
                default: break;

            }

            return word;
        }

    }
}
