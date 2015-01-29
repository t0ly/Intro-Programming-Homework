

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
            int len = number.ToString().Length;
            string words = "";

            switch (len)
            {
                case 1:
                  
                    words = (number == 0) ? "Zero" : Digits(number);
                    break;

                case 2: //10 to 99
                    if (number < 20)
                    {
                        words = Digits(number);
                    } 
                    else 
                    {
                        words = Tens(number) + " " + Digits(number);
                    }
                    break;
                

                case 3:
                    if (number % 100 == 0)
                    {
                        words = Digits(number / 100) + "hundered";
                    }
                    else
                    {
                        words = Tens(number / 10) + Digits(number / 100) + "hundered";
                    }
                    break;

                default:
                    break;
            }
            
            //if (number == 0)
            //{
            //    words = "Zero";
            //}
            //else if (number < 20)
            //{
            //    words = Digits(number);
            //}
            //else if (number < 100)
            //{
            //    words = Tens(number) + Digits(number) ;
            //}
            //else if (number < 1000)
            //{
            //    words = Hundreds(number) + " " + Tens(number) + Digits(number);
            //}
      
            

      

            Console.WriteLine(words);

        }

        public static string Digits(int nr)
        {

            string word = "";

            switch (nr)
            {
                case 0: word += "and"; break;
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
                case 15: word += "Fifteen"; break;
                case 16: word += "Sixteen"; break;
                case 17: word += "Seventeen"; break;
                case 18: word += "Eighteen"; break;
                case 19: word += "Nineteen"; break;

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

        public static string Tens(int nr)
        {

            string word = "";

            switch (nr)
            {
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

        public static string Hundreds(int nr)
        {
            
            string word = "";
            switch (nr)
            {
                case 100: word += "One Hundred"; break;
                case 200: word += "Two Hundred"; break;
                case 300: word += "Three Hundred"; break;
                case 400: word += "Four Hundred"; break;
                case 500: word += "Five Hundred"; break;
                case 600: word += "Six Hundred"; break;
                case 700: word += "Seven Hundred"; break;
                case 800: word += "Eight Hundred"; break;
                case 900: word += "Nine Hundred"; break;
                
                default:
                    break;
            }
            return word;
        }
    }
}
