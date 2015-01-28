/*
 * 2. Print Company Information

    A company has name, address, phone number, fax number, web site and manager. 
 *  The manager has first name, last name, age and a phone number.
    Write a program that reads the information about a company and its manager and prints it back on the console.
*/

using System;
using System.Text.RegularExpressions;


class PrintCoInfo
{

    public static string JustNumbers(string phone)
    {
        Regex digitsOnly = new Regex(@"[^\d]");
        return digitsOnly.Replace(phone, "");
    }


    static void Main(string[] args)
    {
        

        Console.Write("Please enter company name: ");
        string coName = Console.ReadLine();
        coName = coName.Length == 0 ? "(no name)" : coName;
        Console.Write(" address: ");
        string coAddress = Console.ReadLine();
        coAddress = coAddress.Length == 0 ? "(online bussiness)" : coAddress;
        
        Console.Write(" phone number: ");        
        int coPhone;
        bool coPhoneIsNumber  = int.TryParse(JustNumbers(Console.ReadLine()), out coPhone);

        Console.Write(" fax number: ");        
        int coFax ;
        bool coFaxIsNum = int.TryParse(JustNumbers(Console.ReadLine()), out coFax);
     
        Console.Write(" web site: ");
        string coWebsite = Console.ReadLine();
        coWebsite = coWebsite.Length == 0 ? "(no website)" : "http://" + coWebsite.Replace("http://",null).Replace("/",null);  //make sure address is starts with "http://"        
        
        Console.Write("Manager first name: ");
        string mgrFirstname = Console.ReadLine();
        mgrFirstname = mgrFirstname.Length == 0 ? "(no firstname)" : mgrFirstname;
        Console.Write(" last name: ");
        string mgrLastname = Console.ReadLine();
        mgrLastname = mgrLastname.Length == 0 ? "(no lastname)" : mgrLastname;
        Console.Write(" age: ");
        int mgrAge;
        bool mgrAgeExists = int.TryParse(JustNumbers(Console.ReadLine()), out mgrAge);
        

        Console.Write(" phone number: ");
        int mgrPhone;
        bool mgrPhoneExists = int.TryParse(JustNumbers(Console.ReadLine()), out mgrPhone);
    


        Console.WriteLine(@"
{0}
Address: {1}
Tel. {2:### ### ## ## ##} 
Fax: {3:### ### ## ## ##}
Web site: {4,6}
Manager: {5} {6} (age: {7}, tel. {8:### ## ### ###})
", coName, coAddress, coPhone, coFax, coWebsite, mgrFirstname, mgrLastname, mgrAge, mgrPhone);



    }
}
