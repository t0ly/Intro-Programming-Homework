/*9. Play with Int, Double and String

    Write a program that, depending on the user’s choice, inputs an int, double or string variable.
        If the variable is int or double, the program increases it by one.
        If the variable is a string, the program appends * at the end.
    Print the result at the console. Use switch statement.
*/

using System;


class UsrChoice
{
    static void Main(string[] args)
    {

        Console.Write("Please choose a type:\n 1 --> int \n 2 --> double \n 3 --> string \nPlease enter your choice: ");
        string selector = Console.ReadLine();

        switch (selector)
        {
            case "1":
                Console.Write("Please enter an integer: ");
                int intInput = int.Parse(Console.ReadLine());
                Console.WriteLine(++intInput);
                break;
            case "2":
                Console.Write("Please enter a real number: ");
                double dblInput = double.Parse(Console.ReadLine());
                Console.WriteLine(++dblInput);
                break;
            case "3":
                Console.Write("Please enter a string: ");
                string strInput = Console.ReadLine();
                Console.WriteLine(strInput + "*");
                break;
            default:
                break;
        }
    
    }
}