using System;

class PrintDeck
{
    /// <summary>
    /// Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
    /// The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
    /// The card faces should start from 2 to A.
    /// Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a 
    /// switch-case statement.
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        char suitname = 'n';
        String rankname = "";


        for (int rank = 2; rank <= 14; rank++)
        {
            switch (rank)
            {
                case 2: rankname = "2"; break;
                case 3: rankname = "3"; break;
                case 4: rankname = "4"; break;
                case 5: rankname = "5"; break;
                case 6: rankname = "6"; break;
                case 7: rankname = "7"; break;
                case 8: rankname = "8"; break;
                case 9: rankname = "9"; break;
                case 10: rankname = "10"; break;
                case 11: rankname = "J"; break;
                case 12: rankname = "Q"; break;
                case 13: rankname = "K"; break;
                case 14: rankname = "A"; break;

                default: break;
            }

            for (int suit = 1; suit <= 4; suit++)
            {
                switch (suit)
                {
                    case 1: Console.ForegroundColor = ConsoleColor.Gray; suitname = '\u2663'; break; //♣
                    case 2: Console.ForegroundColor = ConsoleColor.Red; suitname = '\u2666'; break;  //♦
                    case 3: Console.ForegroundColor = ConsoleColor.Gray; suitname = '\u2660'; break; //♠
                    case 4: Console.ForegroundColor = ConsoleColor.Red; suitname = '\u2665'; break;  //♥
                    //case 1: suitname = "clubs"; break;
                    //case 2: suitname = "diamonds"; break;
                    //case 3: suitname = "hearts"; break;
                    //case 4: suitname = "spades"; break;
                    default: break;
                }

                Console.Write("{0,2} of {1}\t", rankname, suitname);

            }
            Console.ResetColor();
            Console.WriteLine();
       
        }
        Console.WriteLine();
    }
}
 